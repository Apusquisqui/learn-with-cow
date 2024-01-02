Public Class frm_QFN1


    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub apppanel_MouseUp(sender As Object, e As MouseEventArgs) Handles apppanel.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub apppanel_MouseDown(sender As Object, e As MouseEventArgs) Handles apppanel.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub apppanel_MouseMove(sender As Object, e As MouseEventArgs) Handles apppanel.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub apppanel_Paint(sender As Object, e As PaintEventArgs) Handles apppanel.Paint

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim form2 As New frm_nvl()
        form2.Show()
        frm_Nl1_Q1.Hide()
        form2.lbl_nvl1.BackColor = Color.Lime
        form2.nivel1.BackColor = Color.Lime
        Me.Close()
    End Sub

    Private Sub frm_QFN1_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate
        frm_Nl1_Q1.Hide()
        frm_Nl1_Q1.apppanel.Hide()
    End Sub

    Private Sub panelAr_Paint(sender As Object, e As PaintEventArgs) Handles panelAr.Paint

    End Sub

    Private Sub btn_F_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_Nl1_Q1.Visible = False

        Try
            frm_Nl1_Q1.Hide()
        Catch ex As Exception
            MessageBox.Show($"Error al cerrar el formulario principal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        frm_Nl1_Q1.Hide()



        frm_nvl.Show()
    End Sub
End Class