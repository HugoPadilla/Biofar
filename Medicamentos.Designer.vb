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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MedicamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New PBiofar.DataSet()
        Me.MedicamentosTableAdapter = New PBiofar.DataSetTableAdapters.MedicamentosTableAdapter()
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonNuevoMedicamento = New System.Windows.Forms.Button()
        CType(Me.MedicamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechaExpiracionDataGridViewTextBoxColumn, Me.LoteDataGridViewTextBoxColumn, Me.ValorCostoDataGridViewTextBoxColumn, Me.ValorIVADataGridViewTextBoxColumn, Me.ValorTotalCostoDataGridViewTextBoxColumn, Me.ValorVentaDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.IDGrupoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedicamentosBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Aqua
        Me.DataGridView1.Location = New System.Drawing.Point(14, 125)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(746, 430)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 64.09598!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.FillWeight = 71.65859!
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.Width = 108
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.FillWeight = 80.91961!
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 93
        '
        'FechaExpiracionDataGridViewTextBoxColumn
        '
        Me.FechaExpiracionDataGridViewTextBoxColumn.DataPropertyName = "FechaExpiracion"
        Me.FechaExpiracionDataGridViewTextBoxColumn.FillWeight = 87.26897!
        Me.FechaExpiracionDataGridViewTextBoxColumn.HeaderText = "FechaExpiracion"
        Me.FechaExpiracionDataGridViewTextBoxColumn.Name = "FechaExpiracionDataGridViewTextBoxColumn"
        Me.FechaExpiracionDataGridViewTextBoxColumn.Width = 146
        '
        'LoteDataGridViewTextBoxColumn
        '
        Me.LoteDataGridViewTextBoxColumn.DataPropertyName = "Lote"
        Me.LoteDataGridViewTextBoxColumn.FillWeight = 95.85338!
        Me.LoteDataGridViewTextBoxColumn.HeaderText = "Lote"
        Me.LoteDataGridViewTextBoxColumn.Name = "LoteDataGridViewTextBoxColumn"
        Me.LoteDataGridViewTextBoxColumn.Width = 65
        '
        'ValorCostoDataGridViewTextBoxColumn
        '
        Me.ValorCostoDataGridViewTextBoxColumn.DataPropertyName = "ValorCosto"
        Me.ValorCostoDataGridViewTextBoxColumn.FillWeight = 101.1257!
        Me.ValorCostoDataGridViewTextBoxColumn.HeaderText = "ValorCosto"
        Me.ValorCostoDataGridViewTextBoxColumn.Name = "ValorCostoDataGridViewTextBoxColumn"
        Me.ValorCostoDataGridViewTextBoxColumn.Width = 111
        '
        'ValorIVADataGridViewTextBoxColumn
        '
        Me.ValorIVADataGridViewTextBoxColumn.DataPropertyName = "ValorIVA"
        Me.ValorIVADataGridViewTextBoxColumn.FillWeight = 109.1095!
        Me.ValorIVADataGridViewTextBoxColumn.HeaderText = "ValorIVA"
        Me.ValorIVADataGridViewTextBoxColumn.Name = "ValorIVADataGridViewTextBoxColumn"
        Me.ValorIVADataGridViewTextBoxColumn.Width = 94
        '
        'ValorTotalCostoDataGridViewTextBoxColumn
        '
        Me.ValorTotalCostoDataGridViewTextBoxColumn.DataPropertyName = "ValorTotalCosto"
        Me.ValorTotalCostoDataGridViewTextBoxColumn.FillWeight = 113.4258!
        Me.ValorTotalCostoDataGridViewTextBoxColumn.HeaderText = "ValorTotalCosto"
        Me.ValorTotalCostoDataGridViewTextBoxColumn.Name = "ValorTotalCostoDataGridViewTextBoxColumn"
        Me.ValorTotalCostoDataGridViewTextBoxColumn.Width = 143
        '
        'ValorVentaDataGridViewTextBoxColumn
        '
        Me.ValorVentaDataGridViewTextBoxColumn.DataPropertyName = "ValorVenta"
        Me.ValorVentaDataGridViewTextBoxColumn.FillWeight = 120.8765!
        Me.ValorVentaDataGridViewTextBoxColumn.HeaderText = "ValorVenta"
        Me.ValorVentaDataGridViewTextBoxColumn.Name = "ValorVentaDataGridViewTextBoxColumn"
        Me.ValorVentaDataGridViewTextBoxColumn.Width = 110
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.FillWeight = 124.3443!
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.Width = 102
        '
        'IDGrupoDataGridViewTextBoxColumn
        '
        Me.IDGrupoDataGridViewTextBoxColumn.DataPropertyName = "IDGrupo"
        Me.IDGrupoDataGridViewTextBoxColumn.FillWeight = 131.3217!
        Me.IDGrupoDataGridViewTextBoxColumn.HeaderText = "IDGrupo"
        Me.IDGrupoDataGridViewTextBoxColumn.Name = "IDGrupoDataGridViewTextBoxColumn"
        Me.IDGrupoDataGridViewTextBoxColumn.Width = 94
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(774, 570)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonNuevoMedicamento)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 13)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(706, 104)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'ButtonNuevoMedicamento
        '
        Me.ButtonNuevoMedicamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ButtonNuevoMedicamento.FlatAppearance.BorderSize = 0
        Me.ButtonNuevoMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNuevoMedicamento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNuevoMedicamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ButtonNuevoMedicamento.Location = New System.Drawing.Point(24, 14)
        Me.ButtonNuevoMedicamento.Margin = New System.Windows.Forms.Padding(24, 14, 0, 5)
        Me.ButtonNuevoMedicamento.Name = "ButtonNuevoMedicamento"
        Me.ButtonNuevoMedicamento.Size = New System.Drawing.Size(205, 36)
        Me.ButtonNuevoMedicamento.TabIndex = 13
        Me.ButtonNuevoMedicamento.Text = "Agregar medicamento"
        Me.ButtonNuevoMedicamento.UseVisualStyleBackColor = False
        '
        'Medicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 570)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Medicamentos"
        Me.Text = "Medicamentos"
        CType(Me.MedicamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet As DataSet
    Friend WithEvents MedicamentosBindingSource As BindingSource
    Friend WithEvents MedicamentosTableAdapter As DataSetTableAdapters.MedicamentosTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ButtonNuevoMedicamento As Button
End Class
