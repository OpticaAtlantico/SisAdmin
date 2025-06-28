<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRastreo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRastreo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.MCFecha = New System.Windows.Forms.MonthCalendar()
        Me.Ccondicion = New System.Windows.Forms.ComboBox()
        Me.GuardarRuta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LNumOrden = New System.Windows.Forms.Label()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LC = New System.Windows.Forms.Label()
        Me.AgregarRuta = New System.Windows.Forms.ToolStripButton()
        Me.LNO = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.EliminarRuta = New System.Windows.Forms.ToolStripButton()
        Me.TipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LCI = New System.Windows.Forms.Label()
        Me.idTipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_Datos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'MCFecha
        '
        Me.MCFecha.BackColor = System.Drawing.Color.Lavender
        Me.MCFecha.Location = New System.Drawing.Point(18, 253)
        Me.MCFecha.Name = "MCFecha"
        Me.MCFecha.TabIndex = 929
        Me.MCFecha.Visible = False
        '
        'Ccondicion
        '
        Me.Ccondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ccondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ccondicion.FormattingEnabled = True
        Me.Ccondicion.ItemHeight = 16
        Me.Ccondicion.Location = New System.Drawing.Point(407, 282)
        Me.Ccondicion.Margin = New System.Windows.Forms.Padding(0)
        Me.Ccondicion.Name = "Ccondicion"
        Me.Ccondicion.Size = New System.Drawing.Size(152, 24)
        Me.Ccondicion.TabIndex = 925
        Me.Ccondicion.Visible = False
        '
        'GuardarRuta
        '
        Me.GuardarRuta.AutoSize = False
        Me.GuardarRuta.ForeColor = System.Drawing.Color.Navy
        Me.GuardarRuta.Image = CType(resources.GetObject("GuardarRuta.Image"), System.Drawing.Image)
        Me.GuardarRuta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarRuta.Name = "GuardarRuta"
        Me.GuardarRuta.Size = New System.Drawing.Size(125, 100)
        Me.GuardarRuta.Text = " Guardar  Pago"
        Me.GuardarRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.GuardarRuta.ToolTipText = "Guardar Forma de Pago."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 100)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 100)
        '
        'LFecha
        '
        Me.LFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.Black
        Me.LFecha.Location = New System.Drawing.Point(1278, 39)
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
        Me.Label18.Location = New System.Drawing.Point(1150, 39)
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
        Me.LNumOrden.Location = New System.Drawing.Point(1278, 5)
        Me.LNumOrden.Name = "LNumOrden"
        Me.LNumOrden.Size = New System.Drawing.Size(140, 34)
        Me.LNumOrden.TabIndex = 224
        Me.LNumOrden.Text = "12345"
        Me.LNumOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 100)
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
        'AgregarRuta
        '
        Me.AgregarRuta.AutoSize = False
        Me.AgregarRuta.ForeColor = System.Drawing.Color.Navy
        Me.AgregarRuta.Image = CType(resources.GetObject("AgregarRuta.Image"), System.Drawing.Image)
        Me.AgregarRuta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AgregarRuta.Name = "AgregarRuta"
        Me.AgregarRuta.Size = New System.Drawing.Size(125, 100)
        Me.AgregarRuta.Text = "Agregar Pago"
        Me.AgregarRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AgregarRuta.ToolTipText = "Agregar Pago."
        '
        'LNO
        '
        Me.LNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNO.BackColor = System.Drawing.Color.Transparent
        Me.LNO.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNO.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LNO.Location = New System.Drawing.Point(1150, 5)
        Me.LNO.Name = "LNO"
        Me.LNO.Size = New System.Drawing.Size(132, 34)
        Me.LNO.TabIndex = 222
        Me.LNO.Text = "Orden Nº:"
        Me.LNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'id
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.id.DefaultCellStyle = DataGridViewCellStyle1
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.ToolTipText = "id"
        Me.id.Visible = False
        Me.id.Width = 120
        '
        'Observacion
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Observacion.DefaultCellStyle = DataGridViewCellStyle2
        Me.Observacion.HeaderText = "Observación."
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ToolTipText = "Observación."
        Me.Observacion.Width = 300
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarRuta, Me.EliminarRuta, Me.Salir, Me.ToolStripSeparator1, Me.GuardarRuta, Me.ToolStripSeparator4, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 76)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1429, 100)
        Me.ToolStrip1.TabIndex = 928
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'EliminarRuta
        '
        Me.EliminarRuta.AutoSize = False
        Me.EliminarRuta.ForeColor = System.Drawing.Color.Navy
        Me.EliminarRuta.Image = CType(resources.GetObject("EliminarRuta.Image"), System.Drawing.Image)
        Me.EliminarRuta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EliminarRuta.Name = "EliminarRuta"
        Me.EliminarRuta.Size = New System.Drawing.Size(125, 100)
        Me.EliminarRuta.Text = "Eliminar Pago"
        Me.EliminarRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.EliminarRuta.ToolTipText = "Eliminar Pago."
        '
        'TipoPago
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TipoPago.DefaultCellStyle = DataGridViewCellStyle3
        Me.TipoPago.HeaderText = "Tipo Pago"
        Me.TipoPago.Name = "TipoPago"
        Me.TipoPago.ReadOnly = True
        Me.TipoPago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TipoPago.ToolTipText = "Tipo Pago."
        Me.TipoPago.Width = 200
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
        Me.Panel2.Size = New System.Drawing.Size(1429, 76)
        Me.Panel2.TabIndex = 933
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
        'idTipoPago
        '
        Me.idTipoPago.HeaderText = "idTipoPago"
        Me.idTipoPago.Name = "idTipoPago"
        Me.idTipoPago.ReadOnly = True
        Me.idTipoPago.Visible = False
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
        'FechaPago
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaPago.DefaultCellStyle = DataGridViewCellStyle5
        Me.FechaPago.HeaderText = "Fecha Pago"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.ReadOnly = True
        Me.FechaPago.ToolTipText = "Fecha de Pago."
        Me.FechaPago.Width = 200
        '
        'Num
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Num.DefaultCellStyle = DataGridViewCellStyle6
        Me.Num.HeaderText = "Nº"
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        Me.Num.Width = 50
        '
        'dgv_Datos
        '
        Me.dgv_Datos.AllowUserToAddRows = False
        Me.dgv_Datos.AllowUserToDeleteRows = False
        Me.dgv_Datos.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Datos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Datos.ColumnHeadersHeight = 32
        Me.dgv_Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.FechaPago, Me.Monto, Me.idTipoPago, Me.TipoPago, Me.Observacion, Me.id})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Datos.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_Datos.EnableHeadersVisualStyles = False
        Me.dgv_Datos.Location = New System.Drawing.Point(0, 179)
        Me.dgv_Datos.Name = "dgv_Datos"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Datos.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_Datos.RowHeadersVisible = False
        Me.dgv_Datos.RowTemplate.Height = 26
        Me.dgv_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_Datos.Size = New System.Drawing.Size(1429, 492)
        Me.dgv_Datos.TabIndex = 924
        '
        'FRastreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1429, 671)
        Me.Controls.Add(Me.MCFecha)
        Me.Controls.Add(Me.Ccondicion)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgv_Datos)
        Me.Name = "FRastreo"
        Me.Text = "FRastreo"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Salir As ToolStripButton
    Friend WithEvents MCFecha As MonthCalendar
    Friend WithEvents Ccondicion As ComboBox
    Friend WithEvents GuardarRuta As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LFecha As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LCliente As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LNumOrden As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LC As Label
    Friend WithEvents AgregarRuta As ToolStripButton
    Friend WithEvents LNO As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Observacion As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents EliminarRuta As ToolStripButton
    Friend WithEvents TipoPago As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LCI As Label
    Friend WithEvents idTipoPago As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As DataGridViewTextBoxColumn
    Friend WithEvents Num As DataGridViewTextBoxColumn
    Friend WithEvents dgv_Datos As DataGridView
End Class
