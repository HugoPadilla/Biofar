Public Class Gastos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try 'Validacion de Controles 
            If Trim(Fecha.Text) = "" Then
                MsgBox("Digite la Fecha", vbOKOnly + vbInformation, "Datos Requeridos")
                Fecha.Focus()
            Else
                If Trim(Val.Text) = "" Then
                    MsgBox("Digite el Valor del Gasto", vbOKOnly + vbInformation, "Datos Requeridos")
                    Val.Focus()
                Else
                    If Trim(Concep.Text) = "" Then
                        MsgBox("Digite la información acerca del Gasto", vbOKOnly + vbInformation, "Datos Requeridos")
                        Concep.Focus()
                    Else
                        ' Mensaje Para Guardar 
                        If MsgBox("¿Desea Guardar los Gastos Generados?", vbQuestion + vbYesNo, "Guardando Datos...") = vbYes Then
                            'Guardar Datos 
                            Me.GastoTableAdapter.Registro(Fecha.Text, Val.Text, Concep.Text)
                            MsgBox("Datos Almacenados Correctamente", vbInformation + vbOKOnly, "Guardado!")
                            'Limpiar Controles 
                            Call Button2_Click(" ", e)
                        Else
                            Call Button2_Click(" ", e)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Gastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Gasto' Puede moverla o quitarla según sea necesario.
        Me.GastoTableAdapter.Fill(Me.DataSet.Gasto)

    End Sub
End Class