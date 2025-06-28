<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FReporteSemanal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FReporteSemanal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Salir = New System.Windows.Forms.ToolStripButton()
        Me.btn_Exportar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_Buscar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtp_FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btn_DesSeleccionar = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lbl_Registros = New System.Windows.Forms.Label()
        Me.lbl_CantidadSeleccionada = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_SumaSelect = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgv_Datos = New System.Windows.Forms.DataGridView()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_Conceptos = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_Totales = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv_TipoPagos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgv_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_Conceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_Totales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_TipoPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Salir, Me.btn_Exportar, Me.btn_Nuevo, Me.btn_Buscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1361, 81)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Salir
        '
        Me.btn_Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Salir.Margin = New System.Windows.Forms.Padding(0, 3, 0, 6)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_Salir.Size = New System.Drawing.Size(72, 72)
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Exportar.Image = CType(resources.GetObject("btn_Exportar.Image"), System.Drawing.Image)
        Me.btn_Exportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Exportar.Margin = New System.Windows.Forms.Padding(0, 3, 0, 6)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_Exportar.Size = New System.Drawing.Size(75, 72)
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nuevo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 6)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_Nuevo.Size = New System.Drawing.Size(72, 72)
        Me.btn_Nuevo.Text = "Refresh"
        Me.btn_Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Buscar.Margin = New System.Windows.Forms.Padding(0, 3, 0, 6)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_Buscar.Size = New System.Drawing.Size(72, 72)
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtp_FechaFinal)
        Me.Panel1.Controls.Add(Me.dtp_FechaInicial)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1361, 80)
        Me.Panel1.TabIndex = 1
        '
        'dtp_FechaFinal
        '
        Me.dtp_FechaFinal.CustomFormat = ""
        Me.dtp_FechaFinal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFinal.Location = New System.Drawing.Point(204, 39)
        Me.dtp_FechaFinal.MinimumSize = New System.Drawing.Size(25, 25)
        Me.dtp_FechaFinal.Name = "dtp_FechaFinal"
        Me.dtp_FechaFinal.Size = New System.Drawing.Size(165, 27)
        Me.dtp_FechaFinal.TabIndex = 4
        '
        'dtp_FechaInicial
        '
        Me.dtp_FechaInicial.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaInicial.CustomFormat = ""
        Me.dtp_FechaInicial.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicial.Location = New System.Drawing.Point(24, 39)
        Me.dtp_FechaInicial.MinimumSize = New System.Drawing.Size(25, 25)
        Me.dtp_FechaInicial.Name = "dtp_FechaInicial"
        Me.dtp_FechaInicial.Size = New System.Drawing.Size(165, 27)
        Me.dtp_FechaInicial.TabIndex = 4
        Me.dtp_FechaInicial.Value = New Date(2025, 5, 14, 20, 12, 11, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SkyBlue
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(201, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(21, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha inicial:"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.ProgressBar1)
        Me.Panel11.Controls.Add(Me.btn_DesSeleccionar)
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Controls.Add(Me.lbl_Registros)
        Me.Panel11.Controls.Add(Me.lbl_CantidadSeleccionada)
        Me.Panel11.Controls.Add(Me.Label3)
        Me.Panel11.Controls.Add(Me.lbl_SumaSelect)
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.Controls.Add(Me.Label8)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 610)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1361, 30)
        Me.Panel11.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(419, 11)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(450, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 11
        Me.ProgressBar1.Visible = False
        '
        'btn_DesSeleccionar
        '
        Me.btn_DesSeleccionar.BackgroundImage = CType(resources.GetObject("btn_DesSeleccionar.BackgroundImage"), System.Drawing.Image)
        Me.btn_DesSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_DesSeleccionar.FlatAppearance.BorderSize = 0
        Me.btn_DesSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DesSeleccionar.Location = New System.Drawing.Point(4, 3)
        Me.btn_DesSeleccionar.Name = "btn_DesSeleccionar"
        Me.btn_DesSeleccionar.Size = New System.Drawing.Size(23, 23)
        Me.btn_DesSeleccionar.TabIndex = 10
        Me.btn_DesSeleccionar.UseVisualStyleBackColor = True
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel13.Location = New System.Drawing.Point(1167, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(3, 25)
        Me.Panel13.TabIndex = 9
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Location = New System.Drawing.Point(182, 7)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(105, 13)
        Me.lbl_Registros.TabIndex = 6
        Me.lbl_Registros.Text = "0"
        '
        'lbl_CantidadSeleccionada
        '
        Me.lbl_CantidadSeleccionada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CantidadSeleccionada.Location = New System.Drawing.Point(1035, 8)
        Me.lbl_CantidadSeleccionada.Name = "lbl_CantidadSeleccionada"
        Me.lbl_CantidadSeleccionada.Size = New System.Drawing.Size(105, 13)
        Me.lbl_CantidadSeleccionada.TabIndex = 6
        Me.lbl_CantidadSeleccionada.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cantidad de Registros:"
        '
        'lbl_SumaSelect
        '
        Me.lbl_SumaSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SumaSelect.Location = New System.Drawing.Point(1250, 8)
        Me.lbl_SumaSelect.Name = "lbl_SumaSelect"
        Me.lbl_SumaSelect.Size = New System.Drawing.Size(105, 13)
        Me.lbl_SumaSelect.TabIndex = 6
        Me.lbl_SumaSelect.Text = "0"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(981, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Cantidad:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1214, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Suma:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel12)
        Me.Panel4.Controls.Add(Me.Panel11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 80)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1361, 640)
        Me.Panel4.TabIndex = 4
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel6)
        Me.Panel12.Controls.Add(Me.Panel15)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1361, 610)
        Me.Panel12.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgv_Datos)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1025, 610)
        Me.Panel6.TabIndex = 2
        '
        'dgv_Datos
        '
        Me.dgv_Datos.AllowUserToAddRows = False
        Me.dgv_Datos.AllowUserToDeleteRows = False
        Me.dgv_Datos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_Datos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Datos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Datos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Datos.ColumnHeadersHeight = 32
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Datos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Datos.EnableHeadersVisualStyles = False
        Me.dgv_Datos.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_Datos.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Datos.Name = "dgv_Datos"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Datos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Datos.RowHeadersVisible = False
        Me.dgv_Datos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_Datos.Size = New System.Drawing.Size(1025, 610)
        Me.dgv_Datos.TabIndex = 0
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Panel3)
        Me.Panel15.Controls.Add(Me.Panel2)
        Me.Panel15.Controls.Add(Me.Panel5)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(1025, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(336, 610)
        Me.Panel15.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_Conceptos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 230)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(336, 176)
        Me.Panel3.TabIndex = 2
        '
        'dgv_Conceptos
        '
        Me.dgv_Conceptos.AllowUserToAddRows = False
        Me.dgv_Conceptos.AllowUserToDeleteRows = False
        Me.dgv_Conceptos.AllowUserToOrderColumns = True
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Conceptos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Conceptos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Conceptos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Conceptos.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Conceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Conceptos.EnableHeadersVisualStyles = False
        Me.dgv_Conceptos.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_Conceptos.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Conceptos.Name = "dgv_Conceptos"
        Me.dgv_Conceptos.ReadOnly = True
        Me.dgv_Conceptos.RowHeadersVisible = False
        Me.dgv_Conceptos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Conceptos.Size = New System.Drawing.Size(336, 176)
        Me.dgv_Conceptos.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgv_Totales)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 406)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(336, 204)
        Me.Panel2.TabIndex = 2
        '
        'dgv_Totales
        '
        Me.dgv_Totales.AllowUserToAddRows = False
        Me.dgv_Totales.AllowUserToDeleteRows = False
        Me.dgv_Totales.AllowUserToOrderColumns = True
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Totales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_Totales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Totales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Totales.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_Totales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Totales.EnableHeadersVisualStyles = False
        Me.dgv_Totales.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_Totales.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Totales.Name = "dgv_Totales"
        Me.dgv_Totales.ReadOnly = True
        Me.dgv_Totales.RowHeadersVisible = False
        Me.dgv_Totales.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Totales.Size = New System.Drawing.Size(336, 204)
        Me.dgv_Totales.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgv_TipoPagos)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(336, 230)
        Me.Panel5.TabIndex = 2
        '
        'dgv_TipoPagos
        '
        Me.dgv_TipoPagos.AllowUserToAddRows = False
        Me.dgv_TipoPagos.AllowUserToDeleteRows = False
        Me.dgv_TipoPagos.AllowUserToOrderColumns = True
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Teal
        Me.dgv_TipoPagos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_TipoPagos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_TipoPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_TipoPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_TipoPagos.EnableHeadersVisualStyles = False
        Me.dgv_TipoPagos.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_TipoPagos.Location = New System.Drawing.Point(0, 0)
        Me.dgv_TipoPagos.Name = "dgv_TipoPagos"
        Me.dgv_TipoPagos.ReadOnly = True
        Me.dgv_TipoPagos.RowHeadersVisible = False
        Me.dgv_TipoPagos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_TipoPagos.Size = New System.Drawing.Size(336, 230)
        Me.dgv_TipoPagos.TabIndex = 0
        '
        'FReporteSemanal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1361, 720)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FReporteSemanal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FReporteSemanal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgv_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_Conceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_Totales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgv_TipoPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Salir As ToolStripButton
    Friend WithEvents btn_Buscar As ToolStripButton
    Friend WithEvents btn_Nuevo As ToolStripButton
    Friend WithEvents btn_Exportar As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_FechaInicial As DateTimePicker
    Friend WithEvents dtp_FechaFinal As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel11 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btn_DesSeleccionar As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lbl_CantidadSeleccionada As Label
    Friend WithEvents lbl_SumaSelect As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgv_Datos As DataGridView
    Friend WithEvents dgv_Conceptos As DataGridView
    Friend WithEvents dgv_Totales As DataGridView
    Friend WithEvents dgv_TipoPagos As DataGridView
    Friend WithEvents lbl_Registros As Label
    Friend WithEvents Label3 As Label
End Class
