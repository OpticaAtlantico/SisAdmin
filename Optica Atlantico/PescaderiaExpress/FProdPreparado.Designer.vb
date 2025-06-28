<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProdPreparado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProdPreparado))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BArtEjemplo = New System.Windows.Forms.PictureBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Agregar = New System.Windows.Forms.Label()
        Me.BQuitar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.CBActivo = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.CostoTotal = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Primero = New System.Windows.Forms.ToolStripButton()
        Me.Anterior = New System.Windows.Forms.ToolStripButton()
        Me.Siguiente = New System.Windows.Forms.ToolStripButton()
        Me.Ultimo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.Buscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Editar = New System.Windows.Forms.ToolStripButton()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingrediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BArtEjemplo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BArtEjemplo
        '
        Me.BArtEjemplo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BArtEjemplo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BArtEjemplo.Location = New System.Drawing.Point(475, 68)
        Me.BArtEjemplo.Margin = New System.Windows.Forms.Padding(0)
        Me.BArtEjemplo.Name = "BArtEjemplo"
        Me.BArtEjemplo.Size = New System.Drawing.Size(130, 114)
        Me.BArtEjemplo.TabIndex = 157
        Me.BArtEjemplo.TabStop = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(608, 166)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(35, 13)
        Me.Label39.TabIndex = 162
        Me.Label39.Text = "Quitar"
        '
        'Agregar
        '
        Me.Agregar.AutoSize = True
        Me.Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar.ForeColor = System.Drawing.Color.Navy
        Me.Agregar.Location = New System.Drawing.Point(608, 113)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(44, 13)
        Me.Agregar.TabIndex = 161
        Me.Agregar.Text = "Agregar"
        '
        'BQuitar
        '
        Me.BQuitar.Image = CType(resources.GetObject("BQuitar.Image"), System.Drawing.Image)
        Me.BQuitar.Location = New System.Drawing.Point(608, 129)
        Me.BQuitar.Name = "BQuitar"
        Me.BQuitar.Size = New System.Drawing.Size(39, 34)
        Me.BQuitar.TabIndex = 159
        Me.BQuitar.UseVisualStyleBackColor = True
        '
        'BAgregar
        '
        Me.BAgregar.Image = CType(resources.GetObject("BAgregar.Image"), System.Drawing.Image)
        Me.BAgregar.Location = New System.Drawing.Point(608, 76)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(39, 34)
        Me.BAgregar.TabIndex = 158
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'CBActivo
        '
        Me.CBActivo.AutoSize = True
        Me.CBActivo.Checked = True
        Me.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBActivo.ForeColor = System.Drawing.Color.Navy
        Me.CBActivo.Location = New System.Drawing.Point(12, 69)
        Me.CBActivo.Name = "CBActivo"
        Me.CBActivo.Size = New System.Drawing.Size(75, 24)
        Me.CBActivo.TabIndex = 152
        Me.CBActivo.Text = "Activo."
        Me.CBActivo.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(135, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(150, 24)
        Me.Label19.TabIndex = 155
        Me.Label19.Text = "Fecha Creación:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(96, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 24)
        Me.Label16.TabIndex = 154
        Me.Label16.Text = "Nombre:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(6, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 24)
        Me.Label15.TabIndex = 153
        Me.Label15.Text = "Código:"
        '
        'TNombre
        '
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(96, 132)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(341, 26)
        Me.TNombre.TabIndex = 150
        '
        'Fecha
        '
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha.Location = New System.Drawing.Point(291, 69)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(146, 26)
        Me.Fecha.TabIndex = 151
        Me.Fecha.Value = New Date(2014, 9, 27, 0, 0, 0, 0)
        '
        'TCodigo
        '
        Me.TCodigo.Enabled = False
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(6, 132)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(84, 26)
        Me.TCodigo.TabIndex = 149
        Me.TCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Ingrediente, Me.CostoCompra, Me.Cantidad, Me.Unidad, Me.Costo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(6, 261)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(702, 188)
        Me.DataGridView1.TabIndex = 163
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TextBox1.Location = New System.Drawing.Point(6, 507)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(702, 198)
        Me.TextBox1.TabIndex = 164
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Preparación:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7, Me.ToolStripSeparator4, Me.ToolStripButton10})
        Me.ToolStrip2.Location = New System.Drawing.Point(6, 196)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip2.Size = New System.Drawing.Size(122, 55)
        Me.ToolStrip2.TabIndex = 166
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton7.Text = "Buscar "
        Me.ToolStripButton7.ToolTipText = "Buscar Ingrediente."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 55)
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton10.Text = "Eliminar"
        Me.ToolStripButton10.ToolTipText = "Eliminar Ingrdiente."
        '
        'CostoTotal
        '
        Me.CostoTotal.AutoSize = True
        Me.CostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostoTotal.ForeColor = System.Drawing.Color.Navy
        Me.CostoTotal.Location = New System.Drawing.Point(483, 457)
        Me.CostoTotal.Name = "CostoTotal"
        Me.CostoTotal.Size = New System.Drawing.Size(104, 24)
        Me.CostoTotal.TabIndex = 168
        Me.CostoTotal.Text = "CostoTotal:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(593, 455)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(115, 26)
        Me.TextBox2.TabIndex = 167
        '
        'Primero
        '
        Me.Primero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Primero.Image = CType(resources.GetObject("Primero.Image"), System.Drawing.Image)
        Me.Primero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Primero.Name = "Primero"
        Me.Primero.Size = New System.Drawing.Size(52, 52)
        Me.Primero.Text = "Primero."
        '
        'Anterior
        '
        Me.Anterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Anterior.Image = CType(resources.GetObject("Anterior.Image"), System.Drawing.Image)
        Me.Anterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Anterior.Name = "Anterior"
        Me.Anterior.Size = New System.Drawing.Size(52, 52)
        Me.Anterior.Text = "Anterior"
        Me.Anterior.ToolTipText = "Anterior."
        '
        'Siguiente
        '
        Me.Siguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Siguiente.Image = CType(resources.GetObject("Siguiente.Image"), System.Drawing.Image)
        Me.Siguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(52, 52)
        Me.Siguiente.Text = "Siguiente"
        Me.Siguiente.ToolTipText = "Siguiente."
        '
        'Ultimo
        '
        Me.Ultimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ultimo.Image = CType(resources.GetObject("Ultimo.Image"), System.Drawing.Image)
        Me.Ultimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ultimo.Name = "Ultimo"
        Me.Ultimo.Size = New System.Drawing.Size(52, 52)
        Me.Ultimo.Text = "Ultimo"
        Me.Ultimo.ToolTipText = "Ultimo."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'Imprimir
        '
        Me.Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(52, 52)
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.ToolTipText = "Imprimir."
        '
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(52, 52)
        Me.Nuevo.Text = "Nuevo"
        '
        'Buscar
        '
        Me.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Buscar.Image = CType(resources.GetObject("Buscar.Image"), System.Drawing.Image)
        Me.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(52, 52)
        Me.Buscar.Text = "Buscar"
        Me.Buscar.ToolTipText = "Buscar."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 55)
        '
        'Editar
        '
        Me.Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(52, 52)
        Me.Editar.Text = "Editar"
        Me.Editar.ToolTipText = "Editar."
        '
        'Guardar
        '
        Me.Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(52, 52)
        Me.Guardar.Text = "Guardar"
        Me.Guardar.ToolTipText = "Guardar."
        '
        'Eliminar
        '
        Me.Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(52, 52)
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.ToolTipText = "Eliminar."
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(52, 52)
        Me.Salir.Text = "Salir"
        Me.Salir.ToolTipText = "Salir."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Primero, Me.Anterior, Me.Siguiente, Me.Ultimo, Me.ToolStripSeparator1, Me.Imprimir, Me.Nuevo, Me.Buscar, Me.ToolStripSeparator2, Me.Editar, Me.Guardar, Me.Eliminar, Me.Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(712, 55)
        Me.ToolStrip1.TabIndex = 125
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 50
        '
        'Ingrediente
        '
        Me.Ingrediente.HeaderText = "Ingrediente"
        Me.Ingrediente.Name = "Ingrediente"
        Me.Ingrediente.ReadOnly = True
        Me.Ingrediente.Width = 300
        '
        'CostoCompra
        '
        Me.CostoCompra.HeaderText = "Costocompra"
        Me.CostoCompra.Name = "CostoCompra"
        Me.CostoCompra.ReadOnly = True
        Me.CostoCompra.Visible = False
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        '
        'FProdPreparado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 726)
        Me.ControlBox = False
        Me.Controls.Add(Me.CostoTotal)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BArtEjemplo)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.BQuitar)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.CBActivo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.TCodigo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FProdPreparado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Producto Preparado."
        CType(Me.BArtEjemplo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BArtEjemplo As System.Windows.Forms.PictureBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Agregar As System.Windows.Forms.Label
    Friend WithEvents BQuitar As System.Windows.Forms.Button
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents CBActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CostoTotal As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Primero As System.Windows.Forms.ToolStripButton
    Friend WithEvents Anterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents Siguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents Ultimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ingrediente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
