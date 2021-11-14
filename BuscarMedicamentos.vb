Public Class BuscarMedicamentos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(Datos1.Text) = "" Then
            MsgBox(" Hay Datos Pendientes, por favor llenar ", vbOKOnly + vbInformation, "Datos Pendientes")
            Datos1.Focus()
        Else
            If R1.Checked = True Then
                Me.MedicamentosTableAdapter.BusReferencia(Me.DataSet.Medicamentos, Datos1.Text)
            Else
                If R2.Checked = True Then
                    Me.MedicamentosTableAdapter.BusNombre(Me.DataSet.Medicamentos, Datos1.Text)
                Else
                    If R3.Checked = True Then
                        Me.MedicamentosTableAdapter.BusFechaEx(Me.DataSet.Medicamentos, Datos1.Text)
                    Else
                        If R4.Checked = True Then
                            Me.MedicamentosTableAdapter.BusIDGrupo(Me.DataSet.Medicamentos, Datos1.Text)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.MedicamentosTableAdapter.Fill(Me.DataSet.Medicamentos)
        Datos1.Text = ""
        R1.Checked = True
        Datos1.Focus()
    End Sub

    Private Sub BuscarMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Medicamentos' Puede moverla o quitarla según sea necesario.
        Me.MedicamentosTableAdapter.Fill(Me.DataSet.Medicamentos)

    End Sub
End Class