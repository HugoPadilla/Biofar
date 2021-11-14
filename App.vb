Public Class App
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBoxLogo.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarFormulario(New Inicio)
    End Sub

    Private formularioActual As Form = Nothing
    Private Sub cargarFormulario(formularioHijo As Form)

        If formularioActual IsNot Nothing Then formularioActual.Close()
        formularioActual = formularioHijo
        formularioHijo.TopLevel = False
        formularioHijo.FormBorderStyle = FormBorderStyle.None
        formularioHijo.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(formularioHijo)
        PanelContenedor.Tag = formularioHijo
        formularioHijo.BringToFront()
        formularioHijo.Show()

    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        cargarFormulario(New Inicio)
    End Sub

    Private Sub ButtonVentas_Click(sender As Object, e As EventArgs) Handles ButtonVentas.Click
        cargarFormulario(New Facturacion)
    End Sub

    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        cargarFormulario(New Clientes)
    End Sub

    Private Sub ButtonInventario_Click(sender As Object, e As EventArgs) Handles ButtonInventario.Click
        cargarFormulario(New Medicamentos)
    End Sub

    Private Sub ButtonProveedor_Click(sender As Object, e As EventArgs) Handles ButtonProveedor.Click
        cargarFormulario(New Proveedores)
    End Sub
End Class