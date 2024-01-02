Public Class frm_op
    Private Sub frm_op_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Etapa 1"
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False

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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.Hide()
        frm_nvl.Show()
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
End Class