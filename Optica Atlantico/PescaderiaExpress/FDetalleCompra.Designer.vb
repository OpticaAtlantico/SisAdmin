<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDetalleCompra
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FDetalleCompra))
        Me.DGVDetalle = New System.Windows.Forms.DataGridView()
        Me.Codigo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BSalir = New System.Windows.Forms.ToolStripButton()
        Me.LProveedor = New System.Windows.Forms.Label()
        Me.LProveedor1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LTotalD = New System.Windows.Forms.Label()
        Me.LTotalBs = New System.Windows.Forms.Label()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVDetalle
        '
        Me.DGVDetalle.AllowUserToAddRows = False
        Me.DGVDetalle.AllowUserToDeleteRows = False
        Me.DGVDetalle.AllowUserToResizeColumns = False
        Me.DGVDetalle.AllowUserToResizeRows = False
        Me.DGVDetalle.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVDetalle.ColumnHeadersHeight = 30
        Me.DGVDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo1, Me.Producto, Me.Peso, Me.Costo1, Me.CostoF, Me.PrecioD, Me.Precio, Me.TotalD, Me.Total1, Me.Observacion})
        Me.DGVDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVDetalle.EnableHeadersVisualStyles = False
        Me.DGVDetalle.Location = New System.Drawing.Point(0, 80)
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.ReadOnly = True
        Me.DGVDetalle.RowHeadersVisible = False
        Me.DGVDetalle.RowHeadersWidth = 45
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVDetalle.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DGVDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGVDetalle.Size = New System.Drawing.Size(1323, 662)
        Me.DGVDetalle.TabIndex = 231
        '
        'Codigo1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Codigo1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Codigo1.HeaderText = "Código"
        Me.Codigo1.Name = "Codigo1"
        Me.Codigo1.ReadOnly = True
        Me.Codigo1.ToolTipText = "Código."
        Me.Codigo1.Width = 80
        '
        'Producto
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Producto.DefaultCellStyle = DataGridViewCellStyle3
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.ToolTipText = "Producto."
        Me.Producto.Width = 200
        '
        'Peso
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle4
        Me.Peso.HeaderText = "Cantidad"
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        Me.Peso.ToolTipText = "Cantidad."
        '
        'Costo1
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Costo1.DefaultCellStyle = DataGridViewCellStyle5
        Me.Costo1.HeaderText = "Costo C. $"
        Me.Costo1.Name = "Costo1"
        Me.Costo1.ReadOnly = True
        Me.Costo1.ToolTipText = "Costo Calculado Dolar."
        Me.Costo1.Width = 120
        '
        'CostoF
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CostoF.DefaultCellStyle = DataGridViewCellStyle6
        Me.CostoF.HeaderText = "Costo C. Bs."
        Me.CostoF.Name = "CostoF"
        Me.CostoF.ReadOnly = True
        Me.CostoF.ToolTipText = "Costo Calculado Bolívares."
        Me.CostoF.Width = 120
        '
        'PrecioD
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PrecioD.DefaultCellStyle = DataGridViewCellStyle7
        Me.PrecioD.HeaderText = "Precio $"
        Me.PrecioD.Name = "PrecioD"
        Me.PrecioD.ReadOnly = True
        Me.PrecioD.ToolTipText = "Precio en Dolar."
        Me.PrecioD.Width = 120
        '
        'Precio
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle8
        Me.Precio.FillWeight = 120.0!
        Me.Precio.HeaderText = "Precio Bs."
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.ToolTipText = "Precio en Bolívares."
        Me.Precio.Width = 150
        '
        'TotalD
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TotalD.DefaultCellStyle = DataGridViewCellStyle9
        Me.TotalD.HeaderText = "Total $"
        Me.TotalD.Name = "TotalD"
        Me.TotalD.ReadOnly = True
        Me.TotalD.ToolTipText = "Total en Dolar."
        Me.TotalD.Width = 120
        '
        'Total1
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Total1.DefaultCellStyle = DataGridViewCellStyle10
        Me.Total1.FillWeight = 120.0!
        Me.Total1.HeaderText = "Total Bs."
        Me.Total1.Name = "Total1"
        Me.Total1.ReadOnly = True
        Me.Total1.ToolTipText = "Total en Bolívares."
        Me.Total1.Width = 120
        '
        'Observacion
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Observacion.DefaultCellStyle = DataGridViewCellStyle11
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.ToolTipText = "Observacion."
        Me.Observacion.Width = 180
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1323, 80)
        Me.ToolStrip1.TabIndex = 232
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BSalir
        '
        Me.BSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BSalir.ForeColor = System.Drawing.Color.Navy
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(52, 77)
        Me.BSalir.Text = "Salir"
        Me.BSalir.ToolTipText = "Salir."
        '
        'LProveedor
        '
        Me.LProveedor.AutoSize = True
        Me.LProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProveedor.ForeColor = System.Drawing.Color.Black
        Me.LProveedor.Location = New System.Drawing.Point(159, 29)
        Me.LProveedor.Name = "LProveedor"
        Me.LProveedor.Size = New System.Drawing.Size(132, 29)
        Me.LProveedor.TabIndex = 690
        Me.LProveedor.Text = "Proveedor:"
        '
        'LProveedor1
        '
        Me.LProveedor1.AutoSize = True
        Me.LProveedor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProveedor1.ForeColor = System.Drawing.Color.Navy
        Me.LProveedor1.Location = New System.Drawing.Point(21, 29)
        Me.LProveedor1.Name = "LProveedor1"
        Me.LProveedor1.Size = New System.Drawing.Size(132, 29)
        Me.LProveedor1.TabIndex = 710
        Me.LProveedor1.Text = "Proveedor:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.LTotalD)
        Me.Panel2.Controls.Add(Me.LTotalBs)
        Me.Panel2.Location = New System.Drawing.Point(834, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(406, 77)
        Me.Panel2.TabIndex = 762
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(12, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 32)
        Me.Label8.TabIndex = 707
        Me.Label8.Text = "Total $:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(12, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 32)
        Me.Label10.TabIndex = 705
        Me.Label10.Text = "Total Bs.:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LTotalD
        '
        Me.LTotalD.BackColor = System.Drawing.Color.Transparent
        Me.LTotalD.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalD.ForeColor = System.Drawing.Color.Green
        Me.LTotalD.Location = New System.Drawing.Point(139, 4)
        Me.LTotalD.Name = "LTotalD"
        Me.LTotalD.Size = New System.Drawing.Size(248, 32)
        Me.LTotalD.TabIndex = 726
        Me.LTotalD.Text = "0,00"
        Me.LTotalD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LTotalBs
        '
        Me.LTotalBs.BackColor = System.Drawing.Color.Transparent
        Me.LTotalBs.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalBs.ForeColor = System.Drawing.Color.MediumBlue
        Me.LTotalBs.Location = New System.Drawing.Point(139, 38)
        Me.LTotalBs.Name = "LTotalBs"
        Me.LTotalBs.Size = New System.Drawing.Size(248, 32)
        Me.LTotalBs.TabIndex = 722
        Me.LTotalBs.Text = "0,00"
        Me.LTotalBs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FDetalleCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1323, 742)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LProveedor1)
        Me.Controls.Add(Me.LProveedor)
        Me.Controls.Add(Me.DGVDetalle)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FDetalleCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Detalle de Compra."
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents LProveedor As System.Windows.Forms.Label
    Friend WithEvents Codigo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Peso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LProveedor1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LTotalD As System.Windows.Forms.Label
    Friend WithEvents LTotalBs As System.Windows.Forms.Label
End Class
