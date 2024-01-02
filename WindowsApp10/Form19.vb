Public Class frm_Nl2_Q1
    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False

    Private contador As Integer = 0
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Close()
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

    Private Sub btn_mn_Click(sender As Object, e As EventArgs) Handles btn_mn.Click
        contador += 1

        If contador Mod 2 = 0 Then
            Panel3.Visible = False
        Else
            Panel3.Visible = True
        End If
    End Sub

    Private Sub btn_vol_Click(sender As Object, e As EventArgs) Handles btn_vol.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub ap_Click(sender As Object, e As EventArgs) Handles ap.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub apppanel_MouseUp(sender As Object, e As MouseEventArgs) Handles apppanel.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub apppanel_MouseMove(sender As Object, e As MouseEventArgs) Handles apppanel.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub apppanel_MouseDown(sender As Object, e As MouseEventArgs) Handles apppanel.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private currentform As Form = Nothing

    Public Sub abrirForm(Of Miform As {Form, New})(formularioPrincipal As Form)

        Dim Formulario As Form
        Formulario = panel_Q.Controls.OfType(Of Miform)().FirstOrDefault()

        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            panel_Q.Controls.Add(Formulario)
            panel_Q.Tag = Formulario
            Formulario.Show()

        Else

            Formulario.BringToFront()

        End If

    End Sub
    Private Sub ptb_sig_Click(sender As Object, e As EventArgs) Handles ptb_sig.Click
        abrirForm(Of frm_Q1)(Me)
        Label1.Visible = False
        Label2.Visible = False
        ptb_sig.Visible = False
    End Sub

    Private Sub apppanel_Paint(sender As Object, e As PaintEventArgs) Handles apppanel.Paint

    End Sub

    Public Sub CerrarFormularioPrincipal()
        Me.Close()
    End Sub

    Public Sub btn_F_Click(sender As Object, e As EventArgs) Handles btn_F.Click
        Me.Hide()
        frm_nvl.Show()
    End Sub
End Class