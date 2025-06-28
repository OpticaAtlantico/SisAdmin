<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProducto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Dialogo = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BBuscarProd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NuevoProd = New System.Windows.Forms.ToolStripButton()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BCategorias = New System.Windows.Forms.ToolStripButton()
        Me.BSubCategorias = New System.Windows.Forms.ToolStripButton()
        Me.BMarcas = New System.Windows.Forms.ToolStripButton()
        Me.Tab_Precio = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TCostoD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.BIVAC = New System.Windows.Forms.Button()
        Me.TIVAV = New System.Windows.Forms.TextBox()
        Me.TIVAC = New System.Windows.Forms.TextBox()
        Me.BIVAV = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PrecioDescuentoCI = New System.Windows.Forms.TextBox()
        Me.PrecioDescuento = New System.Windows.Forms.TextBox()
        Me.PrecioMDCI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrecioMD = New System.Windows.Forms.TextBox()
        Me.Precio1DCI = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Precio1D = New System.Windows.Forms.TextBox()
        Me.TipoMoneda = New System.Windows.Forms.Label()
        Me.Tab_Existencia = New System.Windows.Forms.TabPage()
        Me.TExistenciaMax = New System.Windows.Forms.TextBox()
        Me.TStock = New System.Windows.Forms.TextBox()
        Me.TExistenciaMin = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Tab_Proveedor = New System.Windows.Forms.TabPage()
        Me.DGVProveedor = New System.Windows.Forms.DataGridView()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tab_General = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CProdNac = New System.Windows.Forms.ComboBox()
        Me.CMarca = New System.Windows.Forms.ComboBox()
        Me.CSubCategoria = New System.Windows.Forms.ComboBox()
        Me.CCategoria = New System.Windows.Forms.ComboBox()
        Me.PBAuxImagen = New System.Windows.Forms.PictureBox()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.TModelo = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BCodBarra = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TGarantia = New System.Windows.Forms.TextBox()
        Me.TObservacion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BQuitar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.CBActivo = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FechaC = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPrincipal = New System.Windows.Forms.TabControl()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DialogoFuente = New System.Windows.Forms.FontDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.Tab_Precio.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Tab_Existencia.SuspendLayout()
        Me.Tab_Proveedor.SuspendLayout()
        CType(Me.DGVProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_General.SuspendLayout()
        CType(Me.PBAuxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPrincipal.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dialogo
        '
        Me.Dialogo.FileName = "SinImagen"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BBuscarProd, Me.ToolStripSeparator1, Me.NuevoProd, Me.Guardar, Me.Eliminar, Me.Salir, Me.ToolStripSeparator3, Me.BCategorias, Me.BSubCategorias, Me.BMarcas})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1292, 73)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BBuscarProd
        '
        Me.BBuscarProd.ForeColor = System.Drawing.Color.Navy
        Me.BBuscarProd.Image = CType(resources.GetObject("BBuscarProd.Image"), System.Drawing.Image)
        Me.BBuscarProd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BBuscarProd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BBuscarProd.Name = "BBuscarProd"
        Me.BBuscarProd.Size = New System.Drawing.Size(89, 70)
        Me.BBuscarProd.Text = "Buscar Prod.    "
        Me.BBuscarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BBuscarProd.ToolTipText = "Guardar."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 73)
        '
        'NuevoProd
        '
        Me.NuevoProd.AutoSize = False
        Me.NuevoProd.ForeColor = System.Drawing.Color.Navy
        Me.NuevoProd.Image = CType(resources.GetObject("NuevoProd.Image"), System.Drawing.Image)
        Me.NuevoProd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NuevoProd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoProd.Name = "NuevoProd"
        Me.NuevoProd.Size = New System.Drawing.Size(100, 70)
        Me.NuevoProd.Text = "  Nuevo Prod.  "
        Me.NuevoProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.NuevoProd.ToolTipText = "Crear Nuevo Producto."
        '
        'Guardar
        '
        Me.Guardar.ForeColor = System.Drawing.Color.Navy
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(83, 70)
        Me.Guardar.Text = "     Guardar     "
        Me.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Guardar.ToolTipText = "Guardar."
        '
        'Eliminar
        '
        Me.Eliminar.AutoSize = False
        Me.Eliminar.ForeColor = System.Drawing.Color.Navy
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(100, 70)
        Me.Eliminar.Text = "     Eliminar     "
        Me.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Eliminar.ToolTipText = "Eliminar."
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.AutoSize = False
        Me.Salir.ForeColor = System.Drawing.Color.Navy
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(100, 70)
        Me.Salir.Text = "     Salir     "
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Salir.ToolTipText = "Salir."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 73)
        '
        'BCategorias
        '
        Me.BCategorias.AutoSize = False
        Me.BCategorias.ForeColor = System.Drawing.Color.Navy
        Me.BCategorias.Image = CType(resources.GetObject("BCategorias.Image"), System.Drawing.Image)
        Me.BCategorias.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BCategorias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BCategorias.Name = "BCategorias"
        Me.BCategorias.Size = New System.Drawing.Size(100, 70)
        Me.BCategorias.Text = "    Categorias    "
        Me.BCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BCategorias.ToolTipText = "Categorias."
        '
        'BSubCategorias
        '
        Me.BSubCategorias.AutoSize = False
        Me.BSubCategorias.ForeColor = System.Drawing.Color.Navy
        Me.BSubCategorias.Image = CType(resources.GetObject("BSubCategorias.Image"), System.Drawing.Image)
        Me.BSubCategorias.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BSubCategorias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BSubCategorias.Name = "BSubCategorias"
        Me.BSubCategorias.Size = New System.Drawing.Size(100, 70)
        Me.BSubCategorias.Text = "Sub-Categorias"
        Me.BSubCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BSubCategorias.ToolTipText = "Sub-Categorias."
        '
        'BMarcas
        '
        Me.BMarcas.ForeColor = System.Drawing.Color.Navy
        Me.BMarcas.Image = CType(resources.GetObject("BMarcas.Image"), System.Drawing.Image)
        Me.BMarcas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BMarcas.Name = "BMarcas"
        Me.BMarcas.Size = New System.Drawing.Size(79, 70)
        Me.BMarcas.Text = "     Marcas     "
        Me.BMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BMarcas.ToolTipText = "Eliminar."
        '
        'Tab_Precio
        '
        Me.Tab_Precio.BackColor = System.Drawing.Color.White
        Me.Tab_Precio.Controls.Add(Me.GroupBox1)
        Me.Tab_Precio.Controls.Add(Me.GroupBox2)
        Me.Tab_Precio.Controls.Add(Me.GroupBox3)
        Me.Tab_Precio.Location = New System.Drawing.Point(4, 29)
        Me.Tab_Precio.Name = "Tab_Precio"
        Me.Tab_Precio.Size = New System.Drawing.Size(1284, 564)
        Me.Tab_Precio.TabIndex = 1
        Me.Tab_Precio.Text = "Precios e Impuestos                        "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TCostoD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 147)
        Me.GroupBox1.TabIndex = 221
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costo:"
        '
        'TCostoD
        '
        Me.TCostoD.BackColor = System.Drawing.Color.Gainsboro
        Me.TCostoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCostoD.ForeColor = System.Drawing.Color.Black
        Me.TCostoD.Location = New System.Drawing.Point(63, 69)
        Me.TCostoD.Name = "TCostoD"
        Me.TCostoD.ReadOnly = True
        Me.TCostoD.Size = New System.Drawing.Size(150, 26)
        Me.TCostoD.TabIndex = 151
        Me.TCostoD.Text = "0"
        Me.TCostoD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(63, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 220
        Me.Label3.Text = "Costo Actual"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.BIVAC)
        Me.GroupBox2.Controls.Add(Me.TIVAV)
        Me.GroupBox2.Controls.Add(Me.TIVAC)
        Me.GroupBox2.Controls.Add(Me.BIVAV)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(321, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 147)
        Me.GroupBox2.TabIndex = 150
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Impuestos:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(35, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 731
        Me.Label5.Text = "IVA Venta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(35, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 730
        Me.Label4.Text = "IVA Compra:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(219, 91)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(38, 26)
        Me.Label29.TabIndex = 729
        Me.Label29.Text = "%"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(219, 46)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(38, 26)
        Me.Label28.TabIndex = 726
        Me.Label28.Text = "%"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BIVAC
        '
        Me.BIVAC.BackColor = System.Drawing.Color.LightCyan
        Me.BIVAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BIVAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BIVAC.Location = New System.Drawing.Point(267, 46)
        Me.BIVAC.Name = "BIVAC"
        Me.BIVAC.Size = New System.Drawing.Size(76, 26)
        Me.BIVAC.TabIndex = 683
        Me.BIVAC.Text = "% IVA C."
        Me.ToolTip1.SetToolTip(Me.BIVAC, "% IVA para la Compra.")
        Me.BIVAC.UseVisualStyleBackColor = False
        '
        'TIVAV
        '
        Me.TIVAV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TIVAV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIVAV.ForeColor = System.Drawing.Color.Black
        Me.TIVAV.Location = New System.Drawing.Point(137, 91)
        Me.TIVAV.Name = "TIVAV"
        Me.TIVAV.ReadOnly = True
        Me.TIVAV.Size = New System.Drawing.Size(76, 26)
        Me.TIVAV.TabIndex = 686
        Me.TIVAV.Tag = "0"
        Me.TIVAV.Text = "0"
        Me.TIVAV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TIVAC
        '
        Me.TIVAC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TIVAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIVAC.ForeColor = System.Drawing.Color.Black
        Me.TIVAC.Location = New System.Drawing.Point(137, 46)
        Me.TIVAC.Name = "TIVAC"
        Me.TIVAC.ReadOnly = True
        Me.TIVAC.Size = New System.Drawing.Size(76, 26)
        Me.TIVAC.TabIndex = 685
        Me.TIVAC.Tag = "0"
        Me.TIVAC.Text = "0"
        Me.TIVAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BIVAV
        '
        Me.BIVAV.BackColor = System.Drawing.Color.LightCyan
        Me.BIVAV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BIVAV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BIVAV.Location = New System.Drawing.Point(267, 91)
        Me.BIVAV.Name = "BIVAV"
        Me.BIVAV.Size = New System.Drawing.Size(76, 26)
        Me.BIVAV.TabIndex = 684
        Me.BIVAV.Text = "% IVA V."
        Me.ToolTip1.SetToolTip(Me.BIVAV, "% IVA para la Venta.")
        Me.BIVAV.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.PrecioDescuentoCI)
        Me.GroupBox3.Controls.Add(Me.PrecioDescuento)
        Me.GroupBox3.Controls.Add(Me.PrecioMDCI)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.PrecioMD)
        Me.GroupBox3.Controls.Add(Me.Precio1DCI)
        Me.GroupBox3.Controls.Add(Me.Label56)
        Me.GroupBox3.Controls.Add(Me.Precio1D)
        Me.GroupBox3.Controls.Add(Me.TipoMoneda)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(28, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(678, 192)
        Me.GroupBox3.TabIndex = 219
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Precios "
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(403, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 26)
        Me.Label7.TabIndex = 292
        Me.Label7.Text = "Con Impuesto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(48, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 24)
        Me.Label9.TabIndex = 291
        Me.Label9.Text = "Precio Descuento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrecioDescuentoCI
        '
        Me.PrecioDescuentoCI.BackColor = System.Drawing.Color.Gainsboro
        Me.PrecioDescuentoCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioDescuentoCI.ForeColor = System.Drawing.Color.Black
        Me.PrecioDescuentoCI.Location = New System.Drawing.Point(403, 135)
        Me.PrecioDescuentoCI.Name = "PrecioDescuentoCI"
        Me.PrecioDescuentoCI.ReadOnly = True
        Me.PrecioDescuentoCI.Size = New System.Drawing.Size(192, 26)
        Me.PrecioDescuentoCI.TabIndex = 290
        Me.PrecioDescuentoCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrecioDescuento
        '
        Me.PrecioDescuento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PrecioDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioDescuento.ForeColor = System.Drawing.Color.Black
        Me.PrecioDescuento.Location = New System.Drawing.Point(205, 136)
        Me.PrecioDescuento.Name = "PrecioDescuento"
        Me.PrecioDescuento.Size = New System.Drawing.Size(192, 26)
        Me.PrecioDescuento.TabIndex = 289
        Me.PrecioDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrecioMDCI
        '
        Me.PrecioMDCI.BackColor = System.Drawing.Color.Gainsboro
        Me.PrecioMDCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioMDCI.ForeColor = System.Drawing.Color.Black
        Me.PrecioMDCI.Location = New System.Drawing.Point(403, 102)
        Me.PrecioMDCI.Name = "PrecioMDCI"
        Me.PrecioMDCI.ReadOnly = True
        Me.PrecioMDCI.Size = New System.Drawing.Size(192, 26)
        Me.PrecioMDCI.TabIndex = 284
        Me.PrecioMDCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(46, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 24)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Precio Mayor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrecioMD
        '
        Me.PrecioMD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PrecioMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioMD.ForeColor = System.Drawing.Color.Black
        Me.PrecioMD.Location = New System.Drawing.Point(205, 103)
        Me.PrecioMD.Name = "PrecioMD"
        Me.PrecioMD.Size = New System.Drawing.Size(192, 26)
        Me.PrecioMD.TabIndex = 283
        Me.PrecioMD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Precio1DCI
        '
        Me.Precio1DCI.BackColor = System.Drawing.Color.Gainsboro
        Me.Precio1DCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio1DCI.ForeColor = System.Drawing.Color.Black
        Me.Precio1DCI.Location = New System.Drawing.Point(403, 69)
        Me.Precio1DCI.Name = "Precio1DCI"
        Me.Precio1DCI.ReadOnly = True
        Me.Precio1DCI.Size = New System.Drawing.Size(192, 26)
        Me.Precio1DCI.TabIndex = 270
        Me.Precio1DCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Navy
        Me.Label56.Location = New System.Drawing.Point(113, 70)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(89, 24)
        Me.Label56.TabIndex = 224
        Me.Label56.Text = "Precio:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Precio1D
        '
        Me.Precio1D.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Precio1D.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio1D.ForeColor = System.Drawing.Color.Black
        Me.Precio1D.Location = New System.Drawing.Point(205, 70)
        Me.Precio1D.Name = "Precio1D"
        Me.Precio1D.Size = New System.Drawing.Size(192, 26)
        Me.Precio1D.TabIndex = 261
        Me.Precio1D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TipoMoneda
        '
        Me.TipoMoneda.BackColor = System.Drawing.Color.Silver
        Me.TipoMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoMoneda.ForeColor = System.Drawing.Color.White
        Me.TipoMoneda.Location = New System.Drawing.Point(205, 35)
        Me.TipoMoneda.Name = "TipoMoneda"
        Me.TipoMoneda.Size = New System.Drawing.Size(192, 26)
        Me.TipoMoneda.TabIndex = 223
        Me.TipoMoneda.Text = "Sin Impuesto"
        Me.TipoMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tab_Existencia
        '
        Me.Tab_Existencia.BackColor = System.Drawing.Color.White
        Me.Tab_Existencia.Controls.Add(Me.TExistenciaMax)
        Me.Tab_Existencia.Controls.Add(Me.TStock)
        Me.Tab_Existencia.Controls.Add(Me.TExistenciaMin)
        Me.Tab_Existencia.Controls.Add(Me.Label45)
        Me.Tab_Existencia.Controls.Add(Me.Label43)
        Me.Tab_Existencia.Controls.Add(Me.Label42)
        Me.Tab_Existencia.Location = New System.Drawing.Point(4, 29)
        Me.Tab_Existencia.Name = "Tab_Existencia"
        Me.Tab_Existencia.Size = New System.Drawing.Size(1284, 564)
        Me.Tab_Existencia.TabIndex = 4
        Me.Tab_Existencia.Text = "Existencia                              "
        '
        'TExistenciaMax
        '
        Me.TExistenciaMax.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TExistenciaMax.Location = New System.Drawing.Point(43, 207)
        Me.TExistenciaMax.Name = "TExistenciaMax"
        Me.TExistenciaMax.Size = New System.Drawing.Size(175, 26)
        Me.TExistenciaMax.TabIndex = 36
        Me.TExistenciaMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TStock
        '
        Me.TStock.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TStock.Location = New System.Drawing.Point(43, 63)
        Me.TStock.Name = "TStock"
        Me.TStock.ReadOnly = True
        Me.TStock.Size = New System.Drawing.Size(175, 26)
        Me.TStock.TabIndex = 39
        Me.TStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TExistenciaMin
        '
        Me.TExistenciaMin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TExistenciaMin.Location = New System.Drawing.Point(43, 135)
        Me.TExistenciaMin.Name = "TExistenciaMin"
        Me.TExistenciaMin.Size = New System.Drawing.Size(175, 26)
        Me.TExistenciaMin.TabIndex = 35
        Me.TExistenciaMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(43, 39)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(175, 26)
        Me.Label45.TabIndex = 41
        Me.Label45.Text = "Stock:"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(43, 111)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(175, 26)
        Me.Label43.TabIndex = 37
        Me.Label43.Text = "Existencia Mínima:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(43, 183)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(175, 26)
        Me.Label42.TabIndex = 38
        Me.Label42.Text = "Existencia Máxima:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab_Proveedor
        '
        Me.Tab_Proveedor.BackColor = System.Drawing.Color.White
        Me.Tab_Proveedor.Controls.Add(Me.DGVProveedor)
        Me.Tab_Proveedor.Location = New System.Drawing.Point(4, 29)
        Me.Tab_Proveedor.Name = "Tab_Proveedor"
        Me.Tab_Proveedor.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Proveedor.Size = New System.Drawing.Size(1284, 564)
        Me.Tab_Proveedor.TabIndex = 3
        Me.Tab_Proveedor.Text = "Proveedores                    "
        '
        'DGVProveedor
        '
        Me.DGVProveedor.AllowUserToAddRows = False
        Me.DGVProveedor.AllowUserToDeleteRows = False
        Me.DGVProveedor.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVProveedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVProveedor.ColumnHeadersHeight = 28
        Me.DGVProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Documento, Me.Codigo, Me.Producto, Me.Proveedor, Me.Fecha, Me.Cantidad, Me.CostoD, Me.Costo, Me.TotalD, Me.Total})
        Me.DGVProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVProveedor.EnableHeadersVisualStyles = False
        Me.DGVProveedor.Location = New System.Drawing.Point(3, 3)
        Me.DGVProveedor.Name = "DGVProveedor"
        Me.DGVProveedor.ReadOnly = True
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVProveedor.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DGVProveedor.RowHeadersVisible = False
        Me.DGVProveedor.RowTemplate.Height = 25
        Me.DGVProveedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProveedor.Size = New System.Drawing.Size(1278, 558)
        Me.DGVProveedor.TabIndex = 0
        '
        'Documento
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Documento.DefaultCellStyle = DataGridViewCellStyle2
        Me.Documento.HeaderText = "N° Doc."
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        Me.Documento.ToolTipText = "Número de Documento."
        '
        'Codigo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Codigo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 90
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 180
        '
        'Proveedor
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Proveedor.DefaultCellStyle = DataGridViewCellStyle4
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.ToolTipText = "Proveedor."
        Me.Proveedor.Width = 230
        '
        'Fecha
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle5
        Me.Fecha.HeaderText = "Fecha C."
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Fecha.ToolTipText = "Fecha Compra."
        Me.Fecha.Width = 120
        '
        'Cantidad
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle6
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.ToolTipText = "Cantidad."
        Me.Cantidad.Width = 60
        '
        'CostoD
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CostoD.DefaultCellStyle = DataGridViewCellStyle7
        Me.CostoD.HeaderText = "Costo $"
        Me.CostoD.Name = "CostoD"
        Me.CostoD.ReadOnly = True
        Me.CostoD.ToolTipText = "Costo $ en Factura."
        Me.CostoD.Width = 110
        '
        'Costo
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Costo.DefaultCellStyle = DataGridViewCellStyle8
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.ToolTipText = "Costo Bs. en Factura."
        Me.Costo.Width = 110
        '
        'TotalD
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TotalD.DefaultCellStyle = DataGridViewCellStyle9
        Me.TotalD.HeaderText = "Total $"
        Me.TotalD.Name = "TotalD"
        Me.TotalD.ReadOnly = True
        Me.TotalD.Width = 130
        '
        'Total
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Total.DefaultCellStyle = DataGridViewCellStyle10
        Me.Total.HeaderText = "Total Bs."
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 130
        '
        'Tab_General
        '
        Me.Tab_General.BackColor = System.Drawing.Color.White
        Me.Tab_General.Controls.Add(Me.Label1)
        Me.Tab_General.Controls.Add(Me.Label2)
        Me.Tab_General.Controls.Add(Me.CProdNac)
        Me.Tab_General.Controls.Add(Me.CMarca)
        Me.Tab_General.Controls.Add(Me.CSubCategoria)
        Me.Tab_General.Controls.Add(Me.CCategoria)
        Me.Tab_General.Controls.Add(Me.PBAuxImagen)
        Me.Tab_General.Controls.Add(Me.Imagen)
        Me.Tab_General.Controls.Add(Me.Label40)
        Me.Tab_General.Controls.Add(Me.Label57)
        Me.Tab_General.Controls.Add(Me.Label60)
        Me.Tab_General.Controls.Add(Me.Label41)
        Me.Tab_General.Controls.Add(Me.Label90)
        Me.Tab_General.Controls.Add(Me.TModelo)
        Me.Tab_General.Controls.Add(Me.Label88)
        Me.Tab_General.Controls.Add(Me.Label89)
        Me.Tab_General.Controls.Add(Me.Label23)
        Me.Tab_General.Controls.Add(Me.BCodBarra)
        Me.Tab_General.Controls.Add(Me.Label17)
        Me.Tab_General.Controls.Add(Me.TGarantia)
        Me.Tab_General.Controls.Add(Me.TObservacion)
        Me.Tab_General.Controls.Add(Me.Label21)
        Me.Tab_General.Controls.Add(Me.BQuitar)
        Me.Tab_General.Controls.Add(Me.BAgregar)
        Me.Tab_General.Controls.Add(Me.CBActivo)
        Me.Tab_General.Controls.Add(Me.Label19)
        Me.Tab_General.Controls.Add(Me.Label14)
        Me.Tab_General.Controls.Add(Me.Label13)
        Me.Tab_General.Controls.Add(Me.Label12)
        Me.Tab_General.Controls.Add(Me.FechaC)
        Me.Tab_General.Controls.Add(Me.Label11)
        Me.Tab_General.Controls.Add(Me.Label8)
        Me.Tab_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_General.Location = New System.Drawing.Point(4, 29)
        Me.Tab_General.Name = "Tab_General"
        Me.Tab_General.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_General.Size = New System.Drawing.Size(1284, 564)
        Me.Tab_General.TabIndex = 0
        Me.Tab_General.Text = "General                     "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(49, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 751
        Me.Label1.Text = "Agregar Foto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(139, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 752
        Me.Label2.Text = "Quitar Foto"
        '
        'CProdNac
        '
        Me.CProdNac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CProdNac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CProdNac.BackColor = System.Drawing.Color.White
        Me.CProdNac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CProdNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CProdNac.FormattingEnabled = True
        Me.CProdNac.ItemHeight = 20
        Me.CProdNac.Items.AddRange(New Object() {"Nacional", "Extranjero"})
        Me.CProdNac.Location = New System.Drawing.Point(449, 42)
        Me.CProdNac.Margin = New System.Windows.Forms.Padding(0)
        Me.CProdNac.Name = "CProdNac"
        Me.CProdNac.Size = New System.Drawing.Size(163, 28)
        Me.CProdNac.TabIndex = 748
        '
        'CMarca
        '
        Me.CMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMarca.BackColor = System.Drawing.Color.White
        Me.CMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMarca.FormattingEnabled = True
        Me.CMarca.ItemHeight = 20
        Me.CMarca.Items.AddRange(New Object() {"1", "2"})
        Me.CMarca.Location = New System.Drawing.Point(268, 178)
        Me.CMarca.Margin = New System.Windows.Forms.Padding(0)
        Me.CMarca.Name = "CMarca"
        Me.CMarca.Size = New System.Drawing.Size(163, 28)
        Me.CMarca.TabIndex = 747
        '
        'CSubCategoria
        '
        Me.CSubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CSubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CSubCategoria.BackColor = System.Drawing.Color.White
        Me.CSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CSubCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSubCategoria.FormattingEnabled = True
        Me.CSubCategoria.ItemHeight = 20
        Me.CSubCategoria.Items.AddRange(New Object() {"1", "2"})
        Me.CSubCategoria.Location = New System.Drawing.Point(449, 109)
        Me.CSubCategoria.Margin = New System.Windows.Forms.Padding(0)
        Me.CSubCategoria.Name = "CSubCategoria"
        Me.CSubCategoria.Size = New System.Drawing.Size(163, 28)
        Me.CSubCategoria.TabIndex = 746
        '
        'CCategoria
        '
        Me.CCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CCategoria.BackColor = System.Drawing.Color.White
        Me.CCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCategoria.FormattingEnabled = True
        Me.CCategoria.ItemHeight = 20
        Me.CCategoria.Items.AddRange(New Object() {"1", "2"})
        Me.CCategoria.Location = New System.Drawing.Point(268, 109)
        Me.CCategoria.Margin = New System.Windows.Forms.Padding(0)
        Me.CCategoria.Name = "CCategoria"
        Me.CCategoria.Size = New System.Drawing.Size(163, 28)
        Me.CCategoria.TabIndex = 745
        '
        'PBAuxImagen
        '
        Me.PBAuxImagen.BackgroundImage = CType(resources.GetObject("PBAuxImagen.BackgroundImage"), System.Drawing.Image)
        Me.PBAuxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBAuxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBAuxImagen.Location = New System.Drawing.Point(126, 6)
        Me.PBAuxImagen.Name = "PBAuxImagen"
        Me.PBAuxImagen.Size = New System.Drawing.Size(48, 48)
        Me.PBAuxImagen.TabIndex = 744
        Me.PBAuxImagen.TabStop = False
        Me.PBAuxImagen.Visible = False
        '
        'Imagen
        '
        Me.Imagen.BackgroundImage = CType(resources.GetObject("Imagen.BackgroundImage"), System.Drawing.Image)
        Me.Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Imagen.Location = New System.Drawing.Point(8, 6)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(238, 200)
        Me.Imagen.TabIndex = 732
        Me.Imagen.TabStop = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(449, 87)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(116, 20)
        Me.Label40.TabIndex = 724
        Me.Label40.Text = "Sub-Categoria:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Navy
        Me.Label57.Location = New System.Drawing.Point(268, 87)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(82, 20)
        Me.Label57.TabIndex = 721
        Me.Label57.Text = "Categoria:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Navy
        Me.Label60.Location = New System.Drawing.Point(20, 147)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(0, 20)
        Me.Label60.TabIndex = 719
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(268, 157)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(57, 20)
        Me.Label41.TabIndex = 712
        Me.Label41.Text = "Marca:"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.Navy
        Me.Label90.Location = New System.Drawing.Point(449, 21)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(113, 20)
        Me.Label90.TabIndex = 701
        Me.Label90.Text = "Producto Nac.:"
        '
        'TModelo
        '
        Me.TModelo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TModelo.Location = New System.Drawing.Point(449, 178)
        Me.TModelo.Name = "TModelo"
        Me.TModelo.Size = New System.Drawing.Size(163, 28)
        Me.TModelo.TabIndex = 699
        Me.TModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.Navy
        Me.Label88.Location = New System.Drawing.Point(449, 157)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(65, 20)
        Me.Label88.TabIndex = 698
        Me.Label88.Text = "Modelo:"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.Navy
        Me.Label89.Location = New System.Drawing.Point(573, 157)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(0, 20)
        Me.Label89.TabIndex = 697
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(622, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(136, 20)
        Me.Label23.TabIndex = 680
        Me.Label23.Text = "Códigos de Barra:"
        '
        'BCodBarra
        '
        Me.BCodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCodBarra.Image = CType(resources.GetObject("BCodBarra.Image"), System.Drawing.Image)
        Me.BCodBarra.Location = New System.Drawing.Point(622, 109)
        Me.BCodBarra.Name = "BCodBarra"
        Me.BCodBarra.Size = New System.Drawing.Size(163, 29)
        Me.BCodBarra.TabIndex = 679
        Me.BCodBarra.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(622, 157)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 20)
        Me.Label17.TabIndex = 116
        Me.Label17.Text = "Garantía:"
        '
        'TGarantia
        '
        Me.TGarantia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TGarantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGarantia.Location = New System.Drawing.Point(622, 178)
        Me.TGarantia.Name = "TGarantia"
        Me.TGarantia.Size = New System.Drawing.Size(163, 28)
        Me.TGarantia.TabIndex = 13
        Me.TGarantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TObservacion
        '
        Me.TObservacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TObservacion.Location = New System.Drawing.Point(268, 247)
        Me.TObservacion.Multiline = True
        Me.TObservacion.Name = "TObservacion"
        Me.TObservacion.Size = New System.Drawing.Size(517, 130)
        Me.TObservacion.TabIndex = 9
        Me.TObservacion.Text = " "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(268, 224)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 20)
        Me.Label21.TabIndex = 114
        Me.Label21.Text = "Observación:"
        '
        'BQuitar
        '
        Me.BQuitar.BackgroundImage = CType(resources.GetObject("BQuitar.BackgroundImage"), System.Drawing.Image)
        Me.BQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BQuitar.Location = New System.Drawing.Point(138, 224)
        Me.BQuitar.Name = "BQuitar"
        Me.BQuitar.Size = New System.Drawing.Size(60, 50)
        Me.BQuitar.TabIndex = 11
        Me.BQuitar.UseVisualStyleBackColor = True
        '
        'BAgregar
        '
        Me.BAgregar.BackgroundImage = CType(resources.GetObject("BAgregar.BackgroundImage"), System.Drawing.Image)
        Me.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BAgregar.Location = New System.Drawing.Point(51, 224)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(60, 50)
        Me.BAgregar.TabIndex = 10
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'CBActivo
        '
        Me.CBActivo.AutoSize = True
        Me.CBActivo.Checked = True
        Me.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActivo.ForeColor = System.Drawing.Color.Navy
        Me.CBActivo.Location = New System.Drawing.Point(622, 42)
        Me.CBActivo.Name = "CBActivo"
        Me.CBActivo.Size = New System.Drawing.Size(117, 24)
        Me.CBActivo.TabIndex = 4
        Me.CBActivo.Text = "Esta Activo?"
        Me.CBActivo.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(268, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 20)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Fecha Creación:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(20, 350)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 20)
        Me.Label14.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(20, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 20)
        Me.Label13.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(444, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 20)
        Me.Label12.TabIndex = 24
        '
        'FechaC
        '
        Me.FechaC.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.FechaC.CustomFormat = "dd/MM/yyyy"
        Me.FechaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaC.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaC.Location = New System.Drawing.Point(268, 44)
        Me.FechaC.Name = "FechaC"
        Me.FechaC.Size = New System.Drawing.Size(163, 26)
        Me.FechaC.TabIndex = 12
        Me.FechaC.Value = New Date(2014, 9, 27, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(17, 561)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 20)
        Me.Label11.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(20, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 20)
        Me.Label8.TabIndex = 9
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.Tab_General)
        Me.TabPrincipal.Controls.Add(Me.Tab_Proveedor)
        Me.TabPrincipal.Controls.Add(Me.Tab_Existencia)
        Me.TabPrincipal.Controls.Add(Me.Tab_Precio)
        Me.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPrincipal.HotTrack = True
        Me.TabPrincipal.Location = New System.Drawing.Point(0, 152)
        Me.TabPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPrincipal.Multiline = True
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPrincipal.SelectedIndex = 0
        Me.TabPrincipal.Size = New System.Drawing.Size(1292, 597)
        Me.TabPrincipal.TabIndex = 26
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.TNombre)
        Me.GroupBox12.Controls.Add(Me.Label16)
        Me.GroupBox12.Controls.Add(Me.TCodigo)
        Me.GroupBox12.Controls.Add(Me.Label15)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox12.Location = New System.Drawing.Point(0, 73)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1292, 79)
        Me.GroupBox12.TabIndex = 27
        Me.GroupBox12.TabStop = False
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(146, 43)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(643, 26)
        Me.TNombre.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(142, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 20)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Nombre:"
        '
        'TCodigo
        '
        Me.TCodigo.BackColor = System.Drawing.Color.Gainsboro
        Me.TCodigo.Enabled = False
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(12, 43)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(118, 26)
        Me.TCodigo.TabIndex = 0
        Me.TCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(6, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 20)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Código:"
        '
        'DialogoFuente
        '
        Me.DialogoFuente.AllowScriptChange = False
        Me.DialogoFuente.AllowSimulations = False
        Me.DialogoFuente.AllowVectorFonts = False
        Me.DialogoFuente.AllowVerticalFonts = False
        Me.DialogoFuente.ShowColor = True
        '
        'FProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1292, 749)
        Me.Controls.Add(Me.TabPrincipal)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft:  Productos. "
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Tab_Precio.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Tab_Existencia.ResumeLayout(False)
        Me.Tab_Existencia.PerformLayout()
        Me.Tab_Proveedor.ResumeLayout(False)
        CType(Me.DGVProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_General.ResumeLayout(False)
        Me.Tab_General.PerformLayout()
        CType(Me.PBAuxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPrincipal.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tab_Precio As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tab_Existencia As System.Windows.Forms.TabPage
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents TStock As System.Windows.Forms.TextBox
    Friend WithEvents TExistenciaMax As System.Windows.Forms.TextBox
    Friend WithEvents TExistenciaMin As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Tab_Proveedor As System.Windows.Forms.TabPage
    Friend WithEvents DGVProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents Tab_General As System.Windows.Forms.TabPage
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TGarantia As System.Windows.Forms.TextBox
    Friend WithEvents TObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents BQuitar As System.Windows.Forms.Button
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents CBActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents FechaC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPrincipal As System.Windows.Forms.TabControl
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BCodBarra As System.Windows.Forms.Button
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents TModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents NuevoProd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BIVAV As System.Windows.Forms.Button
    Friend WithEvents BIVAC As System.Windows.Forms.Button
    Friend WithEvents TCostoD As System.Windows.Forms.TextBox
    Friend WithEvents TIVAV As System.Windows.Forms.TextBox
    Friend WithEvents TIVAC As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Precio1DCI As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents TipoMoneda As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents BCategorias As System.Windows.Forms.ToolStripButton
    Friend WithEvents BSubCategorias As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Imagen As System.Windows.Forms.PictureBox
    Friend WithEvents DialogoFuente As System.Windows.Forms.FontDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PBAuxImagen As System.Windows.Forms.PictureBox
    Friend WithEvents PrecioMDCI As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrecioMD As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PrecioDescuentoCI As System.Windows.Forms.TextBox
    Friend WithEvents PrecioDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents CProdNac As System.Windows.Forms.ComboBox
    Friend WithEvents CMarca As System.Windows.Forms.ComboBox
    Friend WithEvents CSubCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BBuscarProd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BMarcas As System.Windows.Forms.ToolStripButton
    Friend WithEvents Documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Precio1D As System.Windows.Forms.TextBox
End Class
