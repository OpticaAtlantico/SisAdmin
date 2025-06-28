<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FFormaPago
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FFormaPago))
        Me.LTotall = New System.Windows.Forms.Label()
        Me.GridFormaPago = New System.Windows.Forms.DataGridView()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MCFechaPago = New System.Windows.Forms.MonthCalendar()
        Me.LTotalDF = New System.Windows.Forms.Label()
        Me.LRestaD = New System.Windows.Forms.Label()
        Me.LAbonadoD = New System.Windows.Forms.Label()
        Me.AgregarPago = New System.Windows.Forms.ToolStripButton()
        Me.EliminarPago = New System.Windows.Forms.ToolStripButton()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LNumOrden = New System.Windows.Forms.Label()
        Me.LCI = New System.Windows.Forms.Label()
        Me.LNO = New System.Windows.Forms.Label()
        Me.LC = New System.Windows.Forms.Label()
        CType(Me.GridFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LTotall
        '
        Me.LTotall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotall.ForeColor = System.Drawing.Color.Navy
        Me.LTotall.Location = New System.Drawing.Point(550, 87)
        Me.LTotall.Name = "LTotall"
        Me.LTotall.Size = New System.Drawing.Size(106, 20)
        Me.LTotall.TabIndex = 41
        Me.LTotall.Text = "Total :"
        Me.LTotall.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridFormaPago
        '
        Me.GridFormaPago.AllowUserToAddRows = False
        Me.GridFormaPago.AllowUserToDeleteRows = False
        Me.GridFormaPago.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridFormaPago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridFormaPago.ColumnHeadersHeight = 32
        Me.GridFormaPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.FechaPago, Me.Monto, Me.idTipoPago, Me.TipoPago, Me.Observacion, Me.id})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridFormaPago.DefaultCellStyle = DataGridViewCellStyle8
        Me.GridFormaPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFormaPago.EnableHeadersVisualStyles = False
        Me.GridFormaPago.Location = New System.Drawing.Point(0, 176)
        Me.GridFormaPago.Name = "GridFormaPago"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridFormaPago.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.GridFormaPago.RowHeadersVisible = False
        Me.GridFormaPago.RowTemplate.Height = 26
        Me.GridFormaPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridFormaPago.Size = New System.Drawing.Size(966, 382)
        Me.GridFormaPago.TabIndex = 42
        '
        'Num
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Num.DefaultCellStyle = DataGridViewCellStyle2
        Me.Num.HeaderText = "Nº"
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        Me.Num.Width = 50
        '
        'FechaPago
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaPago.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaPago.HeaderText = "Fecha Pago"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.ReadOnly = True
        Me.FechaPago.ToolTipText = "Fecha de Pago."
        Me.FechaPago.Width = 200
        '
        'Monto
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle4
        Me.Monto.HeaderText = "Monto $"
        Me.Monto.Name = "Monto"
        Me.Monto.ToolTipText = "Monto en Dolares."
        Me.Monto.Width = 150
        '
        'idTipoPago
        '
        Me.idTipoPago.HeaderText = "idTipoPago"
        Me.idTipoPago.Name = "idTipoPago"
        Me.idTipoPago.ReadOnly = True
        Me.idTipoPago.Visible = False
        '
        'TipoPago
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TipoPago.DefaultCellStyle = DataGridViewCellStyle5
        Me.TipoPago.HeaderText = "Tipo Pago"
        Me.TipoPago.Name = "TipoPago"
        Me.TipoPago.ReadOnly = True
        Me.TipoPago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TipoPago.ToolTipText = "Tipo Pago."
        Me.TipoPago.Width = 200
        '
        'Observacion
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Observacion.DefaultCellStyle = DataGridViewCellStyle6
        Me.Observacion.HeaderText = "Observación."
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ToolTipText = "Observación."
        Me.Observacion.Width = 300
        '
        'id
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.id.DefaultCellStyle = DataGridViewCellStyle7
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.ToolTipText = "id"
        Me.id.Visible = False
        Me.id.Width = 120
        '
        'CTipoPago
        '
        Me.CTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTipoPago.FormattingEnabled = True
        Me.CTipoPago.ItemHeight = 16
        Me.CTipoPago.Location = New System.Drawing.Point(407, 282)
        Me.CTipoPago.Margin = New System.Windows.Forms.Padding(0)
        Me.CTipoPago.Name = "CTipoPago"
        Me.CTipoPago.Size = New System.Drawing.Size(152, 24)
        Me.CTipoPago.TabIndex = 48
        Me.CTipoPago.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(550, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Abonado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(550, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Resta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MCFechaPago
        '
        Me.MCFechaPago.BackColor = System.Drawing.Color.Lavender
        Me.MCFechaPago.Location = New System.Drawing.Point(18, 253)
        Me.MCFechaPago.Name = "MCFechaPago"
        Me.MCFechaPago.TabIndex = 302
        Me.MCFechaPago.Visible = False
        '
        'LTotalDF
        '
        Me.LTotalDF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LTotalDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalDF.ForeColor = System.Drawing.Color.Navy
        Me.LTotalDF.Location = New System.Drawing.Point(662, 84)
        Me.LTotalDF.Name = "LTotalDF"
        Me.LTotalDF.Size = New System.Drawing.Size(156, 25)
        Me.LTotalDF.TabIndex = 320
        Me.LTotalDF.Text = "0,00"
        Me.LTotalDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LRestaD
        '
        Me.LRestaD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LRestaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRestaD.ForeColor = System.Drawing.Color.Red
        Me.LRestaD.Location = New System.Drawing.Point(662, 139)
        Me.LRestaD.Name = "LRestaD"
        Me.LRestaD.Size = New System.Drawing.Size(156, 25)
        Me.LRestaD.TabIndex = 318
        Me.LRestaD.Text = "0,00"
        Me.LRestaD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LAbonadoD
        '
        Me.LAbonadoD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LAbonadoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAbonadoD.ForeColor = System.Drawing.Color.Navy
        Me.LAbonadoD.Location = New System.Drawing.Point(662, 111)
        Me.LAbonadoD.Name = "LAbonadoD"
        Me.LAbonadoD.Size = New System.Drawing.Size(156, 25)
        Me.LAbonadoD.TabIndex = 317
        Me.LAbonadoD.Text = "0,00"
        Me.LAbonadoD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgregarPago
        '
        Me.AgregarPago.AutoSize = False
        Me.AgregarPago.ForeColor = System.Drawing.Color.Navy
        Me.AgregarPago.Image = CType(resources.GetObject("AgregarPago.Image"), System.Drawing.Image)
        Me.AgregarPago.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AgregarPago.Name = "AgregarPago"
        Me.AgregarPago.Size = New System.Drawing.Size(125, 100)
        Me.AgregarPago.Text = "Agregar Pago"
        Me.AgregarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AgregarPago.ToolTipText = "Agregar Pago."
        '
        'EliminarPago
        '
        Me.EliminarPago.AutoSize = False
        Me.EliminarPago.ForeColor = System.Drawing.Color.Navy
        Me.EliminarPago.Image = CType(resources.GetObject("EliminarPago.Image"), System.Drawing.Image)
        Me.EliminarPago.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EliminarPago.Name = "EliminarPago"
        Me.EliminarPago.Size = New System.Drawing.Size(125, 100)
        Me.EliminarPago.Text = "Eliminar Pago"
        Me.EliminarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.EliminarPago.ToolTipText = "Eliminar Pago."
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.AutoSize = False
        Me.Salir.ForeColor = System.Drawing.Color.Navy
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(125, 100)
        Me.Salir.Text = "Salir"
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Salir.ToolTipText = "Salir."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 100)
        '
        'Guardar
        '
        Me.Guardar.AutoSize = False
        Me.Guardar.ForeColor = System.Drawing.Color.Navy
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(125, 100)
        Me.Guardar.Text = " Guardar  Pago"
        Me.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Guardar.ToolTipText = "Guardar Forma de Pago."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 100)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPago, Me.EliminarPago, Me.Salir, Me.ToolStripSeparator1, Me.Guardar, Me.ToolStripSeparator4, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 76)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(966, 100)
        Me.ToolStrip1.TabIndex = 299
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 100)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightBlue
        Me.Panel2.Controls.Add(Me.LFecha)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.LCliente)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.LNumOrden)
        Me.Panel2.Controls.Add(Me.LCI)
        Me.Panel2.Controls.Add(Me.LNO)
        Me.Panel2.Controls.Add(Me.LC)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(966, 76)
        Me.Panel2.TabIndex = 922
        '
        'LFecha
        '
        Me.LFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.Black
        Me.LFecha.Location = New System.Drawing.Point(815, 39)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(140, 32)
        Me.LFecha.TabIndex = 228
        Me.LFecha.Text = "04/06/2024"
        Me.LFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label18.Location = New System.Drawing.Point(687, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 32)
        Me.Label18.TabIndex = 227
        Me.Label18.Text = "Fecha Orden:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LCliente
        '
        Me.LCliente.BackColor = System.Drawing.Color.Transparent
        Me.LCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCliente.ForeColor = System.Drawing.Color.Black
        Me.LCliente.Location = New System.Drawing.Point(79, 38)
        Me.LCliente.Name = "LCliente"
        Me.LCliente.Size = New System.Drawing.Size(287, 30)
        Me.LCliente.TabIndex = 226
        Me.LCliente.Text = "050505"
        Me.LCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(3, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 30)
        Me.Label8.TabIndex = 225
        Me.Label8.Text = "Cliente:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LNumOrden
        '
        Me.LNumOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNumOrden.BackColor = System.Drawing.Color.Transparent
        Me.LNumOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNumOrden.ForeColor = System.Drawing.Color.Black
        Me.LNumOrden.Location = New System.Drawing.Point(815, 5)
        Me.LNumOrden.Name = "LNumOrden"
        Me.LNumOrden.Size = New System.Drawing.Size(140, 34)
        Me.LNumOrden.TabIndex = 224
        Me.LNumOrden.Text = "12345"
        Me.LNumOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LCI
        '
        Me.LCI.BackColor = System.Drawing.Color.Transparent
        Me.LCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCI.ForeColor = System.Drawing.Color.Black
        Me.LCI.Location = New System.Drawing.Point(79, 9)
        Me.LCI.Name = "LCI"
        Me.LCI.Size = New System.Drawing.Size(287, 28)
        Me.LCI.TabIndex = 223
        Me.LCI.Text = "050505"
        Me.LCI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LNO
        '
        Me.LNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNO.BackColor = System.Drawing.Color.Transparent
        Me.LNO.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNO.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LNO.Location = New System.Drawing.Point(687, 5)
        Me.LNO.Name = "LNO"
        Me.LNO.Size = New System.Drawing.Size(132, 34)
        Me.LNO.TabIndex = 222
        Me.LNO.Text = "Orden Nº:"
        Me.LNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LC
        '
        Me.LC.BackColor = System.Drawing.Color.Transparent
        Me.LC.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LC.Location = New System.Drawing.Point(3, 9)
        Me.LC.Name = "LC"
        Me.LC.Size = New System.Drawing.Size(82, 28)
        Me.LC.TabIndex = 221
        Me.LC.Text = "C.I.:"
        Me.LC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(966, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.LTotall)
        Me.Controls.Add(Me.MCFechaPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CTipoPago)
        Me.Controls.Add(Me.LTotalDF)
        Me.Controls.Add(Me.LRestaD)
        Me.Controls.Add(Me.LAbonadoD)
        Me.Controls.Add(Me.GridFormaPago)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " MarSoft: Forma de Pago."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LTotall As System.Windows.Forms.Label
    Friend WithEvents CTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MCFechaPago As System.Windows.Forms.MonthCalendar
    Friend WithEvents GridFormaPago As System.Windows.Forms.DataGridView
    Friend WithEvents LTotalDF As System.Windows.Forms.Label
    Friend WithEvents LRestaD As System.Windows.Forms.Label
    Friend WithEvents LAbonadoD As System.Windows.Forms.Label
    Friend WithEvents AgregarPago As System.Windows.Forms.ToolStripButton
    Friend WithEvents EliminarPago As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LCliente As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LNumOrden As System.Windows.Forms.Label
    Friend WithEvents LCI As System.Windows.Forms.Label
    Friend WithEvents LNO As System.Windows.Forms.Label
    Friend WithEvents LC As System.Windows.Forms.Label
    Friend WithEvents Num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idTipoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
