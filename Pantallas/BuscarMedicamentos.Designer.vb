<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarMedicamentos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.R4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Datos1 = New System.Windows.Forms.TextBox()
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
        Me.MedicamentosTableAdapter = New PBiofar.DataSetTableAdapters.MedicamentosTableAdapter()
        Me.R3 = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MedicamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechaExpiracionDataGridViewTextBoxColumn, Me.LoteDataGridViewTextBoxColumn, Me.ValorCostoDataGridViewTextBoxColumn, Me.ValorIVADataGridViewTextBoxColumn, Me.ValorTotalCostoDataGridViewTextBoxColumn, Me.ValorVentaDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.IDGrupoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedicamentosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 139)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(17, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 195)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Registrados"
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Location = New System.Drawing.Point(48, 32)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(80, 17)
        Me.R1.TabIndex = 2
        Me.R1.TabStop = True
        Me.R1.Text = "Referencia "
        Me.R1.UseVisualStyleBackColor = True
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.ForeColor = System.Drawing.Color.Black
        Me.R2.Location = New System.Drawing.Point(254, 32)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(65, 17)
        Me.R2.TabIndex = 3
        Me.R2.TabStop = True
        Me.R2.Text = "Nombre "
        Me.R2.UseVisualStyleBackColor = True
        '
        'R4
        '
        Me.R4.AutoSize = True
        Me.R4.ForeColor = System.Drawing.Color.Black
        Me.R4.Location = New System.Drawing.Point(624, 32)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(68, 17)
        Me.R4.TabIndex = 6
        Me.R4.TabStop = True
        Me.R4.Text = "IDGrupo "
        Me.R4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.R3)
        Me.GroupBox2.Controls.Add(Me.R4)
        Me.GroupBox2.Controls.Add(Me.R2)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(17, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 65)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Por "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Datos1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(17, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(767, 87)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos a Buscar "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(624, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cargar "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(472, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Buscar "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Datos1
        '
        Me.Datos1.Location = New System.Drawing.Point(15, 39)
        Me.Datos1.Name = "Datos1"
        Me.Datos1.Size = New System.Drawing.Size(383, 20)
        Me.Datos1.TabIndex = 0
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
        'MedicamentosTableAdapter
        '
        Me.MedicamentosTableAdapter.ClearBeforeFill = True
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.ForeColor = System.Drawing.Color.Black
        Me.R3.Location = New System.Drawing.Point(421, 32)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(110, 17)
        Me.R3.TabIndex = 7
        Me.R3.TabStop = True
        Me.R3.Text = "Fecha Expiracion "
        Me.R3.UseVisualStyleBackColor = True
        '
        'BuscarMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BuscarMedicamentos"
        Me.Text = "Buscar Medicamentos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.MedicamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents R1 As RadioButton
    Friend WithEvents R2 As RadioButton
    Friend WithEvents R4 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Datos1 As TextBox
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
    Friend WithEvents R3 As RadioButton
End Class
