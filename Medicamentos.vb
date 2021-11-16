Public Class Medicamentos
    Private Sub Medicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Medicamentos' Puede moverla o quitarla según sea necesario.
        Me.MedicamentosTableAdapter.Fill(Me.DataSet.Medicamentos)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonNuevoMedicamento_Click(sender As Object, e As EventArgs) Handles ButtonNuevoMedicamento.Click
        AgregarMedicamento.Show()
    End Sub
End Class