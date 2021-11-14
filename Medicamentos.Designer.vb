<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicamentos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaExpiracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorCostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTotalCostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New PBiofar.DataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Referencia = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.ValorC = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.TextBox()
        Me.Lot = New System.Windows.Forms.TextBox()
        Me.ValorV = New System.Windows.Forms.TextBox()
        Me.ValorI = New System.Windows.Forms.TextBox()
        Me.ValorCtotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lote = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Valorventa = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Existencia = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lab = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.IDGrupo = New System.Windows.Forms.TextBox()
        Me.MedicamentosTableAdapter = New PBiofar.DataSetTableAdapters.MedicamentosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechaExpiracionDataGridViewTextBoxColumn, Me.LoteDataGridViewTextBoxColumn, Me.ValorCostoDataGridViewTextBoxColumn, Me.ValorIVADataGridViewTextBoxColumn, Me.ValorTotalCostoDataGridViewTextBoxColumn, Me.ValorVentaDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.IDGrupoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedicamentosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(705, 119)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'FechaExpiracionDataGridViewTextBoxColumn
        '
        Me.FechaExpiracionDataGridViewTextBoxColumn.DataPropertyName = "FechaExpiracion"
        Me.FechaExpiracionDataGridViewTextBoxColumn.HeaderText = "FechaExpiracion"
        Me.FechaExpiracionDataGridViewTextBoxColumn.Name = "FechaExpiracionDataGridViewTextBoxColumn"
        '
        'LoteDataGridViewTextBoxColumn
        '
        Me.LoteDataGridViewTextBoxColumn.DataPropertyName = "Lote"
        Me.LoteDataGridViewTextBoxColumn.HeaderText = "Lote"
        Me.LoteDataGridViewTextBoxColumn.Name = "LoteDataGridViewTextBoxColumn"
        '
        'ValorCostoDataGridViewTextBoxColumn
        '
        Me.ValorCostoDataGridViewTextBoxColumn.DataPropertyName = "ValorCosto"
        Me.ValorCostoDataGridViewTextBoxColumn.HeaderText = "ValorCosto"
        Me.ValorCostoDataGridViewTextBoxColumn.Name = "ValorCostoDataGridViewTextBoxColumn"
        '
        'ValorIVADataGridViewTextBoxColumn
        '
        Me.ValorIVADataGridViewTextBoxColumn.DataPropertyName = "ValorIVA"
        Me.ValorIVADataGridViewTextBoxColumn.HeaderText = "ValorIVA"
        Me.ValorIVADataGridViewTextBoxColumn.Name = "ValorIVADataGridViewTextBoxColumn"
        '
        'ValorTotalCostoDataGridViewTextBoxColumn
        '
        Me.ValorTotalCostoDataGridViewTextBoxColumn.DataPropertyName = "ValorTotalCosto"
        Me.ValorTotalCostoDataGridViewTextBoxColumn.HeaderText = "ValorTotalCosto"
        Me.ValorTotalCostoDataGridViewTextBoxColumn.Name = "ValorTotalCostoDataGridViewTextBoxColumn"
        '
        'ValorVentaDataGridViewTextBoxColumn
        '
        Me.ValorVentaDataGridViewTextBoxColumn.DataPropertyName = "ValorVenta"
        Me.ValorVentaDataGridViewTextBoxColumn.HeaderText = "ValorVenta"
        Me.ValorVentaDataGridViewTextBoxColumn.Name = "ValorVentaDataGridViewTextBoxColumn"
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        '
        'IDGrupoDataGridViewTextBoxColumn
        '
        Me.IDGrupoDataGridViewTextBoxColumn.DataPropertyName = "IDGrupo"
        Me.IDGrupoDataGridViewTextBoxColumn.HeaderText = "IDGrupo"
        Me.IDGrupoDataGridViewTextBoxColumn.Name = "IDGrupoDataGridViewTextBoxColumn"
        '
        'MedicamentosBindingSource
        '
        Me.MedicamentosBindingSource.DataMember = "Medicamentos"
        Me.MedicamentosBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(34, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Guardar "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button2.Location = New System.Drawing.Point(241, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Limpiar "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button3.Location = New System.Drawing.Point(598, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Cerrar "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(26, 278)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 157)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Registrados"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(757, 57)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Referencia
        '
        Me.Referencia.Location = New System.Drawing.Point(16, 36)
        Me.Referencia.Name = "Referencia"
        Me.Referencia.Size = New System.Drawing.Size(110, 20)
        Me.Referencia.TabIndex = 6
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(153, 36)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(164, 20)
        Me.Nombre.TabIndex = 7
        '
        'ValorC
        '
        Me.ValorC.Location = New System.Drawing.Point(640, 36)
        Me.ValorC.Name = "ValorC"
        Me.ValorC.Size = New System.Drawing.Size(110, 20)
        Me.ValorC.TabIndex = 8
        '
        'Fecha
        '
        Me.Fecha.Location = New System.Drawing.Point(339, 36)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(129, 20)
        Me.Fecha.TabIndex = 9
        '
        'Lot
        '
        Me.Lot.Location = New System.Drawing.Point(503, 36)
        Me.Lot.Name = "Lot"
        Me.Lot.Size = New System.Drawing.Size(106, 20)
        Me.Lot.TabIndex = 10
        '
        'ValorV
        '
        Me.ValorV.Location = New System.Drawing.Point(265, 123)
        Me.ValorV.Name = "ValorV"
        Me.ValorV.Size = New System.Drawing.Size(119, 20)
        Me.ValorV.TabIndex = 11
        '
        'ValorI
        '
        Me.ValorI.Location = New System.Drawing.Point(16, 123)
        Me.ValorI.Name = "ValorI"
        Me.ValorI.Size = New System.Drawing.Size(91, 20)
        Me.ValorI.TabIndex = 12
        '
        'ValorCtotal
        '
        Me.ValorCtotal.Location = New System.Drawing.Point(131, 123)
        Me.ValorCtotal.Name = "ValorCtotal"
        Me.ValorCtotal.Size = New System.Drawing.Size(113, 20)
        Me.ValorCtotal.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Referencia "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nombre "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(356, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fecha Expiración "
        '
        'lote
        '
        Me.lote.AutoSize = True
        Me.lote.Location = New System.Drawing.Point(548, 20)
        Me.lote.Name = "lote"
        Me.lote.Size = New System.Drawing.Size(31, 13)
        Me.lote.TabIndex = 17
        Me.lote.Text = "Lote "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(661, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Valor Costo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Valor Costo Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Valor Iva"
        '
        'Valorventa
        '
        Me.Valorventa.AutoSize = True
        Me.Valorventa.Location = New System.Drawing.Point(298, 103)
        Me.Valorventa.Name = "Valorventa"
        Me.Valorventa.Size = New System.Drawing.Size(65, 13)
        Me.Valorventa.TabIndex = 21
        Me.Valorventa.Text = "Valor Venta "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(428, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Existencia "
        '
        'Existencia
        '
        Me.Existencia.Location = New System.Drawing.Point(407, 123)
        Me.Existencia.Name = "Existencia"
        Me.Existencia.Size = New System.Drawing.Size(110, 20)
        Me.Existencia.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lab)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.IDGrupo)
        Me.GroupBox3.Controls.Add(Me.Existencia)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Valorventa)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lote)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ValorCtotal)
        Me.GroupBox3.Controls.Add(Me.ValorI)
        Me.GroupBox3.Controls.Add(Me.ValorV)
        Me.GroupBox3.Controls.Add(Me.Lot)
        Me.GroupBox3.Controls.Add(Me.Fecha)
        Me.GroupBox3.Controls.Add(Me.ValorC)
        Me.GroupBox3.Controls.Add(Me.Nombre)
        Me.GroupBox3.Controls.Add(Me.Referencia)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(761, 174)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'Lab
        '
        Me.Lab.AutoSize = True
        Me.Lab.Location = New System.Drawing.Point(677, 107)
        Me.Lab.Name = "Lab"
        Me.Lab.Size = New System.Drawing.Size(63, 13)
        Me.Lab.TabIndex = 28
        Me.Lab.Text = "Laboratorio "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(653, 123)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(102, 20)
        Me.TextBox1.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(585, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(559, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "IDGrupo "
        '
        'IDGrupo
        '
        Me.IDGrupo.Location = New System.Drawing.Point(539, 123)
        Me.IDGrupo.Name = "IDGrupo"
        Me.IDGrupo.Size = New System.Drawing.Size(91, 20)
        Me.IDGrupo.TabIndex = 24
        '
        'MedicamentosTableAdapter
        '
        Me.MedicamentosTableAdapter.ClearBeforeFill = True
        '
        'Medicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Medicamentos"
        Me.Text = "Medicamentos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Referencia As TextBox
    Friend WithEvents Nombre As TextBox
    Friend WithEvents ValorC As TextBox
    Friend WithEvents Fecha As TextBox
    Friend WithEvents Lot As TextBox
    Friend WithEvents ValorV As TextBox
    Friend WithEvents ValorI As TextBox
    Friend WithEvents ValorCtotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lote As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Valorventa As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Existencia As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents IDGrupo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Lab As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataSet As DataSet
    Friend WithEvents MedicamentosBindingSource As BindingSource
    Friend WithEvents MedicamentosTableAdapter As DataSetTableAdapters.MedicamentosTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaExpiracionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorCostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorIVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorTotalCostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDGrupoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
