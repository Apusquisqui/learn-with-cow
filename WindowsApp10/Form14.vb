Public Class frm_Q5
    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick, Button3.MouseClick, Button1.MouseClick
        MessageBox.Show("Respuesta incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Obtener el formulario principal que contiene el panel
            Dim formularioPrincipal As Form = FindForm()

            ' Verificar si el formulario principal no es nulo y cerrarlo
            If formularioPrincipal IsNot Nothing Then
                formularioPrincipal.Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al cerrar el formulario principal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        frm_QFN1.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub frm_Q5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_Nl1_Q1.btn_F.Visible = True
    End Sub
End Class