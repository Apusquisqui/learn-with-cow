Public Class frm_logNvl2

    Dim mouseOffset As Point
    Dim isMouseDown As Boolean = False

    Private tiempoEspera As Integer = 4000

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Detener el temporizador
        Timer1.Enabled = False

        ' Verificar si el formulario actual está activo antes de cambiar a otro formulario
        If Application.OpenForms.OfType(Of Form5).Any(Function(f) f Is Me) Then
            ' Formulario actual está activo, cambiar a otro formulario
            Dim form2 As New frm_Nl2_Q1()
            form2.Show()
            ' Puedes cerrar el formulario actual si lo deseas
            Me.Close()
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

    Private Sub frm_logNvl2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = tiempoEspera

        Timer1.Start()
    End Sub
End Class