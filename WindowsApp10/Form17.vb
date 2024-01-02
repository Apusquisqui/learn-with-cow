Imports System.IO
Imports System.Data.SQLite
Imports System.Drawing

Public Class frm_editarper

    Private connectionString As String = "Data Source=LWC.db;Version=3;"

    Private Sub ptb_cer_Click(sender As Object, e As EventArgs) Handles ptb_cer.Click
        Me.Close()
    End Sub

    Private Sub ptb_min_Click(sender As Object, e As EventArgs) Handles ptb_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False

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

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BuscarUsuarioPorNombre(Form1.txt_usuario.Text)

    End Sub

    Private Sub ibtn_gen_Click(sender As Object, e As EventArgs) Handles ibtn_gen.Click
        Me.Hide()
        frm_inicio.Show()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        frm_nvl.Show()
    End Sub

    Dim nom As String

    Private Sub MostrarImagenGuardada()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT FP FROM Muu"
            Dim command As New SQLiteCommand(query, connection)

            Dim datosImagen As Byte() = DirectCast(command.ExecuteScalar(), Byte())

            If datosImagen IsNot Nothing AndAlso datosImagen.Length > 0 Then
                Using ms As New MemoryStream(datosImagen)
                    PictureBox1.Image = Image.FromStream(ms)
                End Using
            Else
                MessageBox.Show("No se pudo cargar la imagen.")
            End If
        End Using
    End Sub

    Private Sub BuscarUsuarioPorNombre(nombreABuscar As String)
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM Muu WHERE Nom LIKE @Nombre"
            Dim command As New SQLiteCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", "%" & nombreABuscar & "%")

            Dim reader As SQLiteDataReader = command.ExecuteReader()

            LimpiarControles()

            While reader.Read()
                lbl_nom.Text = reader("Nom").ToString()
                lbl_app.Text = reader("App").ToString()
                lbl_np.Text = reader("NP").ToString()
                lbl_dia.Text = reader("Dia").ToString()
                lbl_mes.Text = reader("Mes").ToString()
                lbl_anio.Text = reader("Anio").ToString()

                MostrarImagenGuardada()
            End While

            connection.Close()
        End Using
    End Sub

    Private Sub LimpiarControles()
        lbl_nom.Text = ""
        lbl_app.Text = ""
        lbl_np.Text = ""
        lbl_dia.Text = ""
        lbl_mes.Text = ""
        lbl_anio.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frm_amis.Show()
    End Sub
End Class