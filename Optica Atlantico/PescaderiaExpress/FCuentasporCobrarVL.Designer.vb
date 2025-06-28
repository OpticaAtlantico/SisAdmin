<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCuentasporCobrarVL
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCuentasporCobrarVL))
        Me.DGCuentasXPagar = New System.Windows.Forms.DataGridView()
        Me.RBCliente = New System.Windows.Forms.RadioButton()
        Me.RBTodas = New System.Windows.Forms.RadioButton()
        Me.CPatrocinador = New System.Windows.Forms.ComboBox()
        Me.RBPatrocinador = New System.Windows.Forms.RadioButton()
        Me.CEmpleados = New System.Windows.Forms.ComboBox()
        Me.RBEmpleado = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Reporte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.BCuentas = New System.Windows.Forms.ToolStripButton()
        Me.BPagadas = New System.Windows.Forms.ToolStripButton()
        Me.BCtasAnuladas = New System.Windows.Forms.ToolStripButton()
        Me.BStatus = New System.Windows.Forms.ToolStripButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LTotalRestaD = New System.Windows.Forms.Label()
        Me.LTotalAbonadoD = New System.Windows.Forms.Label()
        Me.LTotalGeneralD = New System.Windows.Forms.Label()
        Me.LTotalResta = New System.Windows.Forms.Label()
        Me.LResta = New System.Windows.Forms.Label()
        Me.LTotalAbonado = New System.Windows.Forms.Label()
        Me.LAbonado = New System.Windows.Forms.Label()
        Me.LTotalGeneral = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CCliente = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BExpandir = New System.Windows.Forms.Button()
        Me.BSiguiente = New System.Windows.Forms.Button()
        Me.BAnterior = New System.Windows.Forms.Button()
        Me.Desde = New System.Windows.Forms.DateTimePicker()
        Me.Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CLocal = New System.Windows.Forms.ComboBox()
        Me.RBCaja = New System.Windows.Forms.RadioButton()
        Me.CCaja = New System.Windows.Forms.ComboBox()
        CType(Me.DGCuentasXPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGCuentasXPagar
        '
        Me.DGCuentasXPagar.AllowUserToAddRows = False
        Me.DGCuentasXPagar.AllowUserToDeleteRows = False
        Me.DGCuentasXPagar.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCuentasXPagar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGCuentasXPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCuentasXPagar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGCuentasXPagar.EnableHeadersVisualStyles = False
        Me.DGCuentasXPagar.Location = New System.Drawing.Point(0, 238)
        Me.DGCuentasXPagar.Name = "DGCuentasXPagar"
        Me.DGCuentasXPagar.RowHeadersVisible = False
        Me.DGCuentasXPagar.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGCuentasXPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGCuentasXPagar.Size = New System.Drawing.Size(1444, 469)
        Me.DGCuentasXPagar.TabIndex = 220
        '
        'RBCliente
        '
        Me.RBCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCliente.ForeColor = System.Drawing.Color.Navy
        Me.RBCliente.Location = New System.Drawing.Point(277, 72)
        Me.RBCliente.Name = "RBCliente"
        Me.RBCliente.Size = New System.Drawing.Size(120, 25)
        Me.RBCliente.TabIndex = 222
        Me.RBCliente.Text = "Cliente:"
        Me.RBCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RBCliente.UseVisualStyleBackColor = True
        '
        'RBTodas
        '
        Me.RBTodas.Checked = True
        Me.RBTodas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTodas.ForeColor = System.Drawing.Color.Navy
        Me.RBTodas.Location = New System.Drawing.Point(277, 12)
        Me.RBTodas.Name = "RBTodas"
        Me.RBTodas.Size = New System.Drawing.Size(120, 25)
        Me.RBTodas.TabIndex = 221
        Me.RBTodas.TabStop = True
        Me.RBTodas.Text = "Local:"
        Me.RBTodas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RBTodas.UseVisualStyleBackColor = True
        '
        'CPatrocinador
        '
        Me.CPatrocinador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CPatrocinador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CPatrocinador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CPatrocinador.Enabled = False
        Me.CPatrocinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPatrocinador.FormattingEnabled = True
        Me.CPatrocinador.ItemHeight = 16
        Me.CPatrocinador.Location = New System.Drawing.Point(401, 101)
        Me.CPatrocinador.Margin = New System.Windows.Forms.Padding(0)
        Me.CPatrocinador.Name = "CPatrocinador"
        Me.CPatrocinador.Size = New System.Drawing.Size(220, 24)
        Me.CPatrocinador.TabIndex = 227
        '
        'RBPatrocinador
        '
        Me.RBPatrocinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBPatrocinador.ForeColor = System.Drawing.Color.Navy
        Me.RBPatrocinador.Location = New System.Drawing.Point(277, 101)
        Me.RBPatrocinador.Name = "RBPatrocinador"
        Me.RBPatrocinador.Size = New System.Drawing.Size(120, 25)
        Me.RBPatrocinador.TabIndex = 226
        Me.RBPatrocinador.Text = "Patrocinador:"
        Me.RBPatrocinador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RBPatrocinador.UseVisualStyleBackColor = True
        '
        'CEmpleados
        '
        Me.CEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CEmpleados.Enabled = False
        Me.CEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEmpleados.FormattingEnabled = True
        Me.CEmpleados.ItemHeight = 16
        Me.CEmpleados.Location = New System.Drawing.Point(401, 42)
        Me.CEmpleados.Margin = New System.Windows.Forms.Padding(0)
        Me.CEmpleados.Name = "CEmpleados"
        Me.CEmpleados.Size = New System.Drawing.Size(220, 24)
        Me.CEmpleados.TabIndex = 338
        '
        'RBEmpleado
        '
        Me.RBEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBEmpleado.ForeColor = System.Drawing.Color.Navy
        Me.RBEmpleado.Location = New System.Drawing.Point(277, 42)
        Me.RBEmpleado.Name = "RBEmpleado"
        Me.RBEmpleado.Size = New System.Drawing.Size(120, 25)
        Me.RBEmpleado.TabIndex = 339
        Me.RBEmpleado.Text = "Empleado:"
        Me.RBEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RBEmpleado.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Reporte, Me.ToolStripSeparator1, Me.Salir, Me.BCuentas, Me.BPagadas, Me.BCtasAnuladas, Me.BStatus})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1444, 70)
        Me.ToolStrip1.TabIndex = 340
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Reporte
        '
        Me.Reporte.ForeColor = System.Drawing.Color.Navy
        Me.Reporte.Image = CType(resources.GetObject("Reporte.Image"), System.Drawing.Image)
        Me.Reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Reporte.Name = "Reporte"
        Me.Reporte.Size = New System.Drawing.Size(57, 67)
        Me.Reporte.Text = "Imprimir"
        Me.Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Reporte.ToolTipText = "Imprimir."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 70)
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.ForeColor = System.Drawing.Color.Navy
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(52, 67)
        Me.Salir.Text = "Salir"
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Salir.ToolTipText = "Salir."
        '
        'BCuentas
        '
        Me.BCuentas.BackColor = System.Drawing.Color.LightGray
        Me.BCuentas.ForeColor = System.Drawing.Color.Navy
        Me.BCuentas.Image = CType(resources.GetObject("BCuentas.Image"), System.Drawing.Image)
        Me.BCuentas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BCuentas.Name = "BCuentas"
        Me.BCuentas.Size = New System.Drawing.Size(102, 67)
        Me.BCuentas.Text = "Cuentas x Cobrar"
        Me.BCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BCuentas.ToolTipText = "Cuentas por Cobrar."
        '
        'BPagadas
        '
        Me.BPagadas.ForeColor = System.Drawing.Color.Navy
        Me.BPagadas.Image = CType(resources.GetObject("BPagadas.Image"), System.Drawing.Image)
        Me.BPagadas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BPagadas.Name = "BPagadas"
        Me.BPagadas.Size = New System.Drawing.Size(101, 67)
        Me.BPagadas.Text = "Cuentas Pagadas"
        Me.BPagadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BPagadas.ToolTipText = "Pagos Realizados."
        '
        'BCtasAnuladas
        '
        Me.BCtasAnuladas.ForeColor = System.Drawing.Color.Navy
        Me.BCtasAnuladas.Image = CType(resources.GetObject("BCtasAnuladas.Image"), System.Drawing.Image)
        Me.BCtasAnuladas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BCtasAnuladas.Name = "BCtasAnuladas"
        Me.BCtasAnuladas.Size = New System.Drawing.Size(106, 67)
        Me.BCtasAnuladas.Text = "Cuentas Anuladas"
        Me.BCtasAnuladas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BCtasAnuladas.ToolTipText = "Créditos Anulados."
        '
        'BStatus
        '
        Me.BStatus.ForeColor = System.Drawing.Color.Navy
        Me.BStatus.Image = CType(resources.GetObject("BStatus.Image"), System.Drawing.Image)
        Me.BStatus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BStatus.Name = "BStatus"
        Me.BStatus.Size = New System.Drawing.Size(52, 67)
        Me.BStatus.Text = "Status"
        Me.BStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BStatus.ToolTipText = "Status del Cliente."
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.SeaGreen
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(1235, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(194, 25)
        Me.Label15.TabIndex = 729
        Me.Label15.Text = "Dolares ($)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.SteelBlue
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(1039, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(194, 25)
        Me.Label14.TabIndex = 728
        Me.Label14.Text = "Bolívares (Bs.)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LTotalRestaD
        '
        Me.LTotalRestaD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTotalRestaD.BackColor = System.Drawing.SystemColors.Info
        Me.LTotalRestaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalRestaD.ForeColor = System.Drawing.Color.Red
        Me.LTotalRestaD.Location = New System.Drawing.Point(1235, 108)
        Me.LTotalRestaD.Name = "LTotalRestaD"
        Me.LTotalRestaD.Size = New System.Drawing.Size(194, 24)
        Me.LTotalRestaD.TabIndex = 727
        Me.LTotalRestaD.Text = "0,00"
        Me.LTotalRestaD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LTotalAbonadoD
        '
        Me.LTotalAbonadoD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTotalAbonadoD.BackColor = System.Drawing.SystemColors.Info
        Me.LTotalAbonadoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalAbonadoD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LTotalAbonadoD.Location = New System.Drawing.Point(1235, 83)
        Me.LTotalAbonadoD.Name = "LTotalAbonadoD"
        Me.LTotalAbonadoD.Size = New System.Drawing.Size(194, 24)
        Me.LTotalAbonadoD.TabIndex = 726
        Me.LTotalAbonadoD.Text = "0,00"
        Me.LTotalAbonadoD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LTotalGeneralD
        '
        Me.LTotalGeneralD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTotalGeneralD.BackColor = System.Drawing.SystemColors.Info
        Me.LTotalGeneralD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalGeneralD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LTotalGeneralD.Location = New System.Drawing.Point(1235, 58)
        Me.LTotalGeneralD.Name = "LTotalGeneralD"
        Me.LTotalGeneralD.Size = New System.Drawing.Size(194, 24)
        Me.LTotalGeneralD.TabIndex = 725
        Me.LTotalGeneralD.Text = "0,00"
        Me.LTotalGeneralD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LTotalResta
        '
        Me.LTotalResta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTotalResta.BackColor = System.Drawing.SystemColors.Info
        Me.LTotalResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalResta.ForeColor = System.Drawing.Color.Red
        Me.LTotalResta.Location = New System.Drawing.Point(1039, 108)
        Me.LTotalResta.Name = "LTotalResta"
        Me.LTotalResta.Size = New System.Drawing.Size(194, 24)
        Me.LTotalResta.TabIndex = 724
        Me.LTotalResta.Text = "0,00"
        Me.LTotalResta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LResta
        '
        Me.LResta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LResta.BackColor = System.Drawing.Color.Transparent
        Me.LResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LResta.ForeColor = System.Drawing.Color.Red
        Me.LResta.Location = New System.Drawing.Point(931, 108)
        Me.LResta.Name = "LResta"
        Me.LResta.Size = New System.Drawing.Size(109, 23)
        Me.LResta.TabIndex = 723
        Me.LResta.Text = "Resta:"
        Me.LResta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LTotalAbonado
        '
        Me.LTotalAbonado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTotalAbonado.BackColor = System.Drawing.SystemColors.Info
        Me.LTotalAbonado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalAbonado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LTotalAbonado.Location = New System.Drawing.Point(1039, 83)
        Me.LTotalAbonado.Name = "LTotalAbonado"
        Me.LTotalAbonado.Size = New System.Drawing.Size(194, 24)
        Me.LTotalAbonado.TabIndex = 722
        Me.LTotalAbonado.Text = "0,00"
        Me.LTotalAbonado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LAbonado
        '
        Me.LAbonado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LAbonado.BackColor = System.Drawing.Color.Transparent
        Me.LAbonado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAbonado.ForeColor = System.Drawing.Color.Navy
        Me.LAbonado.Location = New System.Drawing.Point(931, 83)
        Me.LAbonado.Name = "LAbonado"
        Me.LAbonado.Size = New System.Drawing.Size(109, 23)
        Me.LAbonado.TabIndex = 721
        Me.LAbonado.Text = "Abonado:"
        Me.LAbonado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LTotalGeneral
        '
        Me.LTotalGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTotalGeneral.BackColor = System.Drawing.SystemColors.Info
        Me.LTotalGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LTotalGeneral.Location = New System.Drawing.Point(1039, 58)
        Me.LTotalGeneral.Name = "LTotalGeneral"
        Me.LTotalGeneral.Size = New System.Drawing.Size(194, 24)
        Me.LTotalGeneral.TabIndex = 720
        Me.LTotalGeneral.Text = "0,00"
        Me.LTotalGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(931, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 23)
        Me.Label7.TabIndex = 719
        Me.Label7.Text = "Total:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CCliente
        '
        Me.CCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.CCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCliente.Location = New System.Drawing.Point(401, 72)
        Me.CCliente.MaxLength = 8
        Me.CCliente.Name = "CCliente"
        Me.CCliente.ReadOnly = True
        Me.CCliente.Size = New System.Drawing.Size(220, 23)
        Me.CCliente.TabIndex = 916
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BExpandir)
        Me.Panel1.Controls.Add(Me.BSiguiente)
        Me.Panel1.Controls.Add(Me.BAnterior)
        Me.Panel1.Controls.Add(Me.Desde)
        Me.Panel1.Controls.Add(Me.Hasta)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BClientes)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.CLocal)
        Me.Panel1.Controls.Add(Me.RBCaja)
        Me.Panel1.Controls.Add(Me.CCaja)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.LTotalRestaD)
        Me.Panel1.Controls.Add(Me.LTotalAbonadoD)
        Me.Panel1.Controls.Add(Me.CCliente)
        Me.Panel1.Controls.Add(Me.LTotalGeneralD)
        Me.Panel1.Controls.Add(Me.LTotalResta)
        Me.Panel1.Controls.Add(Me.LResta)
        Me.Panel1.Controls.Add(Me.LTotalAbonado)
        Me.Panel1.Controls.Add(Me.CEmpleados)
        Me.Panel1.Controls.Add(Me.LAbonado)
        Me.Panel1.Controls.Add(Me.RBCliente)
        Me.Panel1.Controls.Add(Me.LTotalGeneral)
        Me.Panel1.Controls.Add(Me.RBTodas)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.RBPatrocinador)
        Me.Panel1.Controls.Add(Me.RBEmpleado)
        Me.Panel1.Controls.Add(Me.CPatrocinador)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1444, 168)
        Me.Panel1.TabIndex = 917
        '
        'BExpandir
        '
        Me.BExpandir.BackColor = System.Drawing.Color.White
        Me.BExpandir.CausesValidation = False
        Me.BExpandir.Image = CType(resources.GetObject("BExpandir.Image"), System.Drawing.Image)
        Me.BExpandir.Location = New System.Drawing.Point(1403, 136)
        Me.BExpandir.Name = "BExpandir"
        Me.BExpandir.Size = New System.Drawing.Size(38, 32)
        Me.BExpandir.TabIndex = 931
        Me.BExpandir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BExpandir.UseVisualStyleBackColor = False
        Me.BExpandir.Visible = False
        '
        'BSiguiente
        '
        Me.BSiguiente.BackColor = System.Drawing.Color.White
        Me.BSiguiente.BackgroundImage = CType(resources.GetObject("BSiguiente.BackgroundImage"), System.Drawing.Image)
        Me.BSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BSiguiente.CausesValidation = False
        Me.BSiguiente.Location = New System.Drawing.Point(194, 27)
        Me.BSiguiente.Name = "BSiguiente"
        Me.BSiguiente.Size = New System.Drawing.Size(35, 110)
        Me.BSiguiente.TabIndex = 930
        Me.BSiguiente.UseVisualStyleBackColor = False
        '
        'BAnterior
        '
        Me.BAnterior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BAnterior.BackColor = System.Drawing.Color.White
        Me.BAnterior.BackgroundImage = CType(resources.GetObject("BAnterior.BackgroundImage"), System.Drawing.Image)
        Me.BAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BAnterior.CausesValidation = False
        Me.BAnterior.Location = New System.Drawing.Point(11, 25)
        Me.BAnterior.Name = "BAnterior"
        Me.BAnterior.Size = New System.Drawing.Size(35, 110)
        Me.BAnterior.TabIndex = 929
        Me.BAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAnterior.UseVisualStyleBackColor = False
        '
        'Desde
        '
        Me.Desde.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.Desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Desde.Location = New System.Drawing.Point(59, 50)
        Me.Desde.Name = "Desde"
        Me.Desde.Size = New System.Drawing.Size(123, 26)
        Me.Desde.TabIndex = 925
        Me.Desde.Value = New Date(2015, 10, 1, 0, 0, 0, 0)
        '
        'Hasta
        '
        Me.Hasta.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.Hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Hasta.Location = New System.Drawing.Point(59, 101)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Size = New System.Drawing.Size(123, 26)
        Me.Hasta.TabIndex = 927
        Me.Hasta.Value = New Date(2015, 10, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(59, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 26)
        Me.Label1.TabIndex = 926
        Me.Label1.Text = "Desde:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(59, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 26)
        Me.Label8.TabIndex = 928
        Me.Label8.Text = "Hasta:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.White
        Me.BClientes.CausesValidation = False
        Me.BClientes.Image = CType(resources.GetObject("BClientes.Image"), System.Drawing.Image)
        Me.BClientes.Location = New System.Drawing.Point(642, 58)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Size = New System.Drawing.Size(51, 44)
        Me.BClientes.TabIndex = 922
        Me.BClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(633, 103)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 924
        Me.Label20.Text = "Buscar Cliente"
        '
        'CLocal
        '
        Me.CLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLocal.FormattingEnabled = True
        Me.CLocal.Items.AddRange(New Object() {"Sin Gastos Asoc.", "Con Gastos Asoc.", "Todas"})
        Me.CLocal.Location = New System.Drawing.Point(401, 12)
        Me.CLocal.Name = "CLocal"
        Me.CLocal.Size = New System.Drawing.Size(220, 24)
        Me.CLocal.TabIndex = 923
        '
        'RBCaja
        '
        Me.RBCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCaja.ForeColor = System.Drawing.Color.Navy
        Me.RBCaja.Location = New System.Drawing.Point(277, 131)
        Me.RBCaja.Name = "RBCaja"
        Me.RBCaja.Size = New System.Drawing.Size(120, 25)
        Me.RBCaja.TabIndex = 920
        Me.RBCaja.Text = "Caja:"
        Me.RBCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RBCaja.UseVisualStyleBackColor = True
        '
        'CCaja
        '
        Me.CCaja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CCaja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CCaja.Enabled = False
        Me.CCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCaja.FormattingEnabled = True
        Me.CCaja.ItemHeight = 16
        Me.CCaja.Location = New System.Drawing.Point(401, 131)
        Me.CCaja.Margin = New System.Windows.Forms.Padding(0)
        Me.CCaja.Name = "CCaja"
        Me.CCaja.Size = New System.Drawing.Size(220, 24)
        Me.CCaja.TabIndex = 921
        '
        'FCuentasporCobrarVL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1444, 707)
        Me.Controls.Add(Me.DGCuentasXPagar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FCuentasporCobrarVL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Cuentas por Cobrar."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGCuentasXPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGCuentasXPagar As System.Windows.Forms.DataGridView
    Friend WithEvents RBCliente As System.Windows.Forms.RadioButton
    Friend WithEvents RBTodas As System.Windows.Forms.RadioButton
    Friend WithEvents CPatrocinador As System.Windows.Forms.ComboBox
    Friend WithEvents RBPatrocinador As System.Windows.Forms.RadioButton
    Friend WithEvents CEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents RBEmpleado As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents BCuentas As System.Windows.Forms.ToolStripButton
    Friend WithEvents BPagadas As System.Windows.Forms.ToolStripButton
    Friend WithEvents BStatus As System.Windows.Forms.ToolStripButton
    Friend WithEvents BCtasAnuladas As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LTotalRestaD As System.Windows.Forms.Label
    Friend WithEvents LTotalAbonadoD As System.Windows.Forms.Label
    Friend WithEvents LTotalGeneralD As System.Windows.Forms.Label
    Friend WithEvents LTotalResta As System.Windows.Forms.Label
    Friend WithEvents LResta As System.Windows.Forms.Label
    Friend WithEvents LTotalAbonado As System.Windows.Forms.Label
    Friend WithEvents LAbonado As System.Windows.Forms.Label
    Friend WithEvents LTotalGeneral As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CCliente As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RBCaja As System.Windows.Forms.RadioButton
    Friend WithEvents CCaja As System.Windows.Forms.ComboBox
    Friend WithEvents BClientes As System.Windows.Forms.Button
    Friend WithEvents CLocal As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents BSiguiente As System.Windows.Forms.Button
    Friend WithEvents BAnterior As System.Windows.Forms.Button
    Friend WithEvents Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BExpandir As System.Windows.Forms.Button
End Class
