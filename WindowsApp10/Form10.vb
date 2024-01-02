Public Class frm_error
    Private Sub ap_Click(sender As Object, e As EventArgs) Handles ap.Click
        abrirForm(Of frm_Q1)()
        Label1.Visible = False
        ap.Visible = False
    End Sub

    Public Sub abrirForm(Of Miform As {Form, New})()

        Dim Formulario As Form
        Formulario = panelAr.Controls.OfType(Of Miform)().FirstOrDefault()

        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            panelAr.Controls.Add(Formulario)
            panelAr.Tag = Formulario
            Formulario.Show()

        Else

            Formulario.BringToFront()

        End If

    End Sub

    Private Sub panelAr_Paint(sender As Object, e As PaintEventArgs) Handles panelAr.Paint

    End Sub
End Class