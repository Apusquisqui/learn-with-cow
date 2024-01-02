Public Class frm_nvl

    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False

    Private Sub ptb_logros_Click(sender As Object, e As EventArgs)

    End Sub

    Private contador As Integer = 0
    Private contador2 As Integer = 0
    Private contador3 As Integer = 0

    Private Sub ptb_ayufa_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ptbox_user_Click(sender As Object, e As EventArgs) Handles ptbox_user.Click
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)
        Me.Location = New Point(Me.Location.X, -e.NewValue)
    End Sub

    Private Sub lbl_nvl4_Click(sender As Object, e As EventArgs) Handles lbl_nvl4.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        End
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles pbox_max.Click
        Me.WindowState = FormWindowState.Maximized
        pbox_max.Visible = False
        pbox_n.Visible = True
    End Sub

    Private Sub frm_nvl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Text = "Etapa 1"
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub pbox_n_Click(sender As Object, e As EventArgs) Handles pbox_n.Click
        Me.WindowState = FormWindowState.Normal
        pbox_max.Visible = True
        pbox_n.Visible = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        ' Verifica si el botón izquierdo del mouse está presionado.
        If e.Button = MouseButtons.Left Then
            ' Guarda la posición del mouse y establece la bandera isMouseDown a True.
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        ' Establece la bandera isMouseDown a False cuando se suelta el botón del mouse.
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        ' Verifica si el mouse está presionado y moviéndose.
        If isMouseDown Then
            ' Obtiene la posición actual del mouse y ajusta la posición del formulario.
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub nivel1_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, nivel1.Click, lbl_nvl1.Click
        contador2 += 1

        If contador2 Mod 2 = 0 Then

        Else
            lbl_nvl1.BackColor = Color.Lime
            nivel1.BackColor = Color.Lime
            Me.Hide()
            Form5.Show()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ibtn_men_Click(sender As Object, e As EventArgs) Handles ibtn_men.Click
        contador += 1

        If contador Mod 2 = 0 Then
            iptb_ayuda.Visible = False
            iptb_estads.Visible = False
            iptb_logros.Visible = False
        Else
            iptb_ayuda.Visible = True
            iptb_estads.Visible = True
            iptb_logros.Visible = True
        End If
    End Sub

    Private Sub iptb_per_Click(sender As Object, e As EventArgs) Handles iptb_per.Click
        Me.Hide()
        frm_editarper.ShowDialog()
    End Sub

    Private Sub lbl_nvl2_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click, NIVEL2.Click, lbl_nvl2.Click
        contador3 += 1

        If contador3 Mod 2 = 0 Then

        Else
            lbl_nvl2.BackColor = Color.Lime
            NIVEL2.BackColor = Color.Lime
            Me.Hide()
            Form5.Show()
        End If
    End Sub

    Private Sub iptb_ajustes_Click(sender As Object, e As EventArgs) Handles iptb_ajustes.Click

        Me.Hide()
        frm_op.Show()

    End Sub
End Class