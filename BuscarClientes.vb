Public Class BuscarClientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(DatoC.Text) = "" Then
            MsgBox(" Hay Datos Pendientes, por favor llenar ", vbOKOnly + vbInformation, "Datos Pendientes")
            DatoC.Focus()
        Else
            If R1.Checked = True Then
                Me.ClientesTableAdapter.BusDocumento(Me.DataSet.Clientes, DatoC.Text)
            Else
                If R2.Checked = True Then
                    Me.ClientesTableAdapter.BusNombre(Me.DataSet.Clientes, DatoC.Text)
                Else
                    If R3.Checked = True Then
                        Me.ClientesTableAdapter.BusApellido(Me.DataSet.Clientes, DatoC.Text)
                    Else
                        If R4.Checked = True Then
                            Me.ClientesTableAdapter.BusDireccion(Me.DataSet.Clientes, DatoC.Text)
                        Else
                            If R5.Checked = True Then
                                Me.ClientesTableAdapter.BusTelefono(Me.DataSet.Clientes, DatoC.Text)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ClientesTableAdapter.Fill(Me.DataSet.Clientes)
        DatoC.Text = ""
        R1.Checked = True
        DatoC.Focus()
    End Sub

    Private Sub BuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DataSet.Clientes)

    End Sub
End Class