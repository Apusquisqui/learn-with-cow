Imports System.IO
Imports System.Data.SQLite

Public Class frm_perfil

    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False


    Private connectionString As String = "Data Source=LWC.db;Version=3;"
    Dim connection As New SQLiteConnection

    Private Sub frm_perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_dia.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_mes.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_anio.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub ptb_cer_Click(sender As Object, e As EventArgs) Handles ptb_cer.Click
        End
    End Sub

    Private Sub ptb_min_Click(sender As Object, e As EventArgs) Handles ptb_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

        If txt_nom.Text = String.Empty Then

            MessageBox.Show("Uno o mas elemento están vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Me.Hide()
            frm_nvl.Show()

        End If

    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub ibtn_gen_Click(sender As Object, e As EventArgs) Handles ibtn_gen.Click
        If txt_nom.Text = String.Empty Then

            MessageBox.Show("Uno o mas elemento están vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            persona.nombre = txt_nom.Text
            persona.Apell = txt_Apll.Text
            persona.NP = txt_nP.Text
            persona.dia = cmb_dia.Text
            persona.mes = cmb_mes.Text
            persona.anio = cmb_anio.Text
            persona.con = txt_contraseña.Text

            GuardarDatosUsuario()

            Me.Hide()
            frm_nvl.Show()

        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        ' Filtro para mostrar solo archivos de imagen
        openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        ' Mostrar el diálogo para seleccionar un archivo
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                ' Asignar la imagen seleccionada a la clase ImagenGlobal
                ImagenGlobal.ImagenSeleccionada = Image.FromFile(openFileDialog1.FileName)

                ' Asignar la imagen seleccionada a la PictureBox
                PictureBox1.Image = ImagenGlobal.ImagenSeleccionada

            Catch ex As Exception
                MessageBox.Show("No se pudo cargar la imagen: " & ex.Message)
            End Try
        End If
    End Sub

    Public Class ImagenGlobal
        Public Shared Property ImagenSeleccionada As Image
    End Class

    Public Structure Usuario
        Public Property nombre As String
        Public Property dia As String
        Public Property Apell As String
        Public Property NP As String
        Public Property mes As String
        Public Property anio As String

        Public Property con As String

    End Structure

    Public persona As Usuario

    Private Sub GuardarDatosUsuario()
        ' Obtener los valores de las labels
        Dim nombre As String = txt_nom.Text
        Dim apellido As String = txt_Apll.Text
        ' Otros campos...

        Dim imagen As Image = PictureBox1.Image
        Dim ms As New MemoryStream()
        imagen.Save(ms, imagen.RawFormat)
        Dim datosImagen As Byte() = ms.ToArray()

        ' Guardar los datos en la base de datos
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim query As String = "CREATE TABLE IF NOT EXISTS Muu (ID INTEGER PRIMARY KEY AUTOINCREMENT, Nom TEXT, App TEXT, NP TEXT, Dia TEXT, Mes TEXT, Anio TEXT, CorreoE TEXT, NU TEXT, contra TEXT, FP BLOB, UNIQUE (NU, NP))"
            Dim command As New SQLiteCommand(query, connection)
            command.ExecuteNonQuery()

            query = "INSERT INTO Muu (Nom, App, NP, Dia, Mes, Anio, contra, FP) VALUES (@Nom, @App, @NP, @Dia, @Mes, @Anio, @contra, @FP)"
            command = New SQLiteCommand(query, connection)
            command.Parameters.AddWithValue("@Nom", persona.nombre)
            command.Parameters.AddWithValue("@App", persona.Apell)
            command.Parameters.AddWithValue("@NP", persona.NP)
            command.Parameters.AddWithValue("@Dia", persona.dia)
            command.Parameters.AddWithValue("@Mes", persona.mes)
            command.Parameters.AddWithValue("@Anio", persona.anio)
            command.Parameters.AddWithValue("@FP", datosImagen)
            command.Parameters.AddWithValue("@contra", persona.con)
            'command.Parameters.AddWithValue("@FP", Image.FromFile(OpenFileDialog1.FileName))

            ' Otros parámetros para los demás campos...

            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Datos del usuario guardados en la base de datos.")
            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos del usuario: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txt_contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_contraseña.TextChanged

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        txt_contraseña.PasswordChar = String.Empty
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        txt_contraseña.PasswordChar = "*"
    End Sub
End Class