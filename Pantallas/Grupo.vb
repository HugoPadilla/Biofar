Public Class Grupo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Validacion de controles vacios 
            If Trim(NOMBRE.Text) = " " Then
                MsgBox("Digite el Nombre del Grupo", vbInformation + vbOKOnly, "Datos Pendientes")
                NOMBRE.Focus()
            Else
                'validacion de Datos Duplicados 
                Dim Conteo As Integer
                Conteo = Me.GrupoTableAdapter.Duplicado(NOMBRE.Text)
                If Conteo > 0 Then
                    MsgBox("Ya Existe un Grupo con el Nombre digitado ", vbInformation + vbOKOnly, "Duplicidad")
                    NOMBRE.Focus()
                Else
                    'Mensaje para Guardar 
                    If MsgBox("Desea Guardar los Datos(Grupo)?", vbQuestion + vbYesNo, "Guardando...") = vbYes Then
                        'Guardar Datos 
                        Me.GrupoTableAdapter.Guarda(NOMBRE.Text)
                        MsgBox("Datos Almacenados Correctamente ", vbInformation + vbOKOnly, "Guardado!")
                        'Limpiar Controles 
                        Call Button2_Click("", e)
                    Else
                        Call Button2_Click("", e)

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Grupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.Grupo' Puede moverla o quitarla según sea necesario.
        Me.GrupoTableAdapter.Fill(Me.DataSet.Grupo)

    End Sub
End Class
