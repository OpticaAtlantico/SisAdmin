<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FControlCajaDesglose
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FControlCajaDesglose))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.Num1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaD1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCierre = New System.Windows.Forms.DateTimePicker()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GridVentas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodVentax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalle = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BEfectivo = New System.Windows.Forms.Button()
        Me.BDolar = New System.Windows.Forms.Button()
        Me.BTransferencia = New System.Windows.Forms.Button()
        Me.BTarjeta = New System.Windows.Forms.Button()
        Me.BOtros = New System.Windows.Forms.Button()
        Me.BPagoMovil = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BCreditos = New System.Windows.Forms.Button()
        Me.BBioPago = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LDifMoneda = New System.Windows.Forms.Label()
        Me.BEliminar = New System.Windows.Forms.Button()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.Navy
        Me.LTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(947, 54)
        Me.LTitulo.TabIndex = 1030
        Me.LTitulo.Text = "Desglose Ingresos de Dolares por Ventas"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AllowUserToResizeColumns = False
        Me.Grid.AllowUserToResizeRows = False
        Me.Grid.BackgroundColor = System.Drawing.Color.Beige
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.ColumnHeadersHeight = 30
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num1, Me.VentaD1, Me.FormaPago})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.Location = New System.Drawing.Point(0, 54)
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Grid.Size = New System.Drawing.Size(947, 625)
        Me.Grid.TabIndex = 1031
        '
        'Num1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Num1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Num1.HeaderText = "Nº"
        Me.Num1.Name = "Num1"
        Me.Num1.ReadOnly = True
        Me.Num1.Width = 180
        '
        'VentaD1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.VentaD1.DefaultCellStyle = DataGridViewCellStyle3
        Me.VentaD1.HeaderText = "Venta $"
        Me.VentaD1.Name = "VentaD1"
        Me.VentaD1.Width = 250
        '
        'FormaPago
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FormaPago.DefaultCellStyle = DataGridViewCellStyle4
        Me.FormaPago.HeaderText = "Forma Pago"
        Me.FormaPago.Name = "FormaPago"
        Me.FormaPago.ReadOnly = True
        Me.FormaPago.Width = 250
        '
        'FechaCierre
        '
        Me.FechaCierre.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.FechaCierre.CalendarTitleForeColor = System.Drawing.Color.Beige
        Me.FechaCierre.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.FechaCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaCierre.Location = New System.Drawing.Point(279, 244)
        Me.FechaCierre.Name = "FechaCierre"
        Me.FechaCierre.Size = New System.Drawing.Size(187, 26)
        Me.FechaCierre.TabIndex = 1033
        Me.FechaCierre.Value = New Date(2015, 10, 1, 0, 0, 0, 0)
        Me.FechaCierre.Visible = False
        '
        'Fecha
        '
        Me.Fecha.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.Fecha.CalendarTitleForeColor = System.Drawing.Color.Beige
        Me.Fecha.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.Fecha.Enabled = False
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha.Location = New System.Drawing.Point(279, 208)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(187, 26)
        Me.Fecha.TabIndex = 1032
        Me.Fecha.Value = New Date(2015, 10, 1, 0, 0, 0, 0)
        Me.Fecha.Visible = False
        '
        'BSalir
        '
        Me.BSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSalir.BackColor = System.Drawing.Color.White
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.Location = New System.Drawing.Point(892, 1)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(55, 51)
        Me.BSalir.TabIndex = 1034
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'GridVentas
        '
        Me.GridVentas.AllowUserToAddRows = False
        Me.GridVentas.AllowUserToDeleteRows = False
        Me.GridVentas.AllowUserToResizeColumns = False
        Me.GridVentas.AllowUserToResizeRows = False
        Me.GridVentas.BackgroundColor = System.Drawing.Color.Beige
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GridVentas.ColumnHeadersHeight = 30
        Me.GridVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CodVentax, Me.FechaX, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.TipoPago, Me.Detalle})
        Me.GridVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVentas.EnableHeadersVisualStyles = False
        Me.GridVentas.Location = New System.Drawing.Point(0, 54)
        Me.GridVentas.Name = "GridVentas"
        Me.GridVentas.RowHeadersVisible = False
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridVentas.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.GridVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridVentas.Size = New System.Drawing.Size(947, 625)
        Me.GridVentas.TabIndex = 1035
        Me.GridVentas.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nº"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'CodVentax
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CodVentax.DefaultCellStyle = DataGridViewCellStyle8
        Me.CodVentax.HeaderText = "Cod. V."
        Me.CodVentax.Name = "CodVentax"
        Me.CodVentax.ReadOnly = True
        Me.CodVentax.ToolTipText = "Código de Venta."
        '
        'FechaX
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaX.DefaultCellStyle = DataGridViewCellStyle9
        Me.FechaX.HeaderText = "Fecha"
        Me.FechaX.Name = "FechaX"
        Me.FechaX.ReadOnly = True
        Me.FechaX.Width = 170
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn4.HeaderText = "Venta $"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn5.HeaderText = "F. Pago"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.ToolTipText = "Forma Pago."
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'TipoPago
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TipoPago.DefaultCellStyle = DataGridViewCellStyle12
        Me.TipoPago.HeaderText = "P. V."
        Me.TipoPago.Name = "TipoPago"
        Me.TipoPago.ReadOnly = True
        Me.TipoPago.ToolTipText = "Pago Varios."
        Me.TipoPago.Width = 120
        '
        'Detalle
        '
        Me.Detalle.HeaderText = "Detalle"
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Detalle.Text = "..."
        Me.Detalle.ToolTipText = "Mostrar Detalle de la Venta."
        '
        'BEfectivo
        '
        Me.BEfectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BEfectivo.BackColor = System.Drawing.Color.White
        Me.BEfectivo.Image = CType(resources.GetObject("BEfectivo.Image"), System.Drawing.Image)
        Me.BEfectivo.Location = New System.Drawing.Point(827, 67)
        Me.BEfectivo.Name = "BEfectivo"
        Me.BEfectivo.Size = New System.Drawing.Size(65, 63)
        Me.BEfectivo.TabIndex = 1036
        Me.ToolTip1.SetToolTip(Me.BEfectivo, "Efectivo Bolívares.")
        Me.BEfectivo.UseVisualStyleBackColor = False
        '
        'BDolar
        '
        Me.BDolar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BDolar.BackColor = System.Drawing.Color.White
        Me.BDolar.Image = CType(resources.GetObject("BDolar.Image"), System.Drawing.Image)
        Me.BDolar.Location = New System.Drawing.Point(827, 143)
        Me.BDolar.Name = "BDolar"
        Me.BDolar.Size = New System.Drawing.Size(65, 63)
        Me.BDolar.TabIndex = 1037
        Me.ToolTip1.SetToolTip(Me.BDolar, "Efectivo Dolares.")
        Me.BDolar.UseVisualStyleBackColor = False
        '
        'BTransferencia
        '
        Me.BTransferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTransferencia.BackColor = System.Drawing.Color.White
        Me.BTransferencia.Image = CType(resources.GetObject("BTransferencia.Image"), System.Drawing.Image)
        Me.BTransferencia.Location = New System.Drawing.Point(827, 371)
        Me.BTransferencia.Name = "BTransferencia"
        Me.BTransferencia.Size = New System.Drawing.Size(65, 63)
        Me.BTransferencia.TabIndex = 1039
        Me.ToolTip1.SetToolTip(Me.BTransferencia, "Transferencias.")
        Me.BTransferencia.UseVisualStyleBackColor = False
        '
        'BTarjeta
        '
        Me.BTarjeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTarjeta.BackColor = System.Drawing.Color.White
        Me.BTarjeta.Image = CType(resources.GetObject("BTarjeta.Image"), System.Drawing.Image)
        Me.BTarjeta.Location = New System.Drawing.Point(827, 219)
        Me.BTarjeta.Name = "BTarjeta"
        Me.BTarjeta.Size = New System.Drawing.Size(65, 63)
        Me.BTarjeta.TabIndex = 1038
        Me.ToolTip1.SetToolTip(Me.BTarjeta, "Tarjeta.")
        Me.BTarjeta.UseVisualStyleBackColor = False
        '
        'BOtros
        '
        Me.BOtros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BOtros.BackColor = System.Drawing.Color.White
        Me.BOtros.Image = CType(resources.GetObject("BOtros.Image"), System.Drawing.Image)
        Me.BOtros.Location = New System.Drawing.Point(827, 599)
        Me.BOtros.Name = "BOtros"
        Me.BOtros.Size = New System.Drawing.Size(65, 63)
        Me.BOtros.TabIndex = 1041
        Me.ToolTip1.SetToolTip(Me.BOtros, "Otros Pagos.")
        Me.BOtros.UseVisualStyleBackColor = False
        '
        'BPagoMovil
        '
        Me.BPagoMovil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BPagoMovil.BackColor = System.Drawing.Color.White
        Me.BPagoMovil.Image = CType(resources.GetObject("BPagoMovil.Image"), System.Drawing.Image)
        Me.BPagoMovil.Location = New System.Drawing.Point(827, 447)
        Me.BPagoMovil.Name = "BPagoMovil"
        Me.BPagoMovil.Size = New System.Drawing.Size(65, 63)
        Me.BPagoMovil.TabIndex = 1040
        Me.ToolTip1.SetToolTip(Me.BPagoMovil, "Pago Móvil.")
        Me.BPagoMovil.UseVisualStyleBackColor = False
        '
        'BCreditos
        '
        Me.BCreditos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCreditos.BackColor = System.Drawing.Color.White
        Me.BCreditos.Image = CType(resources.GetObject("BCreditos.Image"), System.Drawing.Image)
        Me.BCreditos.Location = New System.Drawing.Point(827, 523)
        Me.BCreditos.Name = "BCreditos"
        Me.BCreditos.Size = New System.Drawing.Size(65, 63)
        Me.BCreditos.TabIndex = 1042
        Me.ToolTip1.SetToolTip(Me.BCreditos, "Otros Pagos.")
        Me.BCreditos.UseVisualStyleBackColor = False
        '
        'BBioPago
        '
        Me.BBioPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BBioPago.BackColor = System.Drawing.Color.White
        Me.BBioPago.Image = CType(resources.GetObject("BBioPago.Image"), System.Drawing.Image)
        Me.BBioPago.Location = New System.Drawing.Point(827, 295)
        Me.BBioPago.Name = "BBioPago"
        Me.BBioPago.Size = New System.Drawing.Size(65, 63)
        Me.BBioPago.TabIndex = 1043
        Me.ToolTip1.SetToolTip(Me.BBioPago, "Bio-Pago.")
        Me.BBioPago.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.LDifMoneda)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(484, 602)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(186, 56)
        Me.GroupBox4.TabIndex = 1044
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Diferencia por Vueltos "
        Me.GroupBox4.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 24)
        Me.Label4.TabIndex = 1013
        Me.Label4.Text = "Bs."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LDifMoneda
        '
        Me.LDifMoneda.BackColor = System.Drawing.Color.White
        Me.LDifMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDifMoneda.ForeColor = System.Drawing.Color.Black
        Me.LDifMoneda.Location = New System.Drawing.Point(62, 16)
        Me.LDifMoneda.Name = "LDifMoneda"
        Me.LDifMoneda.Size = New System.Drawing.Size(117, 29)
        Me.LDifMoneda.TabIndex = 1017
        Me.LDifMoneda.Text = "0,00"
        Me.LDifMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BEliminar
        '
        Me.BEliminar.Image = CType(resources.GetObject("BEliminar.Image"), System.Drawing.Image)
        Me.BEliminar.Location = New System.Drawing.Point(0, 0)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(55, 52)
        Me.BEliminar.TabIndex = 1045
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'FControlCajaDesglose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(947, 679)
        Me.ControlBox = False
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BTransferencia)
        Me.Controls.Add(Me.BPagoMovil)
        Me.Controls.Add(Me.BTarjeta)
        Me.Controls.Add(Me.BOtros)
        Me.Controls.Add(Me.BDolar)
        Me.Controls.Add(Me.BCreditos)
        Me.Controls.Add(Me.BBioPago)
        Me.Controls.Add(Me.BEfectivo)
        Me.Controls.Add(Me.GridVentas)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.FechaCierre)
        Me.Controls.Add(Me.Fecha)
        Me.Name = "FControlCajaDesglose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Desglose."
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LTitulo As System.Windows.Forms.Label
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents FechaCierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents GridVentas As System.Windows.Forms.DataGridView
    Friend WithEvents BEfectivo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BDolar As System.Windows.Forms.Button
    Friend WithEvents BTransferencia As System.Windows.Forms.Button
    Friend WithEvents BTarjeta As System.Windows.Forms.Button
    Friend WithEvents BOtros As System.Windows.Forms.Button
    Friend WithEvents BPagoMovil As System.Windows.Forms.Button
    Friend WithEvents BCreditos As System.Windows.Forms.Button
    Friend WithEvents Num1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BBioPago As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodVentax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detalle As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LDifMoneda As System.Windows.Forms.Label
    Friend WithEvents BEliminar As System.Windows.Forms.Button
End Class
