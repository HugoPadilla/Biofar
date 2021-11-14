Public Class Medicamentos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try 'Validacion de Controles 
            If Trim(Referencia.Text) = "" Then
                MsgBox("Digite la Referencia", vbOKOnly + vbInformation, "Datos Requeridos")
                Referencia.Focus()
            Else
                If Trim(Nombre.Text) = "" Then
                    MsgBox("Digite el Nombre", vbOKOnly + vbInformation, "Datos Requeridos")
                    Nombre.Focus()
                Else
                    If Trim(Fecha.Text) = "" Then
                        MsgBox("Digite la Fecha de Expiracion", vbOKOnly + vbInformation, "Datos Requeridos")
                        Fecha.Focus()
                    Else
                        If Trim(Lote.Text) = "" Then
                            MsgBox("Digite el Lote de la mercancia ", vbOKOnly + vbInformation, "Datos Requeridos")
                            lote.Focus()
                        Else
                            If Trim(ValorC.Text) = "" Then
                                MsgBox("Digite el Valor Costo de la Mercancia", vbOKOnly + vbInformation, "Datos Requeridos")
                                ValorC.Focus()
                            Else
                                If Trim(ValorI.Text) = "" Then
                                    MsgBox("Digite el Valor del IVA", vbOKOnly + vbInformation, "Datos Requeridos")
                                    ValorI.Focus()
                                Else
                                    If Trim(ValorCtotal.Text) = " " Then
                                        MsgBox("Digite el Valor Costo Total", vbOKOnly + vbInformation, "Datos Requeridos")
                                        ValorCtotal.Focus()
                                    Else
                                        If Trim(Valorventa.Text) = " " Then
                                            MsgBox("Digite el Valor Venta ", vbOKOnly + vbInformation, "Datos Requeridos")
                                            Valorventa.Focus()
                                        Else
                                            If Trim(Existencia.Text) = " " Then
                                                MsgBox("Digite la Existencia del Producto", vbOKOnly + vbInformation, "Datos Requeridos")
                                                Existencia.Focus()
                                            Else
                                                If Trim(IDGrupo.Text) = " " Then
                                                    MsgBox("Digite el ID correspondiente al Grupo ", vbOKOnly + vbInformation, "Datos Requeridos")
                                                    IDGrupo.Focus()
                                                Else
                                                    If Trim(Lab.Text) = " " Then
                                                        MsgBox("Digite el Nombre del Laboratorio ", vbOKOnly + vbInformation, "Datos Requeridos")
                                                        Lab.Focus()

                                                        'Validación de Datos Duplicados 
                                                        Dim conteo As Integer
                                                        conteo = Me.MedicamentosTableAdapter.Duplicado(Referencia.Text)
                                                        If conteo > 0 Then
                                                            MsgBox("Ya existe una Referencia igual a la que desea digitar", vbInformation + vbOKOnly, "Duplicidad")
                                                            Referencia.Focus()
                                                        Else
                                                            ' Mensaje Para Guardar 
                                                            If MsgBox("¿Desea Guardar los Datos del Medicamento?", vbQuestion + vbYesNo, "Guardando Datos...") = vbYes Then
                                                                'Guardar Datos 
                                                                Me.MedicamentosTableAdapter.Registrar(Referencia.Text, Nombre.Text, Fecha.Text, lote.Text, ValorC.Text, ValorI.Text, ValorCtotal.Text, Valorventa.Text, Existencia.Text, IDGrupo.Text)
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
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Medicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Medicamentos' Puede moverla o quitarla según sea necesario.
        'Me.MedicamentosTableAdapter.Fill(Me.DataSet.Medicamentos)'

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class