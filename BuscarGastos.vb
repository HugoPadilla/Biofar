Public Class BuscarGastos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(DatoG.Text) = "" Then
            MsgBox(" Hay Datos Pendientes, por favor llenar ", vbOKOnly + vbInformation, "Datos Pendientes")
            DatoG.Focus()
        Else
            If R1.Checked = True Then
                Me.GastoTableAdapter.BusFecha(Me.DataSet.Gasto, DatoG.Text)
            Else
                If R2.Checked = True Then
                    Me.GastoTableAdapter.BusValor(Me.DataSet.Gasto, DatoG.Text)
                Else
                    If R3.Checked = True Then
                        Me.GastoTableAdapter.BusConcepto(Me.DataSet.Gasto, DatoG.Text)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.GastoTableAdapter.Fill(Me.DataSet.Gasto)
        DatoG.Text = ""
        R1.Checked = True
        DatoG.Focus()
    End Sub

    Private Sub BuscarGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Gasto' Puede moverla o quitarla según sea necesario.
        Me.GastoTableAdapter.Fill(Me.DataSet.Gasto)

    End Sub
End Class