<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesGridRango
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportesGridRango))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.COpto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BSiguiente = New System.Windows.Forms.Button()
        Me.BAnterior = New System.Windows.Forms.Button()
        Me.Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Desde = New System.Windows.Forms.DateTimePicker()
        Me.BListado = New System.Windows.Forms.Button()
        Me.TDesde = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.COpto)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.BSiguiente)
        Me.Panel2.Controls.Add(Me.BAnterior)
        Me.Panel2.Controls.Add(Me.Hasta)
        Me.Panel2.Controls.Add(Me.Desde)
        Me.Panel2.Controls.Add(Me.BListado)
        Me.Panel2.Controls.Add(Me.TDesde)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label45)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1224, 121)
        Me.Panel2.TabIndex = 923
        '
        'COpto
        '
        Me.COpto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.COpto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.COpto.BackColor = System.Drawing.Color.White
        Me.COpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COpto.FormattingEnabled = True
        Me.COpto.ItemHeight = 18
        Me.COpto.Location = New System.Drawing.Point(379, 51)
        Me.COpto.Margin = New System.Windows.Forms.Padding(0)
        Me.COpto.Name = "COpto"
        Me.COpto.Size = New System.Drawing.Size(301, 26)
        Me.COpto.TabIndex = 924
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(379, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(301, 24)
        Me.Label7.TabIndex = 923
        Me.Label7.Text = "Seleccione el Tipo de Reporte:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BSiguiente
        '
        Me.BSiguiente.BackColor = System.Drawing.Color.White
        Me.BSiguiente.BackgroundImage = CType(resources.GetObject("BSiguiente.BackgroundImage"), System.Drawing.Image)
        Me.BSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BSiguiente.CausesValidation = False
        Me.BSiguiente.Location = New System.Drawing.Point(175, 5)
        Me.BSiguiente.Name = "BSiguiente"
        Me.BSiguiente.Size = New System.Drawing.Size(35, 112)
        Me.BSiguiente.TabIndex = 922
        Me.BSiguiente.UseVisualStyleBackColor = False
        '
        'BAnterior
        '
        Me.BAnterior.BackColor = System.Drawing.Color.White
        Me.BAnterior.BackgroundImage = CType(resources.GetObject("BAnterior.BackgroundImage"), System.Drawing.Image)
        Me.BAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BAnterior.CausesValidation = False
        Me.BAnterior.Location = New System.Drawing.Point(5, 5)
        Me.BAnterior.Name = "BAnterior"
        Me.BAnterior.Size = New System.Drawing.Size(35, 112)
        Me.BAnterior.TabIndex = 921
        Me.BAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAnterior.UseVisualStyleBackColor = False
        '
        'Hasta
        '
        Me.Hasta.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.Hasta.CustomFormat = "dd/MM/yyyy"
        Me.Hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Hasta.Location = New System.Drawing.Point(49, 72)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Size = New System.Drawing.Size(119, 26)
        Me.Hasta.TabIndex = 210
        Me.Hasta.Value = New Date(2015, 10, 1, 0, 0, 0, 0)
        '
        'Desde
        '
        Me.Desde.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.Desde.CustomFormat = "dd/MM/yyyy"
        Me.Desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Desde.Location = New System.Drawing.Point(49, 22)
        Me.Desde.Name = "Desde"
        Me.Desde.Size = New System.Drawing.Size(119, 26)
        Me.Desde.TabIndex = 208
        Me.Desde.Value = New Date(2015, 10, 1, 0, 0, 0, 0)
        '
        'BListado
        '
        Me.BListado.BackColor = System.Drawing.Color.Transparent
        Me.BListado.BackgroundImage = CType(resources.GetObject("BListado.BackgroundImage"), System.Drawing.Image)
        Me.BListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BListado.Location = New System.Drawing.Point(252, 9)
        Me.BListado.Name = "BListado"
        Me.BListado.Size = New System.Drawing.Size(88, 86)
        Me.BListado.TabIndex = 213
        Me.BListado.UseVisualStyleBackColor = False
        '
        'TDesde
        '
        Me.TDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesde.ForeColor = System.Drawing.Color.Navy
        Me.TDesde.Location = New System.Drawing.Point(49, 3)
        Me.TDesde.Name = "TDesde"
        Me.TDesde.Size = New System.Drawing.Size(119, 20)
        Me.TDesde.TabIndex = 209
        Me.TDesde.Text = "Desde:"
        Me.TDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(49, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "Hasta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(240, 89)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(109, 25)
        Me.Label45.TabIndex = 918
        Me.Label45.Text = "Actualizar Busqueda"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 121)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1224, 628)
        Me.TabControl1.TabIndex = 924
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Grid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1216, 602)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reporte General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.ColumnHeadersHeight = 32
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Codigo, Me.Articulo, Me.Stock, Me.Cantidad, Me.PrecioUnidad, Me.Total, Me.Observacion})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.Location = New System.Drawing.Point(3, 3)
        Me.Grid.Name = "Grid"
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Grid.RowHeadersVisible = False
        Me.Grid.RowHeadersWidth = 30
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Grid.RowTemplate.Height = 27
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Grid.Size = New System.Drawing.Size(1210, 596)
        Me.Grid.TabIndex = 750
        '
        'Item
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Item.DefaultCellStyle = DataGridViewCellStyle2
        Me.Item.HeaderText = "Nº"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.ToolTipText = "Nùmero."
        Me.Item.Width = 60
        '
        'Codigo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Codigo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.ToolTipText = "Código."
        Me.Codigo.Width = 120
        '
        'Articulo
        '
        Me.Articulo.HeaderText = "Descripción"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        Me.Articulo.ToolTipText = "Descripción o Nombre del Producto."
        Me.Articulo.Width = 300
        '
        'Stock
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Stock.DefaultCellStyle = DataGridViewCellStyle4
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        Me.Stock.ToolTipText = "Stock."
        Me.Stock.Visible = False
        Me.Stock.Width = 80
        '
        'Cantidad
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ToolTipText = "Cantidad."
        '
        'PrecioUnidad
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PrecioUnidad.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrecioUnidad.HeaderText = "Precio Unidad"
        Me.PrecioUnidad.Name = "PrecioUnidad"
        Me.PrecioUnidad.ReadOnly = True
        Me.PrecioUnidad.ToolTipText = "Precio de la Unidad."
        Me.PrecioUnidad.Width = 150
        '
        'Total
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Total.DefaultCellStyle = DataGridViewCellStyle7
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.ToolTipText = "Total."
        Me.Total.Width = 150
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.ToolTipText = "Observación."
        Me.Observacion.Width = 170
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1216, 624)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportesGridRango
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1224, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ReportesGridRango"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportesGridRango"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents COpto As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BSiguiente As System.Windows.Forms.Button
    Friend WithEvents BAnterior As System.Windows.Forms.Button
    Friend WithEvents Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents BListado As System.Windows.Forms.Button
    Friend WithEvents TDesde As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
