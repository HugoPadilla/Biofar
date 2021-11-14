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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.ButtonProveedor = New System.Windows.Forms.Button()
        Me.ButtonInventario = New System.Windows.Forms.Button()
        Me.ButtonClientes = New System.Windows.Forms.Button()
        Me.ButtonVentas = New System.Windows.Forms.Button()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelMenuLateral.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.PanelMenuLateral.Controls.Add(Me.ButtonProveedor)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonInventario)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonClientes)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonVentas)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonHome)
        Me.PanelMenuLateral.Controls.Add(Me.PictureBoxLogo)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(218, 609)
        Me.PanelMenuLateral.TabIndex = 15
        '
        'ButtonProveedor
        '
        Me.ButtonProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ButtonProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonProveedor.FlatAppearance.BorderSize = 0
        Me.ButtonProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProveedor.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ButtonProveedor.Image = Global.PBiofar.My.Resources.Resources.ic_profile
        Me.ButtonProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProveedor.Location = New System.Drawing.Point(0, 456)
        Me.ButtonProveedor.Name = "ButtonProveedor"
        Me.ButtonProveedor.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ButtonProveedor.Size = New System.Drawing.Size(218, 68)
        Me.ButtonProveedor.TabIndex = 5
        Me.ButtonProveedor.Text = "Proveedor"
        Me.ButtonProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonProveedor.UseVisualStyleBackColor = False
        '
        'ButtonInventario
        '
        Me.ButtonInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ButtonInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonInventario.FlatAppearance.BorderSize = 0
        Me.ButtonInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInventario.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonInventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ButtonInventario.Image = Global.PBiofar.My.Resources.Resources.ic_folder
        Me.ButtonInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInventario.Location = New System.Drawing.Point(0, 388)
        Me.ButtonInventario.Name = "ButtonInventario"
        Me.ButtonInventario.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ButtonInventario.Size = New System.Drawing.Size(218, 68)
        Me.ButtonInventario.TabIndex = 4
        Me.ButtonInventario.Text = "Inventario"
        Me.ButtonInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonInventario.UseVisualStyleBackColor = False
        '
        'ButtonClientes
        '
        Me.ButtonClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ButtonClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonClientes.FlatAppearance.BorderSize = 0
        Me.ButtonClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClientes.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ButtonClientes.Image = Global.PBiofar.My.Resources.Resources.ic_users
        Me.ButtonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClientes.Location = New System.Drawing.Point(0, 320)
        Me.ButtonClientes.Name = "ButtonClientes"
        Me.ButtonClientes.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ButtonClientes.Size = New System.Drawing.Size(218, 68)
        Me.ButtonClientes.TabIndex = 3
        Me.ButtonClientes.Text = "Clientes"
        Me.ButtonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonClientes.UseVisualStyleBackColor = False
        '
        'ButtonVentas
        '
        Me.ButtonVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ButtonVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonVentas.FlatAppearance.BorderSize = 0
        Me.ButtonVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVentas.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ButtonVentas.Image = Global.PBiofar.My.Resources.Resources.ic_buy
        Me.ButtonVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonVentas.Location = New System.Drawing.Point(0, 252)
        Me.ButtonVentas.Name = "ButtonVentas"
        Me.ButtonVentas.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ButtonVentas.Size = New System.Drawing.Size(218, 68)
        Me.ButtonVentas.TabIndex = 2
        Me.ButtonVentas.Text = "Ventas"
        Me.ButtonVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonVentas.UseVisualStyleBackColor = False
        '
        'ButtonHome
        '
        Me.ButtonHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ButtonHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonHome.FlatAppearance.BorderSize = 0
        Me.ButtonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHome.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ButtonHome.Image = Global.PBiofar.My.Resources.Resources.ic_home
        Me.ButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonHome.Location = New System.Drawing.Point(0, 184)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ButtonHome.Size = New System.Drawing.Size(218, 68)
        Me.ButtonHome.TabIndex = 1
        Me.ButtonHome.Text = "Inicio"
        Me.ButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonHome.UseVisualStyleBackColor = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.InitialImage = Nothing
        Me.PictureBoxLogo.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 30)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(218, 184)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(218, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(812, 609)
        Me.PanelContenedor.TabIndex = 16
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1030, 609)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.MinimumSize = New System.Drawing.Size(1024, 648)
        Me.Name = "App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ventas"
        Me.PanelMenuLateral.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents ButtonProveedor As Button
    Friend WithEvents ButtonInventario As Button
    Friend WithEvents ButtonClientes As Button
    Friend WithEvents ButtonVentas As Button
    Friend WithEvents ButtonHome As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents PanelContenedor As Panel
End Class
