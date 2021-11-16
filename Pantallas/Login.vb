Public Class Login
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim email As String
        Dim password As String
        Dim frm As App = CType(Owner, App)

        email = TextBoxCorreo.Text
        password = TextBoxContraseña.Text

        If (email = "usuario@ejemplo.com") And (password = "") Then


        Else
            MsgBox("Usuario o contraseña incorectos, intenta de nuevo")
        End If

    End Sub
End Class