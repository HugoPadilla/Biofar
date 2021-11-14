Public Class Proveedores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try 'Validacion de Controles 
            If Trim(Nit.Text) = "" Then
                MsgBox("Digite el NIT del Proveedor", vbOKOnly + vbInformation, "Datos Requeridos")
                Nit.Focus()
            Else
                If Trim(Nombre.Text) = "" Then
                    MsgBox("Digite el Nombre", vbOKOnly + vbInformation, "Datos Requeridos")
                    Nombre.Focus()
                Else
                    If Trim(Dir.Text) = "" Then
                        MsgBox("Digite la Direccion", vbOKOnly + vbInformation, "Datos Requeridos")
                        Dir.Focus()
                    Else
                        If Trim(Tele.Text) = "" Then
                            MsgBox("Digite el Telefono del Proveedor ", vbOKOnly + vbInformation, "Datos Requeridos")
                            Tele.Focus()
                        Else
                            'Validación de Datos Duplicados 
                            Dim conteo As Integer
                            conteo = Me.ProveedoresTableAdapter.Duplicado(Nit.Text)
                            If conteo > 0 Then
                                MsgBox("Ya existe un NIT igual", vbInformation + vbOKOnly, "Duplicidad")
                                Nit.Focus()
                            Else
                                ' Mensaje Para Guardar 
                                If MsgBox("¿Desea Guardar los Datos del Proveedor?", vbQuestion + vbYesNo, "Guardando Datos...") = vbYes Then
                                    'Guardar Datos 
                                    Me.ProveedoresTableAdapter.Registrar(Nit.Text, Nombre.Text, Dir.Text, Tele.Text)
                                    MsgBox("Datos Almacenados Correctamente", vbInformation + vbOKOnly, "Guardado!")
                                    'Limpiar Controles 
                                    Call Button2_Click(" ", e)
                                Else
                                    Call Button2_Click(" ", e)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DataSet.Proveedores)

    End Sub
End Class