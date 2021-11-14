Public Class Clientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try 'Validacion de Controles 
            If Trim(NDocumento.Text) = "" Then
                MsgBox("Digite el Numero del Documento", vbOKOnly + vbInformation, "Datos Requeridos")
                NDocumento.Focus()
            Else
                If Trim(Nombre2.Text) = "" Then
                    MsgBox("Digite el Nombre", vbOKOnly + vbInformation, "Datos Requeridos")
                    Nombre2.Focus()
                Else
                    If Trim(Apellido1.Text) = "" Then
                        MsgBox("Digite el Apellido", vbOKOnly + vbInformation, "Datos Requeridos")
                        Apellido1.Focus()
                    Else
                        If Trim(Dir.Text) = "" Then
                            MsgBox("Digite la Direccion ", vbOKOnly + vbInformation, "Datos Requeridos")
                            Dir.Focus()
                        Else
                            If Trim(Tel.Text) = "" Then
                                MsgBox("Digite el Numero del telefono", vbOKOnly + vbInformation, "Datos Requeridos")
                                Tel.Focus()
                            Else
                                'Validación de Datos Duplicados 
                                Dim conteo As Integer
                                conteo = Me.ClientesTableAdapter.Duplicado(NDocumento.Text)
                                If conteo > 0 Then
                                    MsgBox("Ya existe un numero de Documento igual", vbInformation + vbOKOnly, "Duplicidad")
                                    NDocumento.Focus()
                                Else
                                    ' Mensaje Para Guardar 
                                    If MsgBox("¿Desea Guardar los Datos del Cliente?", vbQuestion + vbYesNo, "Guardando Datos...") = vbYes Then
                                        'Guardar Datos 
                                        Me.ClientesTableAdapter.Registro(NDocumento.Text, Nombre2.Text, Apellido1.Text, Dir.Text, Tel.Text)
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
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.DataSet.Clientes)'

    End Sub
End Class