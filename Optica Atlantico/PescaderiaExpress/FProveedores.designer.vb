<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProveedores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.Buscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Editar = New System.Windows.Forms.ToolStripButton()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BBancos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.TapGeneral = New System.Windows.Forms.TabPage()
        Me.TContacto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBOtros = New System.Windows.Forms.CheckBox()
        Me.CBTransporte = New System.Windows.Forms.CheckBox()
        Me.CBForaneo = New System.Windows.Forms.CheckBox()
        Me.TPorcAlqExt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CHAlqPuntoExt = New System.Windows.Forms.CheckBox()
        Me.CBActivo = New System.Windows.Forms.CheckBox()
        Me.TPPago = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CBEfecExtAjeno = New System.Windows.Forms.CheckBox()
        Me.TAlias = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.TDescripcion = New System.Windows.Forms.TextBox()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.TRif = New System.Windows.Forms.TextBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.TCelular = New System.Windows.Forms.TextBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TSitioWeb = New System.Windows.Forms.TextBox()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabProveedores = New System.Windows.Forms.TabControl()
        Me.TapBancos = New System.Windows.Forms.TabPage()
        Me.GridBancos = New System.Windows.Forms.DataGridView()
        Me.TapListados = New System.Windows.Forms.TabPage()
        Me.GridProveedores = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.TapGeneral.SuspendLayout()
        Me.TabProveedores.SuspendLayout()
        Me.TapBancos.SuspendLayout()
        CType(Me.GridBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TapListados.SuspendLayout()
        CType(Me.GridProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Imprimir, Me.Nuevo, Me.Buscar, Me.ToolStripSeparator2, Me.Editar, Me.Guardar, Me.Eliminar, Me.Salir, Me.ToolStripSeparator3, Me.BBancos, Me.ToolStripSeparator1, Me.BExportarExcel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(785, 70)
        Me.ToolStrip1.TabIndex = 125
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Imprimir
        '
        Me.Imprimir.ForeColor = System.Drawing.Color.Navy
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(69, 67)
        Me.Imprimir.Text = "  Imprimir  "
        Me.Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Imprimir.ToolTipText = "Imprimir."
        '
        'Nuevo
        '
        Me.Nuevo.ForeColor = System.Drawing.Color.Navy
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(70, 67)
        Me.Nuevo.Text = "    Nuevo    "
        Me.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Buscar
        '
        Me.Buscar.ForeColor = System.Drawing.Color.Navy
        Me.Buscar.Image = CType(resources.GetObject("Buscar.Image"), System.Drawing.Image)
        Me.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(70, 67)
        Me.Buscar.Text = "    Buscar    "
        Me.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Buscar.ToolTipText = "Buscar."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 70)
        '
        'Editar
        '
        Me.Editar.ForeColor = System.Drawing.Color.Navy
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(69, 67)
        Me.Editar.Text = " Actualizar "
        Me.Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Editar.ToolTipText = "Editar."
        '
        'Guardar
        '
        Me.Guardar.ForeColor = System.Drawing.Color.Navy
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(65, 67)
        Me.Guardar.Text = "  Guardar  "
        Me.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Guardar.ToolTipText = "Guardar."
        '
        'Eliminar
        '
        Me.Eliminar.ForeColor = System.Drawing.Color.Navy
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(66, 67)
        Me.Eliminar.Text = "  Eliminar  "
        Me.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Eliminar.ToolTipText = "Eliminar."
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.ForeColor = System.Drawing.Color.Navy
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(63, 67)
        Me.Salir.Text = "     Salir     "
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Salir.ToolTipText = "Salir."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 70)
        '
        'BBancos
        '
        Me.BBancos.ForeColor = System.Drawing.Color.Navy
        Me.BBancos.Image = CType(resources.GetObject("BBancos.Image"), System.Drawing.Image)
        Me.BBancos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BBancos.Name = "BBancos"
        Me.BBancos.Size = New System.Drawing.Size(73, 67)
        Me.BBancos.Text = "    Bancos    "
        Me.BBancos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BBancos.ToolTipText = "Bancos."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 70)
        '
        'BExportarExcel
        '
        Me.BExportarExcel.ForeColor = System.Drawing.Color.Navy
        Me.BExportarExcel.Image = CType(resources.GetObject("BExportarExcel.Image"), System.Drawing.Image)
        Me.BExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BExportarExcel.Name = "BExportarExcel"
        Me.BExportarExcel.Size = New System.Drawing.Size(88, 67)
        Me.BExportarExcel.Text = " Exportar Excel"
        Me.BExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BExportarExcel.ToolTipText = "Exportar a Excel."
        '
        'TapGeneral
        '
        Me.TapGeneral.BackColor = System.Drawing.Color.White
        Me.TapGeneral.Controls.Add(Me.TContacto)
        Me.TapGeneral.Controls.Add(Me.Label13)
        Me.TapGeneral.Controls.Add(Me.CBOtros)
        Me.TapGeneral.Controls.Add(Me.CBTransporte)
        Me.TapGeneral.Controls.Add(Me.CBForaneo)
        Me.TapGeneral.Controls.Add(Me.TPorcAlqExt)
        Me.TapGeneral.Controls.Add(Me.Label11)
        Me.TapGeneral.Controls.Add(Me.CHAlqPuntoExt)
        Me.TapGeneral.Controls.Add(Me.CBActivo)
        Me.TapGeneral.Controls.Add(Me.TPPago)
        Me.TapGeneral.Controls.Add(Me.Label12)
        Me.TapGeneral.Controls.Add(Me.CBEfecExtAjeno)
        Me.TapGeneral.Controls.Add(Me.TAlias)
        Me.TapGeneral.Controls.Add(Me.Label10)
        Me.TapGeneral.Controls.Add(Me.Label19)
        Me.TapGeneral.Controls.Add(Me.Fecha)
        Me.TapGeneral.Controls.Add(Me.TDescripcion)
        Me.TapGeneral.Controls.Add(Me.TCorreo)
        Me.TapGeneral.Controls.Add(Me.TRif)
        Me.TapGeneral.Controls.Add(Me.TCodigo)
        Me.TapGeneral.Controls.Add(Me.TCelular)
        Me.TapGeneral.Controls.Add(Me.TTelefono)
        Me.TapGeneral.Controls.Add(Me.TSitioWeb)
        Me.TapGeneral.Controls.Add(Me.TDireccion)
        Me.TapGeneral.Controls.Add(Me.TNombre)
        Me.TapGeneral.Controls.Add(Me.Label4)
        Me.TapGeneral.Controls.Add(Me.Label2)
        Me.TapGeneral.Controls.Add(Me.Label9)
        Me.TapGeneral.Controls.Add(Me.Label8)
        Me.TapGeneral.Controls.Add(Me.Label7)
        Me.TapGeneral.Controls.Add(Me.Label6)
        Me.TapGeneral.Controls.Add(Me.Label5)
        Me.TapGeneral.Controls.Add(Me.Label3)
        Me.TapGeneral.Controls.Add(Me.Label1)
        Me.TapGeneral.Location = New System.Drawing.Point(4, 29)
        Me.TapGeneral.Name = "TapGeneral"
        Me.TapGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TapGeneral.Size = New System.Drawing.Size(777, 709)
        Me.TapGeneral.TabIndex = 0
        Me.TapGeneral.Text = "General          "
        '
        'TContacto
        '
        Me.TContacto.BackColor = System.Drawing.SystemColors.Info
        Me.TContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TContacto.Location = New System.Drawing.Point(16, 115)
        Me.TContacto.MaxLength = 50
        Me.TContacto.Name = "TContacto"
        Me.TContacto.Size = New System.Drawing.Size(711, 29)
        Me.TContacto.TabIndex = 154
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(16, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(239, 20)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = "Nombre Contacto del Proveedor:"
        '
        'CBOtros
        '
        Me.CBOtros.AutoSize = True
        Me.CBOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOtros.ForeColor = System.Drawing.Color.Navy
        Me.CBOtros.Location = New System.Drawing.Point(217, 159)
        Me.CBOtros.Name = "CBOtros"
        Me.CBOtros.Size = New System.Drawing.Size(117, 24)
        Me.CBOtros.TabIndex = 152
        Me.CBOtros.Text = "<>Pescado?"
        Me.CBOtros.UseVisualStyleBackColor = True
        Me.CBOtros.Visible = False
        '
        'CBTransporte
        '
        Me.CBTransporte.AutoSize = True
        Me.CBTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTransporte.ForeColor = System.Drawing.Color.Navy
        Me.CBTransporte.Location = New System.Drawing.Point(556, 590)
        Me.CBTransporte.Name = "CBTransporte"
        Me.CBTransporte.Size = New System.Drawing.Size(164, 24)
        Me.CBTransporte.TabIndex = 151
        Me.CBTransporte.Text = "Servicio Transporte"
        Me.CBTransporte.UseVisualStyleBackColor = True
        '
        'CBForaneo
        '
        Me.CBForaneo.AutoSize = True
        Me.CBForaneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBForaneo.ForeColor = System.Drawing.Color.Navy
        Me.CBForaneo.Location = New System.Drawing.Point(556, 565)
        Me.CBForaneo.Name = "CBForaneo"
        Me.CBForaneo.Size = New System.Drawing.Size(88, 24)
        Me.CBForaneo.TabIndex = 150
        Me.CBForaneo.Text = "Foraneo"
        Me.CBForaneo.UseVisualStyleBackColor = True
        '
        'TPorcAlqExt
        '
        Me.TPorcAlqExt.BackColor = System.Drawing.SystemColors.Info
        Me.TPorcAlqExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPorcAlqExt.Location = New System.Drawing.Point(448, 591)
        Me.TPorcAlqExt.MaxLength = 14
        Me.TPorcAlqExt.Name = "TPorcAlqExt"
        Me.TPorcAlqExt.Size = New System.Drawing.Size(70, 29)
        Me.TPorcAlqExt.TabIndex = 149
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(363, 591)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.TabIndex = 148
        Me.Label11.Text = "% Pago:"
        '
        'CHAlqPuntoExt
        '
        Me.CHAlqPuntoExt.AutoSize = True
        Me.CHAlqPuntoExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHAlqPuntoExt.ForeColor = System.Drawing.Color.Navy
        Me.CHAlqPuntoExt.Location = New System.Drawing.Point(365, 565)
        Me.CHAlqPuntoExt.Name = "CHAlqPuntoExt"
        Me.CHAlqPuntoExt.Size = New System.Drawing.Size(132, 24)
        Me.CHAlqPuntoExt.TabIndex = 147
        Me.CHAlqPuntoExt.Text = "Alq. Punto Ext."
        Me.CHAlqPuntoExt.UseVisualStyleBackColor = True
        '
        'CBActivo
        '
        Me.CBActivo.AutoSize = True
        Me.CBActivo.Checked = True
        Me.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBActivo.ForeColor = System.Drawing.Color.Navy
        Me.CBActivo.Location = New System.Drawing.Point(652, 13)
        Me.CBActivo.Name = "CBActivo"
        Me.CBActivo.Size = New System.Drawing.Size(75, 24)
        Me.CBActivo.TabIndex = 146
        Me.CBActivo.Text = "Activo."
        Me.CBActivo.UseVisualStyleBackColor = True
        '
        'TPPago
        '
        Me.TPPago.BackColor = System.Drawing.SystemColors.Info
        Me.TPPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPPago.Location = New System.Drawing.Point(266, 590)
        Me.TPPago.MaxLength = 14
        Me.TPPago.Name = "TPPago"
        Me.TPPago.Size = New System.Drawing.Size(70, 29)
        Me.TPPago.TabIndex = 142
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(181, 590)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 20)
        Me.Label12.TabIndex = 141
        Me.Label12.Text = "% Pago:"
        '
        'CBEfecExtAjeno
        '
        Me.CBEfecExtAjeno.AutoSize = True
        Me.CBEfecExtAjeno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEfecExtAjeno.ForeColor = System.Drawing.Color.Navy
        Me.CBEfecExtAjeno.Location = New System.Drawing.Point(178, 560)
        Me.CBEfecExtAjeno.Name = "CBEfecExtAjeno"
        Me.CBEfecExtAjeno.Size = New System.Drawing.Size(145, 24)
        Me.CBEfecExtAjeno.TabIndex = 140
        Me.CBEfecExtAjeno.Text = "Efec. Ext. Ajeno."
        Me.CBEfecExtAjeno.UseVisualStyleBackColor = True
        '
        'TAlias
        '
        Me.TAlias.BackColor = System.Drawing.SystemColors.Info
        Me.TAlias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAlias.Location = New System.Drawing.Point(363, 43)
        Me.TAlias.MaxLength = 30
        Me.TAlias.Name = "TAlias"
        Me.TAlias.Size = New System.Drawing.Size(172, 29)
        Me.TAlias.TabIndex = 107
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(363, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 20)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Alias:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(16, 564)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 20)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "Fecha Creación:"
        '
        'Fecha
        '
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha.Location = New System.Drawing.Point(16, 591)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(146, 26)
        Me.Fecha.TabIndex = 104
        Me.Fecha.Value = New Date(2014, 9, 27, 0, 0, 0, 0)
        '
        'TDescripcion
        '
        Me.TDescripcion.BackColor = System.Drawing.SystemColors.Info
        Me.TDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDescripcion.Location = New System.Drawing.Point(16, 187)
        Me.TDescripcion.Multiline = True
        Me.TDescripcion.Name = "TDescripcion"
        Me.TDescripcion.Size = New System.Drawing.Size(706, 51)
        Me.TDescripcion.TabIndex = 69
        '
        'TCorreo
        '
        Me.TCorreo.BackColor = System.Drawing.SystemColors.Info
        Me.TCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCorreo.Location = New System.Drawing.Point(16, 447)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(702, 29)
        Me.TCorreo.TabIndex = 66
        '
        'TRif
        '
        Me.TRif.BackColor = System.Drawing.SystemColors.Info
        Me.TRif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRif.Location = New System.Drawing.Point(541, 43)
        Me.TRif.MaxLength = 12
        Me.TRif.Name = "TRif"
        Me.TRif.Size = New System.Drawing.Size(186, 29)
        Me.TRif.TabIndex = 65
        '
        'TCodigo
        '
        Me.TCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(16, 43)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(72, 29)
        Me.TCodigo.TabIndex = 64
        '
        'TCelular
        '
        Me.TCelular.BackColor = System.Drawing.SystemColors.Info
        Me.TCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCelular.Location = New System.Drawing.Point(382, 378)
        Me.TCelular.Name = "TCelular"
        Me.TCelular.Size = New System.Drawing.Size(340, 29)
        Me.TCelular.TabIndex = 62
        '
        'TTelefono
        '
        Me.TTelefono.BackColor = System.Drawing.SystemColors.Info
        Me.TTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTelefono.Location = New System.Drawing.Point(16, 378)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(340, 29)
        Me.TTelefono.TabIndex = 61
        '
        'TSitioWeb
        '
        Me.TSitioWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSitioWeb.Location = New System.Drawing.Point(16, 520)
        Me.TSitioWeb.Name = "TSitioWeb"
        Me.TSitioWeb.Size = New System.Drawing.Size(702, 29)
        Me.TSitioWeb.TabIndex = 60
        '
        'TDireccion
        '
        Me.TDireccion.BackColor = System.Drawing.SystemColors.Info
        Me.TDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDireccion.Location = New System.Drawing.Point(16, 275)
        Me.TDireccion.Multiline = True
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(706, 60)
        Me.TDireccion.TabIndex = 56
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.Info
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(95, 43)
        Me.TNombre.MaxLength = 50
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(262, 29)
        Me.TNombre.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(16, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 20)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Descripción Detallada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(16, 493)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Sitio Web:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(16, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Código:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(16, 420)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 20)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Correo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(382, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Celular:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(16, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(16, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(541, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "R.I.F."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(95, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Nombre Proveedor:"
        '
        'TabProveedores
        '
        Me.TabProveedores.Controls.Add(Me.TapGeneral)
        Me.TabProveedores.Controls.Add(Me.TapBancos)
        Me.TabProveedores.Controls.Add(Me.TapListados)
        Me.TabProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabProveedores.Location = New System.Drawing.Point(0, 70)
        Me.TabProveedores.Name = "TabProveedores"
        Me.TabProveedores.SelectedIndex = 0
        Me.TabProveedores.Size = New System.Drawing.Size(785, 742)
        Me.TabProveedores.TabIndex = 28
        '
        'TapBancos
        '
        Me.TapBancos.BackColor = System.Drawing.Color.White
        Me.TapBancos.Controls.Add(Me.GridBancos)
        Me.TapBancos.Location = New System.Drawing.Point(4, 29)
        Me.TapBancos.Name = "TapBancos"
        Me.TapBancos.Padding = New System.Windows.Forms.Padding(3)
        Me.TapBancos.Size = New System.Drawing.Size(777, 709)
        Me.TapBancos.TabIndex = 1
        Me.TapBancos.Text = "Listado de Bancos          "
        '
        'GridBancos
        '
        Me.GridBancos.AllowUserToAddRows = False
        Me.GridBancos.AllowUserToDeleteRows = False
        Me.GridBancos.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridBancos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBancos.EnableHeadersVisualStyles = False
        Me.GridBancos.Location = New System.Drawing.Point(3, 3)
        Me.GridBancos.Name = "GridBancos"
        Me.GridBancos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridBancos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridBancos.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GridBancos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GridBancos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GridBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridBancos.Size = New System.Drawing.Size(771, 703)
        Me.GridBancos.TabIndex = 1
        '
        'TapListados
        '
        Me.TapListados.Controls.Add(Me.GridProveedores)
        Me.TapListados.Location = New System.Drawing.Point(4, 29)
        Me.TapListados.Name = "TapListados"
        Me.TapListados.Padding = New System.Windows.Forms.Padding(3)
        Me.TapListados.Size = New System.Drawing.Size(777, 709)
        Me.TapListados.TabIndex = 2
        Me.TapListados.Text = "Listado de Proveedores          "
        Me.TapListados.UseVisualStyleBackColor = True
        '
        'GridProveedores
        '
        Me.GridProveedores.AllowUserToAddRows = False
        Me.GridProveedores.AllowUserToDeleteRows = False
        Me.GridProveedores.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridProveedores.DefaultCellStyle = DataGridViewCellStyle5
        Me.GridProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProveedores.EnableHeadersVisualStyles = False
        Me.GridProveedores.Location = New System.Drawing.Point(3, 3)
        Me.GridProveedores.Name = "GridProveedores"
        Me.GridProveedores.ReadOnly = True
        Me.GridProveedores.RowHeadersVisible = False
        Me.GridProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridProveedores.Size = New System.Drawing.Size(771, 703)
        Me.GridProveedores.TabIndex = 1
        '
        'FProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(785, 812)
        Me.Controls.Add(Me.TabProveedores)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Proveedores."
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TapGeneral.ResumeLayout(False)
        Me.TapGeneral.PerformLayout()
        Me.TabProveedores.ResumeLayout(False)
        Me.TapBancos.ResumeLayout(False)
        CType(Me.GridBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TapListados.ResumeLayout(False)
        CType(Me.GridProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TapGeneral As System.Windows.Forms.TabPage
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TCorreo As System.Windows.Forms.TextBox
    Friend WithEvents TRif As System.Windows.Forms.TextBox
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TCelular As System.Windows.Forms.TextBox
    Friend WithEvents TTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TSitioWeb As System.Windows.Forms.TextBox
    Friend WithEvents TDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabProveedores As System.Windows.Forms.TabControl
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BBancos As System.Windows.Forms.ToolStripButton
    Friend WithEvents TAlias As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TapBancos As System.Windows.Forms.TabPage
    Friend WithEvents GridBancos As System.Windows.Forms.DataGridView
    Friend WithEvents TPPago As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CBEfecExtAjeno As System.Windows.Forms.CheckBox
    Friend WithEvents CBActivo As System.Windows.Forms.CheckBox
    Friend WithEvents CHAlqPuntoExt As System.Windows.Forms.CheckBox
    Friend WithEvents TPorcAlqExt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CBForaneo As System.Windows.Forms.CheckBox
    Friend WithEvents CBTransporte As System.Windows.Forms.CheckBox
    Friend WithEvents CBOtros As System.Windows.Forms.CheckBox
    Friend WithEvents TapListados As System.Windows.Forms.TabPage
    Friend WithEvents GridProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents TContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BExportarExcel As System.Windows.Forms.ToolStripButton
End Class
