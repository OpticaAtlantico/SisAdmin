<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBalanza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBalanza))
        Me.TPeso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.TEditarTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Etiqueta = New System.Windows.Forms.Button()
        Me.TStock = New System.Windows.Forms.TextBox()
        Me.BArtEjemplo = New System.Windows.Forms.PictureBox()
        Me.LArtEjemplo = New System.Windows.Forms.Label()
        Me.BTipoPrecio = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BExcepcion = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CUnidad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TPrecio = New System.Windows.Forms.TextBox()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.TSubTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TUnidadProd = New System.Windows.Forms.TextBox()
        Me.TCodDet = New System.Windows.Forms.TextBox()
        Me.TPrecioD = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TSubTotalD = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BPrecio10 = New System.Windows.Forms.Button()
        Me.BPrecio12 = New System.Windows.Forms.Button()
        Me.BPrecio11 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BPosVenta = New System.Windows.Forms.Button()
        Me.LSinDescuento = New System.Windows.Forms.Label()
        Me.TIVAD = New System.Windows.Forms.TextBox()
        Me.LIVAD = New System.Windows.Forms.Label()
        Me.TIVA = New System.Windows.Forms.TextBox()
        Me.LIVA = New System.Windows.Forms.Label()
        Me.TTotalD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBMayor = New System.Windows.Forms.RadioButton()
        Me.RBDetal = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBForanea = New System.Windows.Forms.RadioButton()
        Me.RBOnline = New System.Windows.Forms.RadioButton()
        Me.RBLocal = New System.Windows.Forms.RadioButton()
        Me.CBPosVenta = New System.Windows.Forms.CheckBox()
        Me.TPosVenta = New System.Windows.Forms.TextBox()
        Me.LCodigo = New System.Windows.Forms.Label()
        Me.CVendedor = New System.Windows.Forms.ComboBox()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.ImagenD = New System.Windows.Forms.PictureBox()
        Me.ImagenBs = New System.Windows.Forms.PictureBox()
        Me.MonedaBase = New System.Windows.Forms.PictureBox()
        CType(Me.BArtEjemplo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ImagenD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenBs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonedaBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TPeso
        '
        Me.TPeso.BackColor = System.Drawing.SystemColors.Info
        Me.TPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPeso.Location = New System.Drawing.Point(317, 82)
        Me.TPeso.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TPeso.Name = "TPeso"
        Me.TPeso.Size = New System.Drawing.Size(391, 38)
        Me.TPeso.TabIndex = 0
        Me.TPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(964, 504)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Salir"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(883, 504)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Aceptar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BSalir
        '
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.Location = New System.Drawing.Point(964, 429)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(73, 72)
        Me.BSalir.TabIndex = 2
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Image = CType(resources.GetObject("BAceptar.Image"), System.Drawing.Image)
        Me.BAceptar.Location = New System.Drawing.Point(883, 429)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(73, 72)
        Me.BAceptar.TabIndex = 1
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'TEditarTotal
        '
        Me.TEditarTotal.Location = New System.Drawing.Point(1142, 179)
        Me.TEditarTotal.Name = "TEditarTotal"
        Me.TEditarTotal.Size = New System.Drawing.Size(53, 26)
        Me.TEditarTotal.TabIndex = 19
        Me.TEditarTotal.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(1239, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Etiqueta"
        Me.Label1.Visible = False
        '
        'Etiqueta
        '
        Me.Etiqueta.Image = CType(resources.GetObject("Etiqueta.Image"), System.Drawing.Image)
        Me.Etiqueta.Location = New System.Drawing.Point(1230, 287)
        Me.Etiqueta.Name = "Etiqueta"
        Me.Etiqueta.Size = New System.Drawing.Size(73, 72)
        Me.Etiqueta.TabIndex = 20
        Me.Etiqueta.UseVisualStyleBackColor = True
        Me.Etiqueta.Visible = False
        '
        'TStock
        '
        Me.TStock.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStock.ForeColor = System.Drawing.Color.Navy
        Me.TStock.Location = New System.Drawing.Point(166, 44)
        Me.TStock.Name = "TStock"
        Me.TStock.ReadOnly = True
        Me.TStock.Size = New System.Drawing.Size(128, 26)
        Me.TStock.TabIndex = 145
        Me.TStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TStock.Visible = False
        '
        'BArtEjemplo
        '
        Me.BArtEjemplo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BArtEjemplo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BArtEjemplo.Location = New System.Drawing.Point(12, 82)
        Me.BArtEjemplo.Name = "BArtEjemplo"
        Me.BArtEjemplo.Size = New System.Drawing.Size(282, 235)
        Me.BArtEjemplo.TabIndex = 148
        Me.BArtEjemplo.TabStop = False
        '
        'LArtEjemplo
        '
        Me.LArtEjemplo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LArtEjemplo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LArtEjemplo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LArtEjemplo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LArtEjemplo.Location = New System.Drawing.Point(0, 0)
        Me.LArtEjemplo.Margin = New System.Windows.Forms.Padding(0)
        Me.LArtEjemplo.Name = "LArtEjemplo"
        Me.LArtEjemplo.Size = New System.Drawing.Size(1066, 36)
        Me.LArtEjemplo.TabIndex = 147
        Me.LArtEjemplo.Text = "Nombre"
        Me.LArtEjemplo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTipoPrecio
        '
        Me.BTipoPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTipoPrecio.ForeColor = System.Drawing.Color.Navy
        Me.BTipoPrecio.Image = CType(resources.GetObject("BTipoPrecio.Image"), System.Drawing.Image)
        Me.BTipoPrecio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTipoPrecio.Location = New System.Drawing.Point(9, 429)
        Me.BTipoPrecio.Name = "BTipoPrecio"
        Me.BTipoPrecio.Size = New System.Drawing.Size(86, 72)
        Me.BTipoPrecio.TabIndex = 149
        Me.BTipoPrecio.Text = "Precio 1"
        Me.BTipoPrecio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BTipoPrecio, "Tipos de Precios.")
        Me.BTipoPrecio.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(1158, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Excepción"
        Me.Label5.Visible = False
        '
        'BExcepcion
        '
        Me.BExcepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BExcepcion.ForeColor = System.Drawing.Color.Navy
        Me.BExcepcion.Image = CType(resources.GetObject("BExcepcion.Image"), System.Drawing.Image)
        Me.BExcepcion.Location = New System.Drawing.Point(1151, 287)
        Me.BExcepcion.Name = "BExcepcion"
        Me.BExcepcion.Size = New System.Drawing.Size(73, 72)
        Me.BExcepcion.TabIndex = 151
        Me.BExcepcion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BExcepcion.UseVisualStyleBackColor = True
        Me.BExcepcion.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(1146, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 26)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Unidad:"
        Me.Label6.Visible = False
        '
        'CUnidad
        '
        Me.CUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUnidad.FormattingEnabled = True
        Me.CUnidad.Location = New System.Drawing.Point(1151, 245)
        Me.CUnidad.Name = "CUnidad"
        Me.CUnidad.Size = New System.Drawing.Size(159, 39)
        Me.CUnidad.TabIndex = 208
        Me.CUnidad.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(528, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 211
        Me.Label7.Text = "P.V.P. Unidad:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TPrecio
        '
        Me.TPrecio.BackColor = System.Drawing.Color.Lavender
        Me.TPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPrecio.Location = New System.Drawing.Point(528, 159)
        Me.TPrecio.Name = "TPrecio"
        Me.TPrecio.ReadOnly = True
        Me.TPrecio.Size = New System.Drawing.Size(203, 29)
        Me.TPrecio.TabIndex = 210
        Me.TPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LCantidad
        '
        Me.LCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCantidad.ForeColor = System.Drawing.Color.Navy
        Me.LCantidad.Location = New System.Drawing.Point(317, 48)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(346, 34)
        Me.LCantidad.TabIndex = 214
        Me.LCantidad.Text = "Cantidad:"
        Me.LCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TSubTotal
        '
        Me.TSubTotal.BackColor = System.Drawing.Color.Lavender
        Me.TSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSubTotal.Location = New System.Drawing.Point(528, 227)
        Me.TSubTotal.Name = "TSubTotal"
        Me.TSubTotal.ReadOnly = True
        Me.TSubTotal.Size = New System.Drawing.Size(203, 29)
        Me.TSubTotal.TabIndex = 215
        Me.TSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(528, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 216
        Me.Label8.Text = "Sub-Total:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TUnidadProd
        '
        Me.TUnidadProd.Location = New System.Drawing.Point(1201, 179)
        Me.TUnidadProd.Name = "TUnidadProd"
        Me.TUnidadProd.Size = New System.Drawing.Size(54, 26)
        Me.TUnidadProd.TabIndex = 217
        Me.TUnidadProd.Visible = False
        '
        'TCodDet
        '
        Me.TCodDet.Location = New System.Drawing.Point(1261, 179)
        Me.TCodDet.Name = "TCodDet"
        Me.TCodDet.Size = New System.Drawing.Size(54, 26)
        Me.TCodDet.TabIndex = 218
        Me.TCodDet.Visible = False
        '
        'TPrecioD
        '
        Me.TPrecioD.BackColor = System.Drawing.Color.Honeydew
        Me.TPrecioD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPrecioD.Location = New System.Drawing.Point(317, 159)
        Me.TPrecioD.Name = "TPrecioD"
        Me.TPrecioD.ReadOnly = True
        Me.TPrecioD.Size = New System.Drawing.Size(203, 29)
        Me.TPrecioD.TabIndex = 219
        Me.TPrecioD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(317, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 20)
        Me.Label10.TabIndex = 220
        Me.Label10.Text = "P.V.P. Unidad $:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TSubTotalD
        '
        Me.TSubTotalD.BackColor = System.Drawing.Color.Honeydew
        Me.TSubTotalD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSubTotalD.Location = New System.Drawing.Point(317, 227)
        Me.TSubTotalD.Name = "TSubTotalD"
        Me.TSubTotalD.ReadOnly = True
        Me.TSubTotalD.Size = New System.Drawing.Size(203, 29)
        Me.TSubTotalD.TabIndex = 221
        Me.TSubTotalD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(317, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 20)
        Me.Label11.TabIndex = 222
        Me.Label11.Text = "Sub-Total $:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(1156, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 26)
        Me.Label9.TabIndex = 223
        Me.Label9.Text = "Stock:"
        Me.Label9.Visible = False
        '
        'BPrecio10
        '
        Me.BPrecio10.BackColor = System.Drawing.Color.Gainsboro
        Me.BPrecio10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPrecio10.ForeColor = System.Drawing.Color.Navy
        Me.BPrecio10.Image = CType(resources.GetObject("BPrecio10.Image"), System.Drawing.Image)
        Me.BPrecio10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BPrecio10.Location = New System.Drawing.Point(101, 429)
        Me.BPrecio10.Name = "BPrecio10"
        Me.BPrecio10.Size = New System.Drawing.Size(86, 72)
        Me.BPrecio10.TabIndex = 225
        Me.BPrecio10.Text = "M. Dañada"
        Me.BPrecio10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BPrecio10, "Mercancia Dañada.")
        Me.BPrecio10.UseVisualStyleBackColor = False
        '
        'BPrecio12
        '
        Me.BPrecio12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPrecio12.ForeColor = System.Drawing.Color.Navy
        Me.BPrecio12.Image = CType(resources.GetObject("BPrecio12.Image"), System.Drawing.Image)
        Me.BPrecio12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BPrecio12.Location = New System.Drawing.Point(193, 429)
        Me.BPrecio12.Name = "BPrecio12"
        Me.BPrecio12.Size = New System.Drawing.Size(86, 72)
        Me.BPrecio12.TabIndex = 227
        Me.BPrecio12.Text = "Comida I."
        Me.BPrecio12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BPrecio12, "Comida Interna.")
        Me.BPrecio12.UseVisualStyleBackColor = True
        '
        'BPrecio11
        '
        Me.BPrecio11.BackColor = System.Drawing.Color.Turquoise
        Me.BPrecio11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPrecio11.ForeColor = System.Drawing.Color.Navy
        Me.BPrecio11.Image = CType(resources.GetObject("BPrecio11.Image"), System.Drawing.Image)
        Me.BPrecio11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BPrecio11.Location = New System.Drawing.Point(285, 429)
        Me.BPrecio11.Name = "BPrecio11"
        Me.BPrecio11.Size = New System.Drawing.Size(86, 72)
        Me.BPrecio11.TabIndex = 229
        Me.BPrecio11.Text = "V. Normal"
        Me.BPrecio11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BPrecio11, "Venta Normal.")
        Me.BPrecio11.UseVisualStyleBackColor = False
        '
        'BPosVenta
        '
        Me.BPosVenta.BackgroundImage = CType(resources.GetObject("BPosVenta.BackgroundImage"), System.Drawing.Image)
        Me.BPosVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BPosVenta.Enabled = False
        Me.BPosVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPosVenta.ForeColor = System.Drawing.Color.Navy
        Me.BPosVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BPosVenta.Location = New System.Drawing.Point(787, 429)
        Me.BPosVenta.Name = "BPosVenta"
        Me.BPosVenta.Size = New System.Drawing.Size(73, 72)
        Me.BPosVenta.TabIndex = 248
        Me.ToolTip1.SetToolTip(Me.BPosVenta, "Pulse para Agregar Información de Post-Venta para este Producto.")
        Me.BPosVenta.UseVisualStyleBackColor = True
        '
        'LSinDescuento
        '
        Me.LSinDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSinDescuento.ForeColor = System.Drawing.Color.Navy
        Me.LSinDescuento.Location = New System.Drawing.Point(101, 442)
        Me.LSinDescuento.Name = "LSinDescuento"
        Me.LSinDescuento.Size = New System.Drawing.Size(419, 49)
        Me.LSinDescuento.TabIndex = 230
        Me.LSinDescuento.Text = "Producto Sin Descuento."
        Me.LSinDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LSinDescuento.Visible = False
        '
        'TIVAD
        '
        Me.TIVAD.BackColor = System.Drawing.Color.Honeydew
        Me.TIVAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIVAD.Location = New System.Drawing.Point(317, 291)
        Me.TIVAD.Name = "TIVAD"
        Me.TIVAD.ReadOnly = True
        Me.TIVAD.Size = New System.Drawing.Size(203, 29)
        Me.TIVAD.TabIndex = 238
        Me.TIVAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LIVAD
        '
        Me.LIVAD.AutoSize = True
        Me.LIVAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIVAD.ForeColor = System.Drawing.Color.Navy
        Me.LIVAD.Location = New System.Drawing.Point(317, 266)
        Me.LIVAD.Name = "LIVAD"
        Me.LIVAD.Size = New System.Drawing.Size(53, 20)
        Me.LIVAD.TabIndex = 239
        Me.LIVAD.Text = "IVA $:"
        Me.LIVAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TIVA
        '
        Me.TIVA.BackColor = System.Drawing.Color.Lavender
        Me.TIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIVA.Location = New System.Drawing.Point(528, 291)
        Me.TIVA.Name = "TIVA"
        Me.TIVA.ReadOnly = True
        Me.TIVA.Size = New System.Drawing.Size(203, 29)
        Me.TIVA.TabIndex = 236
        Me.TIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LIVA
        '
        Me.LIVA.AutoSize = True
        Me.LIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIVA.ForeColor = System.Drawing.Color.Navy
        Me.LIVA.Location = New System.Drawing.Point(528, 266)
        Me.LIVA.Name = "LIVA"
        Me.LIVA.Size = New System.Drawing.Size(40, 20)
        Me.LIVA.TabIndex = 237
        Me.LIVA.Text = "IVA:"
        Me.LIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TTotalD
        '
        Me.TTotalD.BackColor = System.Drawing.Color.Green
        Me.TTotalD.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTotalD.ForeColor = System.Drawing.Color.White
        Me.TTotalD.Location = New System.Drawing.Point(317, 367)
        Me.TTotalD.Name = "TTotalD"
        Me.TTotalD.ReadOnly = True
        Me.TTotalD.Size = New System.Drawing.Size(203, 45)
        Me.TTotalD.TabIndex = 242
        Me.TTotalD.Text = "0,00"
        Me.TTotalD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(317, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 26)
        Me.Label2.TabIndex = 243
        Me.Label2.Text = "P.V.P. Total $:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TTotal
        '
        Me.TTotal.BackColor = System.Drawing.Color.Blue
        Me.TTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTotal.ForeColor = System.Drawing.Color.White
        Me.TTotal.Location = New System.Drawing.Point(528, 367)
        Me.TTotal.Name = "TTotal"
        Me.TTotal.ReadOnly = True
        Me.TTotal.Size = New System.Drawing.Size(203, 45)
        Me.TTotal.TabIndex = 240
        Me.TTotal.Text = "0,00"
        Me.TTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(528, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 26)
        Me.Label12.TabIndex = 241
        Me.Label12.Text = "P.V.P Total Bs.:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LStock
        '
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.ForeColor = System.Drawing.Color.Navy
        Me.LStock.Location = New System.Drawing.Point(72, 46)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(88, 26)
        Me.LStock.TabIndex = 146
        Me.LStock.Text = "Stock:"
        Me.LStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LStock.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBMayor)
        Me.GroupBox1.Controls.Add(Me.RBDetal)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(748, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 108)
        Me.GroupBox1.TabIndex = 246
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Venta "
        '
        'RBMayor
        '
        Me.RBMayor.AutoSize = True
        Me.RBMayor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RBMayor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBMayor.Location = New System.Drawing.Point(158, 50)
        Me.RBMayor.Name = "RBMayor"
        Me.RBMayor.Size = New System.Drawing.Size(101, 29)
        Me.RBMayor.TabIndex = 247
        Me.RBMayor.Text = "Mayor:  "
        Me.RBMayor.UseVisualStyleBackColor = True
        '
        'RBDetal
        '
        Me.RBDetal.AutoSize = True
        Me.RBDetal.BackColor = System.Drawing.Color.Turquoise
        Me.RBDetal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RBDetal.Checked = True
        Me.RBDetal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBDetal.Location = New System.Drawing.Point(14, 50)
        Me.RBDetal.Name = "RBDetal"
        Me.RBDetal.Size = New System.Drawing.Size(101, 29)
        Me.RBDetal.TabIndex = 246
        Me.RBDetal.TabStop = True
        Me.RBDetal.Text = "Detal:    "
        Me.RBDetal.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBForanea)
        Me.GroupBox2.Controls.Add(Me.RBOnline)
        Me.GroupBox2.Controls.Add(Me.RBLocal)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(748, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 174)
        Me.GroupBox2.TabIndex = 247
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Despacho "
        '
        'RBForanea
        '
        Me.RBForanea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RBForanea.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBForanea.Location = New System.Drawing.Point(47, 119)
        Me.RBForanea.Name = "RBForanea"
        Me.RBForanea.Size = New System.Drawing.Size(167, 29)
        Me.RBForanea.TabIndex = 248
        Me.RBForanea.Text = "Foranea:"
        Me.RBForanea.UseVisualStyleBackColor = True
        Me.RBForanea.Visible = False
        '
        'RBOnline
        '
        Me.RBOnline.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RBOnline.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOnline.Location = New System.Drawing.Point(47, 84)
        Me.RBOnline.Name = "RBOnline"
        Me.RBOnline.Size = New System.Drawing.Size(167, 29)
        Me.RBOnline.TabIndex = 247
        Me.RBOnline.Text = "Online:"
        Me.RBOnline.UseVisualStyleBackColor = True
        '
        'RBLocal
        '
        Me.RBLocal.BackColor = System.Drawing.Color.Turquoise
        Me.RBLocal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RBLocal.Checked = True
        Me.RBLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBLocal.Location = New System.Drawing.Point(47, 49)
        Me.RBLocal.Name = "RBLocal"
        Me.RBLocal.Size = New System.Drawing.Size(167, 29)
        Me.RBLocal.TabIndex = 246
        Me.RBLocal.TabStop = True
        Me.RBLocal.Text = "Local: "
        Me.RBLocal.UseVisualStyleBackColor = False
        '
        'CBPosVenta
        '
        Me.CBPosVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPosVenta.Location = New System.Drawing.Point(787, 504)
        Me.CBPosVenta.Name = "CBPosVenta"
        Me.CBPosVenta.Size = New System.Drawing.Size(69, 20)
        Me.CBPosVenta.TabIndex = 0
        Me.CBPosVenta.Text = "Pos-Venta."
        Me.CBPosVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBPosVenta.UseVisualStyleBackColor = True
        '
        'TPosVenta
        '
        Me.TPosVenta.BackColor = System.Drawing.SystemColors.Info
        Me.TPosVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPosVenta.Location = New System.Drawing.Point(787, 395)
        Me.TPosVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TPosVenta.Name = "TPosVenta"
        Me.TPosVenta.Size = New System.Drawing.Size(73, 26)
        Me.TPosVenta.TabIndex = 249
        Me.TPosVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TPosVenta.Visible = False
        '
        'LCodigo
        '
        Me.LCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCodigo.Location = New System.Drawing.Point(850, 1)
        Me.LCodigo.Margin = New System.Windows.Forms.Padding(0)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(214, 34)
        Me.LCodigo.TabIndex = 250
        Me.LCodigo.Text = "0000000000"
        Me.LCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CVendedor
        '
        Me.CVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CVendedor.FormattingEnabled = True
        Me.CVendedor.ItemHeight = 20
        Me.CVendedor.Location = New System.Drawing.Point(12, 348)
        Me.CVendedor.Margin = New System.Windows.Forms.Padding(0)
        Me.CVendedor.Name = "CVendedor"
        Me.CVendedor.Size = New System.Drawing.Size(232, 28)
        Me.CVendedor.TabIndex = 251
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendedor.ForeColor = System.Drawing.Color.Navy
        Me.LVendedor.Location = New System.Drawing.Point(12, 323)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(79, 20)
        Me.LVendedor.TabIndex = 252
        Me.LVendedor.Text = "Vendedor"
        Me.LVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImagenD
        '
        Me.ImagenD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImagenD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImagenD.Image = CType(resources.GetObject("ImagenD.Image"), System.Drawing.Image)
        Me.ImagenD.Location = New System.Drawing.Point(652, 439)
        Me.ImagenD.Name = "ImagenD"
        Me.ImagenD.Size = New System.Drawing.Size(50, 50)
        Me.ImagenD.TabIndex = 711
        Me.ImagenD.TabStop = False
        Me.ImagenD.Visible = False
        '
        'ImagenBs
        '
        Me.ImagenBs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImagenBs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImagenBs.Image = CType(resources.GetObject("ImagenBs.Image"), System.Drawing.Image)
        Me.ImagenBs.Location = New System.Drawing.Point(583, 439)
        Me.ImagenBs.Name = "ImagenBs"
        Me.ImagenBs.Size = New System.Drawing.Size(50, 50)
        Me.ImagenBs.TabIndex = 710
        Me.ImagenBs.TabStop = False
        Me.ImagenBs.Visible = False
        '
        'MonedaBase
        '
        Me.MonedaBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MonedaBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MonedaBase.Image = CType(resources.GetObject("MonedaBase.Image"), System.Drawing.Image)
        Me.MonedaBase.Location = New System.Drawing.Point(261, 367)
        Me.MonedaBase.Name = "MonedaBase"
        Me.MonedaBase.Size = New System.Drawing.Size(50, 55)
        Me.MonedaBase.TabIndex = 712
        Me.MonedaBase.TabStop = False
        '
        'FBalanza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1066, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.MonedaBase)
        Me.Controls.Add(Me.ImagenD)
        Me.Controls.Add(Me.ImagenBs)
        Me.Controls.Add(Me.LStock)
        Me.Controls.Add(Me.CVendedor)
        Me.Controls.Add(Me.LCodigo)
        Me.Controls.Add(Me.TPosVenta)
        Me.Controls.Add(Me.BPosVenta)
        Me.Controls.Add(Me.CBPosVenta)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TTotalD)
        Me.Controls.Add(Me.TTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TIVAD)
        Me.Controls.Add(Me.LIVAD)
        Me.Controls.Add(Me.TIVA)
        Me.Controls.Add(Me.LIVA)
        Me.Controls.Add(Me.LSinDescuento)
        Me.Controls.Add(Me.BPrecio11)
        Me.Controls.Add(Me.BPrecio12)
        Me.Controls.Add(Me.BPrecio10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TSubTotalD)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TPrecioD)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TPrecio)
        Me.Controls.Add(Me.TPeso)
        Me.Controls.Add(Me.BArtEjemplo)
        Me.Controls.Add(Me.TCodDet)
        Me.Controls.Add(Me.TUnidadProd)
        Me.Controls.Add(Me.TSubTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BExcepcion)
        Me.Controls.Add(Me.BTipoPrecio)
        Me.Controls.Add(Me.LArtEjemplo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Etiqueta)
        Me.Controls.Add(Me.TEditarTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TStock)
        Me.Controls.Add(Me.CUnidad)
        Me.Controls.Add(Me.LCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LVendedor)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FBalanza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Venta."
        CType(Me.BArtEjemplo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ImagenD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenBs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonedaBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents TEditarTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Etiqueta As System.Windows.Forms.Button
    Friend WithEvents TStock As System.Windows.Forms.TextBox
    Friend WithEvents BArtEjemplo As System.Windows.Forms.PictureBox
    Friend WithEvents LArtEjemplo As System.Windows.Forms.Label
    Friend WithEvents BTipoPrecio As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BExcepcion As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TPrecio As System.Windows.Forms.TextBox
    Friend WithEvents LCantidad As System.Windows.Forms.Label
    Friend WithEvents TSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TUnidadProd As System.Windows.Forms.TextBox
    Friend WithEvents TCodDet As System.Windows.Forms.TextBox
    Friend WithEvents TPrecioD As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TSubTotalD As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BPrecio10 As System.Windows.Forms.Button
    Friend WithEvents BPrecio12 As System.Windows.Forms.Button
    Friend WithEvents BPrecio11 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LSinDescuento As System.Windows.Forms.Label
    Friend WithEvents TIVAD As System.Windows.Forms.TextBox
    Friend WithEvents LIVAD As System.Windows.Forms.Label
    Friend WithEvents TIVA As System.Windows.Forms.TextBox
    Friend WithEvents LIVA As System.Windows.Forms.Label
    Friend WithEvents TTotalD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LStock As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBMayor As System.Windows.Forms.RadioButton
    Friend WithEvents RBDetal As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBOnline As System.Windows.Forms.RadioButton
    Friend WithEvents RBLocal As System.Windows.Forms.RadioButton
    Friend WithEvents RBForanea As System.Windows.Forms.RadioButton
    Friend WithEvents CBPosVenta As System.Windows.Forms.CheckBox
    Friend WithEvents BPosVenta As System.Windows.Forms.Button
    Friend WithEvents TPosVenta As System.Windows.Forms.TextBox
    Friend WithEvents LCodigo As System.Windows.Forms.Label
    Friend WithEvents CVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents LVendedor As System.Windows.Forms.Label
    Friend WithEvents LTipoProd As System.Windows.Forms.Label
    Friend WithEvents ImagenD As System.Windows.Forms.PictureBox
    Friend WithEvents ImagenBs As System.Windows.Forms.PictureBox
    Friend WithEvents MonedaBase As System.Windows.Forms.PictureBox
End Class
