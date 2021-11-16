<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelContenedorPrincipal = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelContenedorPrincipal
        '
        Me.PanelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedorPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedorPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelContenedorPrincipal.Name = "PanelContenedorPrincipal"
        Me.PanelContenedorPrincipal.Size = New System.Drawing.Size(1000, 600)
        Me.PanelContenedorPrincipal.TabIndex = 18
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.PanelContenedorPrincipal)
        Me.MinimumSize = New System.Drawing.Size(1016, 639)
        Me.Name = "App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biofar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContenedorPrincipal As Panel
End Class
