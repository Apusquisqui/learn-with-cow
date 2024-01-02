Imports System.Data.SQLite

Public Class Form1

    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False

    Private connectionString As String = "Data Source=LWC.db;Version=3;"
    Dim connection As New SQLiteConnection

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles frm_registro.Click

        nu = txt_usuario.Text
        con = txt_contraseña.Text

        Me.Hide()
        frm_inicio.Show()

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        txt_contraseña.PasswordChar = String.Empty
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        txt_contraseña.PasswordChar = "*"
    End Sub

    Private Sub btn_min_Click(sender As Object, e As EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_cer_Click(sender As Object, e As EventArgs) Handles btn_cer.Click
        End
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Public nu As String
    Public con As String

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim usuario As String = txt_usuario.Text
        Dim contraseña As String = txt_contraseña.Text

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM Muu WHERE NP = @NP AND contra = @contra"
            Dim command As New SQLiteCommand(query, connection)
            command.Parameters.AddWithValue("@NP", usuario)
            command.Parameters.AddWithValue("@contra", contraseña)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Inicio de sesión exitoso")

                UsuarioActual.NombreUsuario = usuario ' Almacena el nombre de usuario en la clase UsuarioActual


                Me.Hide()
                frm_nvl.Show()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos")
            End If
        End Using
    End Sub

    Public Class UsuarioActual
        Public Shared Property NombreUsuario As String
        Public Shared Property AppU As String
        Public Shared Property NP As String
        Public Shared Property dia As String
        Public Shared Property mes As String
        Public Shared Property anio As String
    End Class

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub
End Class
