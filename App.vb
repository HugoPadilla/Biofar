Public Class App

    Dim isLogin As Boolean = False

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBoxLogo.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarFormulario(New Inicio, "Inicio")
    End Sub

    Private formularioActual As Form = Nothing
    Private Sub cargarFormulario(formularioHijo As Form, titulo As String)

        If formularioActual IsNot Nothing Then formularioActual.Close()
        formularioActual = formularioHijo
        formularioHijo.TopLevel = False
        formularioHijo.FormBorderStyle = FormBorderStyle.None
        formularioHijo.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(formularioHijo)
        PanelContenedor.Tag = formularioHijo
        formularioHijo.BringToFront()
        formularioHijo.Show()

        LabelTitle.Text = titulo

    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        cargarFormulario(New Inicio, "Inicio")
    End Sub

    Private Sub ButtonVentas_Click(sender As Object, e As EventArgs) Handles ButtonVentas.Click
        cargarFormulario(New Facturacion, "Ventas")
    End Sub

    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        cargarFormulario(New Clientes, "Clientes")
    End Sub

    Private Sub ButtonInventario_Click(sender As Object, e As EventArgs) Handles ButtonInventario.Click
        cargarFormulario(New Medicamentos, "Inventario")
    End Sub

    Private Sub ButtonProveedor_Click(sender As Object, e As EventArgs) Handles ButtonProveedor.Click
        cargarFormulario(New Proveedores, "Proveedor")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelTitle.Click

    End Sub
    Private Sub PanelContenedorPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedorPrincipal.Paint
        If isLogin Then
            cargarAppLogin()
        Else
            cargarAppLogin()
        End If
    End Sub


    Public Sub cargarAppLogin()
        Dim formularioLogin As New Login
        AddOwnedForm(formularioLogin)

        formularioLogin.TopLevel = False
        formularioLogin.FormBorderStyle = FormBorderStyle.None
        formularioLogin.Dock = DockStyle.Fill
        PanelContenedorPrincipal.Controls.Add(formularioLogin)
        PanelContenedorPrincipal.Tag = formularioLogin
        formularioLogin.BringToFront()
        formularioLogin.Show()
    End Sub

End Class