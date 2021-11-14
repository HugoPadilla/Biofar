Public Class BuscarProveedor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(DatoP.Text) = "" Then
            MsgBox(" Hay Datos Pendientes, por favor llenar ", vbOKOnly + vbInformation, "Datos Pendientes")
            DatoP.Focus()
        Else
            If R1.Checked = True Then
                Me.ProveedoresTableAdapter.BusNIT(Me.DataSet.Proveedores, DatoP.Text)
            Else
                If R2.Checked = True Then
                    Me.ProveedoresTableAdapter.BusNombre(Me.DataSet.Proveedores, DatoP.Text)
                Else
                    If R3.Checked = True Then
                        Me.ProveedoresTableAdapter.BusDir(Me.DataSet.Proveedores, DatoP.Text)
                    Else
                        If R4.Checked = True Then
                            Me.ProveedoresTableAdapter.BusTel(Me.DataSet.Proveedores, DatoP.Text)

                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ProveedoresTableAdapter.Fill(Me.DataSet.Proveedores)
        DatoP.Text = ""
        R1.Checked = True
        DatoP.Focus()
    End Sub

    Private Sub BuscarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DataSet.Proveedores)

    End Sub
End Class