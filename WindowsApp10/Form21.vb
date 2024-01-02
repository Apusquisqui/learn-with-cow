Imports System.Data.SQLite

Public Class frm_amis
    Private Sub frm_amis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False

    Private connectionString As String = "Data Source=LWC.db;Version=3;"

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        End
    End Sub

    Private Sub pbox_n_Click(sender As Object, e As EventArgs) Handles pbox_n.Click
        Me.WindowState = FormWindowState.Normal
        pbox_max.Visible = True
        pbox_n.Visible = False
    End Sub

    Private Sub pbox_max_Click(sender As Object, e As EventArgs) Handles pbox_max.Click
        Me.WindowState = FormWindowState.Maximized
        pbox_max.Visible = False
        pbox_n.Visible = True
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        BuscarUsuarioPorNombre(TextBox1.Text)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.Hide()
        frm_editarper.Show()
    End Sub

    Private Sub BuscarUsuarioPorNombre(nombreABuscar As String)
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' La consulta SQL se adapta para buscar coincidencias por nombre
            Dim query As String = "SELECT * FROM Muu WHERE Nom LIKE @Nombre"
            Dim command As New SQLiteCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", "%" & nombreABuscar & "%") ' El símbolo '%' es un comodín para buscar coincidencias parciales

            Dim reader As SQLiteDataReader = command.ExecuteReader()

            While reader.Read()
                RichTextBox1.Text = reader("NP").ToString()

            End While

            connection.Close()
        End Using
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class