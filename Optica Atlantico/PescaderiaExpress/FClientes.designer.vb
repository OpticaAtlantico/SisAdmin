<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FClientes))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BBuscar = New System.Windows.Forms.ToolStripButton()
        Me.Editar = New System.Windows.Forms.ToolStripButton()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.TapClientes = New System.Windows.Forms.TabControl()
        Me.TabGeneral = New System.Windows.Forms.TabPage()
        Me.CTipoRif = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.CNacionalidad = New System.Windows.Forms.ComboBox()
        Me.Zona = New System.Windows.Forms.GroupBox()
        Me.SanFelix = New System.Windows.Forms.RadioButton()
        Me.PtoOrdaz = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CBExcento = New System.Windows.Forms.CheckBox()
        Me.TRIF = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TPagWeb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TEmpresa = New System.Windows.Forms.TextBox()
        Me.CBEmpresa = New System.Windows.Forms.CheckBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.TCelular = New System.Windows.Forms.TextBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TCI = New System.Windows.Forms.TextBox()
        Me.TDescripcion = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBActivo = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.TapClientes.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        Me.Zona.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.ToolStripSeparator2, Me.BBuscar, Me.Editar, Me.Guardar, Me.Eliminar, Me.Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(760, 73)
        Me.ToolStrip1.TabIndex = 37
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Nuevo
        '
        Me.Nuevo.AutoSize = False
        Me.Nuevo.ForeColor = System.Drawing.Color.Navy
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(100, 70)
        Me.Nuevo.Text = "Nuevo Cliente"
        Me.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Nuevo.ToolTipText = "Nuevo Cliente."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 73)
        '
        'BBuscar
        '
        Me.BBuscar.AutoSize = False
        Me.BBuscar.ForeColor = System.Drawing.Color.Navy
        Me.BBuscar.Image = CType(resources.GetObject("BBuscar.Image"), System.Drawing.Image)
        Me.BBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(100, 70)
        Me.BBuscar.Text = "Buscar Cliente"
        Me.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BBuscar.ToolTipText = "Buscar Cliente."
        '
        'Editar
        '
        Me.Editar.AutoSize = False
        Me.Editar.ForeColor = System.Drawing.Color.Navy
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(100, 70)
        Me.Editar.Text = "Actualizar Cliente"
        Me.Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Editar.ToolTipText = "Actualizar Cliente."
        '
        'Guardar
        '
        Me.Guardar.AutoSize = False
        Me.Guardar.ForeColor = System.Drawing.Color.Navy
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(100, 70)
        Me.Guardar.Text = "Guardar Cliente"
        Me.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Guardar.ToolTipText = "Guardar Cliente."
        '
        'Eliminar
        '
        Me.Eliminar.AutoSize = False
        Me.Eliminar.ForeColor = System.Drawing.Color.Navy
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(100, 70)
        Me.Eliminar.Text = "Eliminar Cliente"
        Me.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Eliminar.ToolTipText = "Eliminar Cliente."
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.AutoSize = False
        Me.Salir.ForeColor = System.Drawing.Color.Navy
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(100, 70)
        Me.Salir.Text = "Salir"
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Salir.ToolTipText = "Salir."
        '
        'TapClientes
        '
        Me.TapClientes.Controls.Add(Me.TabGeneral)
        Me.TapClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TapClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TapClientes.Location = New System.Drawing.Point(0, 73)
        Me.TapClientes.Name = "TapClientes"
        Me.TapClientes.SelectedIndex = 0
        Me.TapClientes.Size = New System.Drawing.Size(760, 588)
        Me.TapClientes.TabIndex = 38
        '
        'TabGeneral
        '
        Me.TabGeneral.BackColor = System.Drawing.Color.White
        Me.TabGeneral.Controls.Add(Me.CTipoRif)
        Me.TabGeneral.Controls.Add(Me.Label14)
        Me.TabGeneral.Controls.Add(Me.Fecha)
        Me.TabGeneral.Controls.Add(Me.CNacionalidad)
        Me.TabGeneral.Controls.Add(Me.Zona)
        Me.TabGeneral.Controls.Add(Me.Label19)
        Me.TabGeneral.Controls.Add(Me.CBExcento)
        Me.TabGeneral.Controls.Add(Me.TRIF)
        Me.TabGeneral.Controls.Add(Me.Label11)
        Me.TabGeneral.Controls.Add(Me.TDireccion)
        Me.TabGeneral.Controls.Add(Me.Label10)
        Me.TabGeneral.Controls.Add(Me.TPagWeb)
        Me.TabGeneral.Controls.Add(Me.Label4)
        Me.TabGeneral.Controls.Add(Me.TEmpresa)
        Me.TabGeneral.Controls.Add(Me.CBEmpresa)
        Me.TabGeneral.Controls.Add(Me.TCodigo)
        Me.TabGeneral.Controls.Add(Me.TCelular)
        Me.TabGeneral.Controls.Add(Me.TTelefono)
        Me.TabGeneral.Controls.Add(Me.TCorreo)
        Me.TabGeneral.Controls.Add(Me.Label8)
        Me.TabGeneral.Controls.Add(Me.Label7)
        Me.TabGeneral.Controls.Add(Me.Label6)
        Me.TabGeneral.Controls.Add(Me.TCI)
        Me.TabGeneral.Controls.Add(Me.TDescripcion)
        Me.TabGeneral.Controls.Add(Me.TNombre)
        Me.TabGeneral.Controls.Add(Me.Label2)
        Me.TabGeneral.Controls.Add(Me.Label5)
        Me.TabGeneral.Controls.Add(Me.Label9)
        Me.TabGeneral.Controls.Add(Me.Label3)
        Me.TabGeneral.Controls.Add(Me.Label1)
        Me.TabGeneral.Controls.Add(Me.CBActivo)
        Me.TabGeneral.Location = New System.Drawing.Point(4, 29)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGeneral.Size = New System.Drawing.Size(752, 555)
        Me.TabGeneral.TabIndex = 0
        Me.TabGeneral.Text = "General"
        '
        'CTipoRif
        '
        Me.CTipoRif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CTipoRif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTipoRif.FormattingEnabled = True
        Me.CTipoRif.Items.AddRange(New Object() {"J", "G", "V", "E"})
        Me.CTipoRif.Location = New System.Drawing.Point(317, 156)
        Me.CTipoRif.Name = "CTipoRif"
        Me.CTipoRif.Size = New System.Drawing.Size(50, 26)
        Me.CTipoRif.TabIndex = 148
        Me.ToolTip1.SetToolTip(Me.CTipoRif, "Tipo de R.I.F.")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(317, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 20)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "Tipo:"
        Me.ToolTip1.SetToolTip(Me.Label14, "Tipo de R.I.F.")
        '
        'Fecha
        '
        Me.Fecha.CustomFormat = "dd/MM/yyyy"
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha.Location = New System.Drawing.Point(19, 30)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(218, 26)
        Me.Fecha.TabIndex = 123
        Me.Fecha.Value = New Date(2024, 6, 28, 0, 0, 0, 0)
        '
        'CNacionalidad
        '
        Me.CNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNacionalidad.FormattingEnabled = True
        Me.CNacionalidad.Items.AddRange(New Object() {"V", "E"})
        Me.CNacionalidad.Location = New System.Drawing.Point(148, 90)
        Me.CNacionalidad.Name = "CNacionalidad"
        Me.CNacionalidad.Size = New System.Drawing.Size(50, 26)
        Me.CNacionalidad.TabIndex = 109
        Me.ToolTip1.SetToolTip(Me.CNacionalidad, "Nacionalidad.")
        '
        'Zona
        '
        Me.Zona.Controls.Add(Me.SanFelix)
        Me.Zona.Controls.Add(Me.PtoOrdaz)
        Me.Zona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zona.ForeColor = System.Drawing.Color.Navy
        Me.Zona.Location = New System.Drawing.Point(19, 277)
        Me.Zona.Name = "Zona"
        Me.Zona.Size = New System.Drawing.Size(141, 80)
        Me.Zona.TabIndex = 134
        Me.Zona.TabStop = False
        Me.Zona.Tag = "Pto Ordaz"
        Me.Zona.Text = "Zona: "
        '
        'SanFelix
        '
        Me.SanFelix.AutoSize = True
        Me.SanFelix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SanFelix.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SanFelix.Location = New System.Drawing.Point(17, 49)
        Me.SanFelix.Name = "SanFelix"
        Me.SanFelix.Size = New System.Drawing.Size(96, 24)
        Me.SanFelix.TabIndex = 8
        Me.SanFelix.Text = "San Félix."
        Me.SanFelix.UseVisualStyleBackColor = True
        '
        'PtoOrdaz
        '
        Me.PtoOrdaz.AutoSize = True
        Me.PtoOrdaz.Checked = True
        Me.PtoOrdaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PtoOrdaz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PtoOrdaz.Location = New System.Drawing.Point(17, 28)
        Me.PtoOrdaz.Name = "PtoOrdaz"
        Me.PtoOrdaz.Size = New System.Drawing.Size(102, 24)
        Me.PtoOrdaz.TabIndex = 7
        Me.PtoOrdaz.TabStop = True
        Me.PtoOrdaz.Text = "Pto. Ordaz"
        Me.PtoOrdaz.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(19, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 20)
        Me.Label19.TabIndex = 133
        Me.Label19.Text = "Fecha Creación:"
        '
        'CBExcento
        '
        Me.CBExcento.AutoSize = True
        Me.CBExcento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBExcento.ForeColor = System.Drawing.Color.Navy
        Me.CBExcento.Location = New System.Drawing.Point(546, 156)
        Me.CBExcento.Name = "CBExcento"
        Me.CBExcento.Size = New System.Drawing.Size(183, 24)
        Me.CBExcento.TabIndex = 126
        Me.CBExcento.Text = "Exento de Impuestos."
        Me.CBExcento.UseVisualStyleBackColor = True
        '
        'TRIF
        '
        Me.TRIF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TRIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRIF.Location = New System.Drawing.Point(373, 156)
        Me.TRIF.Name = "TRIF"
        Me.TRIF.Size = New System.Drawing.Size(156, 26)
        Me.TRIF.TabIndex = 113
        Me.ToolTip1.SetToolTip(Me.TRIF, "Número del R.I.F. Sin Letras.")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(385, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 20)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "R.I.F.:"
        '
        'TDireccion
        '
        Me.TDireccion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDireccion.Location = New System.Drawing.Point(174, 296)
        Me.TDireccion.Multiline = True
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(559, 61)
        Me.TDireccion.TabIndex = 117
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(170, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "Dirección:"
        '
        'TPagWeb
        '
        Me.TPagWeb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TPagWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPagWeb.Location = New System.Drawing.Point(19, 520)
        Me.TPagWeb.Name = "TPagWeb"
        Me.TPagWeb.Size = New System.Drawing.Size(712, 26)
        Me.TPagWeb.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(19, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Página Web:"
        '
        'TEmpresa
        '
        Me.TEmpresa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEmpresa.Location = New System.Drawing.Point(19, 156)
        Me.TEmpresa.Name = "TEmpresa"
        Me.TEmpresa.Size = New System.Drawing.Size(288, 26)
        Me.TEmpresa.TabIndex = 115
        '
        'CBEmpresa
        '
        Me.CBEmpresa.AutoSize = True
        Me.CBEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.CBEmpresa.Location = New System.Drawing.Point(19, 132)
        Me.CBEmpresa.Name = "CBEmpresa"
        Me.CBEmpresa.Size = New System.Drawing.Size(165, 24)
        Me.CBEmpresa.TabIndex = 129
        Me.CBEmpresa.Text = "Empresa? Nombre:"
        Me.CBEmpresa.UseVisualStyleBackColor = True
        '
        'TCodigo
        '
        Me.TCodigo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(19, 90)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(119, 26)
        Me.TCodigo.TabIndex = 108
        Me.TCodigo.Tag = "0"
        Me.TCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TCelular
        '
        Me.TCelular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCelular.Location = New System.Drawing.Point(401, 394)
        Me.TCelular.MaxLength = 14
        Me.TCelular.Name = "TCelular"
        Me.TCelular.Size = New System.Drawing.Size(332, 26)
        Me.TCelular.TabIndex = 127
        '
        'TTelefono
        '
        Me.TTelefono.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTelefono.Location = New System.Drawing.Point(19, 394)
        Me.TTelefono.MaxLength = 14
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(349, 26)
        Me.TTelefono.TabIndex = 118
        '
        'TCorreo
        '
        Me.TCorreo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCorreo.Location = New System.Drawing.Point(19, 457)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(712, 26)
        Me.TCorreo.TabIndex = 120
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(19, 435)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 20)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "Correo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(397, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Celular:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(19, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Teléfono:"
        '
        'TCI
        '
        Me.TCI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCI.Location = New System.Drawing.Point(202, 90)
        Me.TCI.MaxLength = 8
        Me.TCI.Name = "TCI"
        Me.TCI.Size = New System.Drawing.Size(105, 26)
        Me.TCI.TabIndex = 111
        '
        'TDescripcion
        '
        Me.TDescripcion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDescripcion.Location = New System.Drawing.Point(21, 219)
        Me.TDescripcion.Multiline = True
        Me.TDescripcion.Name = "TDescripcion"
        Me.TDescripcion.Size = New System.Drawing.Size(712, 44)
        Me.TDescripcion.TabIndex = 116
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(317, 90)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(416, 26)
        Me.TNombre.TabIndex = 112
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(19, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Descripción Detallada:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(151, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Nac.:"
        Me.ToolTip1.SetToolTip(Me.Label5, "Nacionalidad.")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(19, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(203, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "C.I.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(317, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 20)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Nombres y Apellidos o  Autorizado:"
        '
        'CBActivo
        '
        Me.CBActivo.AutoSize = True
        Me.CBActivo.Checked = True
        Me.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBActivo.ForeColor = System.Drawing.Color.Navy
        Me.CBActivo.Location = New System.Drawing.Point(654, 67)
        Me.CBActivo.Name = "CBActivo"
        Me.CBActivo.Size = New System.Drawing.Size(75, 24)
        Me.CBActivo.TabIndex = 125
        Me.CBActivo.Text = "Activo."
        Me.CBActivo.UseVisualStyleBackColor = True
        '
        'FClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(760, 661)
        Me.Controls.Add(Me.TapClientes)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "FClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Clientes."
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TapClientes.ResumeLayout(False)
        Me.TabGeneral.ResumeLayout(False)
        Me.TabGeneral.PerformLayout()
        Me.Zona.ResumeLayout(False)
        Me.Zona.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TapClientes As System.Windows.Forms.TabControl
    Friend WithEvents TabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Zona As System.Windows.Forms.GroupBox
    Friend WithEvents SanFelix As System.Windows.Forms.RadioButton
    Friend WithEvents PtoOrdaz As System.Windows.Forms.RadioButton
    Friend WithEvents CNacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBExcento As System.Windows.Forms.CheckBox
    Friend WithEvents CBActivo As System.Windows.Forms.CheckBox
    Friend WithEvents TRIF As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TPagWeb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents CBEmpresa As System.Windows.Forms.CheckBox
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TCelular As System.Windows.Forms.TextBox
    Friend WithEvents TTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TCI As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CTipoRif As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
