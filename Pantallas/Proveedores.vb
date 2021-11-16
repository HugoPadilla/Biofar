Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DataSet.Proveedores)

    End Sub
    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs)
        'Limpiar el formulario'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonNuevoProveedor.Click
        AgregarProveedor.Show()
    End Sub

    Private Sub DataGridViewProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProveedores.CellContentClick

    End Sub
End Class