Public Class frm_Q3
    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick, Button2.MouseClick, Button1.MouseClick
        MessageBox.Show("Respuesta incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub abrirForm(Of Miform As {Form, New})(formularioPrincipal As Form)

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



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        abrirForm(Of frm_Q4)(Me)
        Label2.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class