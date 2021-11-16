Public Class App

    Dim isLogin As Boolean = True
    Private formularioActual As Form = Nothing

    Private Sub cargarFormulario(formularioHijo As Form, titulo As String)

        If formularioActual IsNot Nothing Then formularioActual.Close()

        formularioActual = formularioHijo

        formularioHijo.TopLevel = False
        formularioHijo.FormBorderStyle = FormBorderStyle.None
        formularioHijo.Dock = DockStyle.Fill

        PanelContenedorPrincipal.Controls.Add(formularioHijo)
        PanelContenedorPrincipal.Tag = formularioHijo

        formularioHijo.BringToFront()
        formularioHijo.Show()

    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isLogin Then
            cargarFormulario(New Principal, "Principal")
        Else
            cargarFormulario(New Login, "Login")
        End If
    End Sub
End Class