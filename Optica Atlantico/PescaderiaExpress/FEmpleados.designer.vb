<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FEmpleados))
        Me.MenuCat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CrearCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarCat = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.BCargaos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.CBMarketing = New System.Windows.Forms.CheckBox()
        Me.CBGerente = New System.Windows.Forms.CheckBox()
        Me.CBOpto = New System.Windows.Forms.CheckBox()
        Me.CBAsesor = New System.Windows.Forms.CheckBox()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.FotoNew = New System.Windows.Forms.PictureBox()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.TParentesco = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.THijos = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.CEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TEdad = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.BQuitar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TGrupoS = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TTelfContacto = New System.Windows.Forms.TextBox()
        Me.TContacto = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TCelular = New System.Windows.Forms.TextBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TCI = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FechaIng = New System.Windows.Forms.DateTimePicker()
        Me.CNacionalidad = New System.Windows.Forms.ComboBox()
        Me.CBActivo = New System.Windows.Forms.CheckBox()
        Me.Zona = New System.Windows.Forms.GroupBox()
        Me.SanFelix = New System.Windows.Forms.RadioButton()
        Me.PtoOrdaz = New System.Windows.Forms.RadioButton()
        Me.CCargo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Dialogo = New System.Windows.Forms.OpenFileDialog()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LEmpleado = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuCat.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        CType(Me.FotoNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Zona.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuCat
        '
        Me.MenuCat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearCat, Me.ConfigurarCat, Me.CerrarCat})
        Me.MenuCat.Name = "MenuCat"
        Me.MenuCat.ShowImageMargin = False
        Me.MenuCat.Size = New System.Drawing.Size(164, 70)
        '
        'CrearCat
        '
        Me.CrearCat.Name = "CrearCat"
        Me.CrearCat.Size = New System.Drawing.Size(163, 22)
        Me.CrearCat.Text = "Crear Categogía."
        '
        'ConfigurarCat
        '
        Me.ConfigurarCat.Name = "ConfigurarCat"
        Me.ConfigurarCat.Size = New System.Drawing.Size(163, 22)
        Me.ConfigurarCat.Text = "Configurar Categoría."
        '
        'CerrarCat
        '
        Me.CerrarCat.Name = "CerrarCat"
        Me.CerrarCat.Size = New System.Drawing.Size(163, 22)
        Me.CerrarCat.Text = "Cerrar Menú."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Imprimir, Me.Nuevo, Me.Buscar, Me.ToolStripSeparator2, Me.Editar, Me.Guardar, Me.Eliminar, Me.Salir, Me.ToolStripSeparator3, Me.BCargaos, Me.ToolStripSeparator4, Me.BExportarExcel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1148, 73)
        Me.ToolStrip1.TabIndex = 125
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Imprimir
        '
        Me.Imprimir.AutoSize = False
        Me.Imprimir.ForeColor = System.Drawing.Color.Navy
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(100, 70)
        Me.Imprimir.Text = "     Imprimir     "
        Me.Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Imprimir.ToolTipText = "Imprimir."
        '
        'Nuevo
        '
        Me.Nuevo.AutoSize = False
        Me.Nuevo.ForeColor = System.Drawing.Color.Navy
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(100, 70)
        Me.Nuevo.Text = "     Nuevo    "
        Me.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Buscar
        '
        Me.Buscar.AutoSize = False
        Me.Buscar.ForeColor = System.Drawing.Color.Navy
        Me.Buscar.Image = CType(resources.GetObject("Buscar.Image"), System.Drawing.Image)
        Me.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(100, 70)
        Me.Buscar.Text = "     Buscar     "
        Me.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Buscar.ToolTipText = "Buscar."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 73)
        '
        'Editar
        '
        Me.Editar.AutoSize = False
        Me.Editar.ForeColor = System.Drawing.Color.Navy
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(100, 70)
        Me.Editar.Text = "   Actualizar   "
        Me.Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Editar.ToolTipText = "Editar."
        '
        'Guardar
        '
        Me.Guardar.AutoSize = False
        Me.Guardar.ForeColor = System.Drawing.Color.Navy
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(100, 70)
        Me.Guardar.Text = "    Guardar    "
        Me.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Guardar.ToolTipText = "Guardar."
        '
        'Eliminar
        '
        Me.Eliminar.AutoSize = False
        Me.Eliminar.ForeColor = System.Drawing.Color.Navy
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(100, 70)
        Me.Eliminar.Text = "    Eliminar    "
        Me.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Eliminar.ToolTipText = "Eliminar."
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
        Me.Salir.Text = "   Salir   "
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Salir.ToolTipText = "Salir."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 73)
        '
        'BCargaos
        '
        Me.BCargaos.AutoSize = False
        Me.BCargaos.ForeColor = System.Drawing.Color.Navy
        Me.BCargaos.Image = CType(resources.GetObject("BCargaos.Image"), System.Drawing.Image)
        Me.BCargaos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BCargaos.Name = "BCargaos"
        Me.BCargaos.Size = New System.Drawing.Size(100, 70)
        Me.BCargaos.Text = "     Cargos     "
        Me.BCargaos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BCargaos.ToolTipText = "Cargos."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 73)
        '
        'BExportarExcel
        '
        Me.BExportarExcel.AutoSize = False
        Me.BExportarExcel.ForeColor = System.Drawing.Color.Navy
        Me.BExportarExcel.Image = CType(resources.GetObject("BExportarExcel.Image"), System.Drawing.Image)
        Me.BExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BExportarExcel.Name = "BExportarExcel"
        Me.BExportarExcel.Size = New System.Drawing.Size(100, 70)
        Me.BExportarExcel.Text = "   Exportar Excel"
        Me.BExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BExportarExcel.ToolTipText = "Exportar Excel."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 123)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1148, 481)
        Me.TabControl1.TabIndex = 703
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.CBMarketing)
        Me.General.Controls.Add(Me.CBGerente)
        Me.General.Controls.Add(Me.CBOpto)
        Me.General.Controls.Add(Me.CBAsesor)
        Me.General.Controls.Add(Me.TCorreo)
        Me.General.Controls.Add(Me.FotoNew)
        Me.General.Controls.Add(Me.Foto)
        Me.General.Controls.Add(Me.TParentesco)
        Me.General.Controls.Add(Me.Label33)
        Me.General.Controls.Add(Me.THijos)
        Me.General.Controls.Add(Me.Label32)
        Me.General.Controls.Add(Me.CEstadoCivil)
        Me.General.Controls.Add(Me.Label31)
        Me.General.Controls.Add(Me.TEdad)
        Me.General.Controls.Add(Me.Label30)
        Me.General.Controls.Add(Me.Label29)
        Me.General.Controls.Add(Me.FechaNac)
        Me.General.Controls.Add(Me.BQuitar)
        Me.General.Controls.Add(Me.BAgregar)
        Me.General.Controls.Add(Me.Agregar)
        Me.General.Controls.Add(Me.Label39)
        Me.General.Controls.Add(Me.TGrupoS)
        Me.General.Controls.Add(Me.Label24)
        Me.General.Controls.Add(Me.TTelfContacto)
        Me.General.Controls.Add(Me.TContacto)
        Me.General.Controls.Add(Me.Label22)
        Me.General.Controls.Add(Me.Label23)
        Me.General.Controls.Add(Me.TCelular)
        Me.General.Controls.Add(Me.TTelefono)
        Me.General.Controls.Add(Me.TCI)
        Me.General.Controls.Add(Me.TNombre)
        Me.General.Controls.Add(Me.TCodigo)
        Me.General.Controls.Add(Me.TDireccion)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.FechaIng)
        Me.General.Controls.Add(Me.CNacionalidad)
        Me.General.Controls.Add(Me.CBActivo)
        Me.General.Controls.Add(Me.Zona)
        Me.General.Controls.Add(Me.CCargo)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.Label19)
        Me.General.Location = New System.Drawing.Point(4, 29)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(1140, 448)
        Me.General.TabIndex = 0
        Me.General.Text = "General     "
        '
        'CBMarketing
        '
        Me.CBMarketing.AutoSize = True
        Me.CBMarketing.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMarketing.ForeColor = System.Drawing.Color.Navy
        Me.CBMarketing.Location = New System.Drawing.Point(851, 48)
        Me.CBMarketing.Name = "CBMarketing"
        Me.CBMarketing.Size = New System.Drawing.Size(132, 30)
        Me.CBMarketing.TabIndex = 790
        Me.CBMarketing.Text = "Marketing."
        Me.CBMarketing.UseVisualStyleBackColor = True
        '
        'CBGerente
        '
        Me.CBGerente.AutoSize = True
        Me.CBGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBGerente.ForeColor = System.Drawing.Color.Navy
        Me.CBGerente.Location = New System.Drawing.Point(851, 12)
        Me.CBGerente.Name = "CBGerente"
        Me.CBGerente.Size = New System.Drawing.Size(115, 30)
        Me.CBGerente.TabIndex = 789
        Me.CBGerente.Text = "Gerente."
        Me.CBGerente.UseVisualStyleBackColor = True
        '
        'CBOpto
        '
        Me.CBOpto.AutoSize = True
        Me.CBOpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOpto.ForeColor = System.Drawing.Color.Navy
        Me.CBOpto.Location = New System.Drawing.Point(674, 48)
        Me.CBOpto.Name = "CBOpto"
        Me.CBOpto.Size = New System.Drawing.Size(162, 30)
        Me.CBOpto.TabIndex = 788
        Me.CBOpto.Text = "Optometrista."
        Me.CBOpto.UseVisualStyleBackColor = True
        '
        'CBAsesor
        '
        Me.CBAsesor.AutoSize = True
        Me.CBAsesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAsesor.ForeColor = System.Drawing.Color.Navy
        Me.CBAsesor.Location = New System.Drawing.Point(674, 12)
        Me.CBAsesor.Name = "CBAsesor"
        Me.CBAsesor.Size = New System.Drawing.Size(105, 30)
        Me.CBAsesor.TabIndex = 787
        Me.CBAsesor.Text = "Asesor."
        Me.CBAsesor.UseVisualStyleBackColor = True
        '
        'TCorreo
        '
        Me.TCorreo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCorreo.Location = New System.Drawing.Point(255, 337)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(716, 26)
        Me.TCorreo.TabIndex = 786
        '
        'FotoNew
        '
        Me.FotoNew.BackgroundImage = CType(resources.GetObject("FotoNew.BackgroundImage"), System.Drawing.Image)
        Me.FotoNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FotoNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoNew.Location = New System.Drawing.Point(19, 42)
        Me.FotoNew.Name = "FotoNew"
        Me.FotoNew.Size = New System.Drawing.Size(79, 71)
        Me.FotoNew.TabIndex = 782
        Me.FotoNew.TabStop = False
        Me.FotoNew.Visible = False
        '
        'Foto
        '
        Me.Foto.BackgroundImage = CType(resources.GetObject("Foto.BackgroundImage"), System.Drawing.Image)
        Me.Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Foto.Location = New System.Drawing.Point(11, 42)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(234, 229)
        Me.Foto.TabIndex = 750
        Me.Foto.TabStop = False
        '
        'TParentesco
        '
        Me.TParentesco.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TParentesco.Location = New System.Drawing.Point(841, 401)
        Me.TParentesco.Name = "TParentesco"
        Me.TParentesco.Size = New System.Drawing.Size(282, 26)
        Me.TParentesco.TabIndex = 777
        Me.TParentesco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(841, 379)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 20)
        Me.Label33.TabIndex = 776
        Me.Label33.Text = "Parentesco:"
        '
        'THijos
        '
        Me.THijos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.THijos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THijos.Location = New System.Drawing.Point(546, 186)
        Me.THijos.MaxLength = 14
        Me.THijos.Name = "THijos"
        Me.THijos.Size = New System.Drawing.Size(61, 26)
        Me.THijos.TabIndex = 775
        Me.THijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(541, 161)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(68, 20)
        Me.Label32.TabIndex = 774
        Me.Label32.Text = "N° Hijos:"
        '
        'CEstadoCivil
        '
        Me.CEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CEstadoCivil.BackColor = System.Drawing.Color.White
        Me.CEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEstadoCivil.FormattingEnabled = True
        Me.CEstadoCivil.ItemHeight = 18
        Me.CEstadoCivil.Items.AddRange(New Object() {"", "Soltero(a)", "Casado(a)", "Divorciado(a)", "Viudo(a)", "Concubino(a)"})
        Me.CEstadoCivil.Location = New System.Drawing.Point(430, 186)
        Me.CEstadoCivil.Margin = New System.Windows.Forms.Padding(0)
        Me.CEstadoCivil.Name = "CEstadoCivil"
        Me.CEstadoCivil.Size = New System.Drawing.Size(109, 26)
        Me.CEstadoCivil.TabIndex = 773
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(432, 161)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(95, 20)
        Me.Label31.TabIndex = 772
        Me.Label31.Text = "Estado Civil:"
        '
        'TEdad
        '
        Me.TEdad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEdad.Location = New System.Drawing.Point(378, 186)
        Me.TEdad.MaxLength = 14
        Me.TEdad.Name = "TEdad"
        Me.TEdad.ReadOnly = True
        Me.TEdad.Size = New System.Drawing.Size(45, 26)
        Me.TEdad.TabIndex = 770
        Me.TEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(378, 161)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(51, 20)
        Me.Label30.TabIndex = 769
        Me.Label30.Text = "Edad:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(255, 161)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(94, 20)
        Me.Label29.TabIndex = 768
        Me.Label29.Text = "Fecha Nac.:"
        '
        'FechaNac
        '
        Me.FechaNac.CustomFormat = "dd/MM/yyyy"
        Me.FechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaNac.Location = New System.Drawing.Point(255, 186)
        Me.FechaNac.Name = "FechaNac"
        Me.FechaNac.Size = New System.Drawing.Size(116, 26)
        Me.FechaNac.TabIndex = 767
        Me.FechaNac.Value = New Date(2024, 6, 28, 0, 0, 0, 0)
        '
        'BQuitar
        '
        Me.BQuitar.BackgroundImage = CType(resources.GetObject("BQuitar.BackgroundImage"), System.Drawing.Image)
        Me.BQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BQuitar.Location = New System.Drawing.Point(136, 291)
        Me.BQuitar.Name = "BQuitar"
        Me.BQuitar.Size = New System.Drawing.Size(75, 68)
        Me.BQuitar.TabIndex = 745
        Me.BQuitar.UseVisualStyleBackColor = True
        '
        'BAgregar
        '
        Me.BAgregar.BackgroundImage = CType(resources.GetObject("BAgregar.BackgroundImage"), System.Drawing.Image)
        Me.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BAgregar.Location = New System.Drawing.Point(38, 291)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(75, 68)
        Me.BAgregar.TabIndex = 744
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.AutoSize = True
        Me.Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar.ForeColor = System.Drawing.Color.Navy
        Me.Agregar.Location = New System.Drawing.Point(40, 362)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(68, 13)
        Me.Agregar.TabIndex = 747
        Me.Agregar.Text = "Agregar Foto"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(145, 362)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(59, 13)
        Me.Label39.TabIndex = 748
        Me.Label39.Text = "Quitar Foto"
        '
        'TGrupoS
        '
        Me.TGrupoS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TGrupoS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGrupoS.Location = New System.Drawing.Point(977, 337)
        Me.TGrupoS.MaxLength = 14
        Me.TGrupoS.Name = "TGrupoS"
        Me.TGrupoS.Size = New System.Drawing.Size(144, 26)
        Me.TGrupoS.TabIndex = 755
        Me.TGrupoS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(977, 315)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(139, 20)
        Me.Label24.TabIndex = 756
        Me.Label24.Text = "Grupo Sanguíneo:"
        '
        'TTelfContacto
        '
        Me.TTelfContacto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TTelfContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTelfContacto.Location = New System.Drawing.Point(548, 401)
        Me.TTelfContacto.Name = "TTelfContacto"
        Me.TTelfContacto.Size = New System.Drawing.Size(287, 26)
        Me.TTelfContacto.TabIndex = 754
        Me.TTelfContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TContacto
        '
        Me.TContacto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TContacto.Location = New System.Drawing.Point(255, 401)
        Me.TContacto.Name = "TContacto"
        Me.TContacto.Size = New System.Drawing.Size(287, 26)
        Me.TContacto.TabIndex = 751
        Me.TContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(548, 379)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(116, 20)
        Me.Label22.TabIndex = 753
        Me.Label22.Text = "Telf.  Contacto:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(255, 379)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(189, 20)
        Me.Label23.TabIndex = 752
        Me.Label23.Text = "Contacto de Emergencia:"
        '
        'TCelular
        '
        Me.TCelular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCelular.Location = New System.Drawing.Point(741, 186)
        Me.TCelular.MaxLength = 14
        Me.TCelular.Name = "TCelular"
        Me.TCelular.Size = New System.Drawing.Size(121, 26)
        Me.TCelular.TabIndex = 724
        '
        'TTelefono
        '
        Me.TTelefono.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTelefono.Location = New System.Drawing.Point(614, 186)
        Me.TTelefono.MaxLength = 14
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(120, 26)
        Me.TTelefono.TabIndex = 721
        '
        'TCI
        '
        Me.TCI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCI.Location = New System.Drawing.Point(434, 113)
        Me.TCI.MaxLength = 8
        Me.TCI.Name = "TCI"
        Me.TCI.Size = New System.Drawing.Size(173, 26)
        Me.TCI.TabIndex = 715
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(616, 113)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(504, 26)
        Me.TNombre.TabIndex = 716
        '
        'TCodigo
        '
        Me.TCodigo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(255, 42)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.ReadOnly = True
        Me.TCodigo.Size = New System.Drawing.Size(135, 26)
        Me.TCodigo.TabIndex = 707
        Me.TCodigo.Tag = "0"
        Me.TCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TDireccion
        '
        Me.TDireccion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDireccion.Location = New System.Drawing.Point(255, 253)
        Me.TDireccion.Multiline = True
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(866, 50)
        Me.TDireccion.TabIndex = 704
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(741, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 723
        Me.Label6.Text = "Celular:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(617, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 722
        Me.Label10.Text = "Teléfono:"
        '
        'FechaIng
        '
        Me.FechaIng.CustomFormat = "dd/MM/yyyy"
        Me.FechaIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaIng.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaIng.Location = New System.Drawing.Point(255, 113)
        Me.FechaIng.Name = "FechaIng"
        Me.FechaIng.Size = New System.Drawing.Size(116, 26)
        Me.FechaIng.TabIndex = 719
        Me.FechaIng.Value = New Date(2024, 6, 28, 0, 0, 0, 0)
        '
        'CNacionalidad
        '
        Me.CNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNacionalidad.FormattingEnabled = True
        Me.CNacionalidad.Items.AddRange(New Object() {"V", "E"})
        Me.CNacionalidad.Location = New System.Drawing.Point(380, 113)
        Me.CNacionalidad.Name = "CNacionalidad"
        Me.CNacionalidad.Size = New System.Drawing.Size(45, 26)
        Me.CNacionalidad.TabIndex = 714
        '
        'CBActivo
        '
        Me.CBActivo.AutoSize = True
        Me.CBActivo.Checked = True
        Me.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBActivo.ForeColor = System.Drawing.Color.Navy
        Me.CBActivo.Location = New System.Drawing.Point(79, 9)
        Me.CBActivo.Name = "CBActivo"
        Me.CBActivo.Size = New System.Drawing.Size(97, 30)
        Me.CBActivo.TabIndex = 712
        Me.CBActivo.Text = "Activo."
        Me.CBActivo.UseVisualStyleBackColor = True
        '
        'Zona
        '
        Me.Zona.Controls.Add(Me.SanFelix)
        Me.Zona.Controls.Add(Me.PtoOrdaz)
        Me.Zona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zona.ForeColor = System.Drawing.Color.Navy
        Me.Zona.Location = New System.Drawing.Point(876, 150)
        Me.Zona.Name = "Zona"
        Me.Zona.Size = New System.Drawing.Size(245, 62)
        Me.Zona.TabIndex = 711
        Me.Zona.TabStop = False
        Me.Zona.Tag = "Pto Ordaz"
        Me.Zona.Text = "Zona: "
        '
        'SanFelix
        '
        Me.SanFelix.AutoSize = True
        Me.SanFelix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SanFelix.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SanFelix.Location = New System.Drawing.Point(123, 27)
        Me.SanFelix.Name = "SanFelix"
        Me.SanFelix.Size = New System.Drawing.Size(96, 24)
        Me.SanFelix.TabIndex = 8
        Me.SanFelix.Text = "San Felix."
        Me.SanFelix.UseVisualStyleBackColor = True
        '
        'PtoOrdaz
        '
        Me.PtoOrdaz.AutoSize = True
        Me.PtoOrdaz.Checked = True
        Me.PtoOrdaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PtoOrdaz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PtoOrdaz.Location = New System.Drawing.Point(17, 27)
        Me.PtoOrdaz.Name = "PtoOrdaz"
        Me.PtoOrdaz.Size = New System.Drawing.Size(102, 24)
        Me.PtoOrdaz.TabIndex = 7
        Me.PtoOrdaz.TabStop = True
        Me.PtoOrdaz.Text = "Pto. Ordaz"
        Me.PtoOrdaz.UseVisualStyleBackColor = True
        '
        'CCargo
        '
        Me.CCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CCargo.BackColor = System.Drawing.Color.White
        Me.CCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCargo.FormattingEnabled = True
        Me.CCargo.ItemHeight = 18
        Me.CCargo.Location = New System.Drawing.Point(401, 42)
        Me.CCargo.Margin = New System.Windows.Forms.Padding(0)
        Me.CCargo.Name = "CCargo"
        Me.CCargo.Size = New System.Drawing.Size(245, 26)
        Me.CCargo.TabIndex = 710
        Me.CCargo.Tag = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(403, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 709
        Me.Label3.Text = "Cargo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(255, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 20)
        Me.Label8.TabIndex = 705
        Me.Label8.Text = "Correo Electrónico:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(255, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 703
        Me.Label5.Text = "Dirección:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(255, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 706
        Me.Label9.Text = "Código:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(378, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 718
        Me.Label1.Text = "Nac.:"
        Me.ToolTip1.SetToolTip(Me.Label1, "Nacionalidad.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(432, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 717
        Me.Label4.Text = "Cédula: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(617, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(257, 20)
        Me.Label7.TabIndex = 713
        Me.Label7.Text = "Nombres y Apellidos del Empleado:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(255, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 20)
        Me.Label19.TabIndex = 720
        Me.Label19.Text = "Fecha Ingreso:"
        '
        'Dialogo
        '
        Me.Dialogo.FileName = "SinImagen"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Location = New System.Drawing.Point(3, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 34)
        Me.Label14.TabIndex = 705
        Me.Label14.Text = "Empleado:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LEmpleado
        '
        Me.LEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpleado.ForeColor = System.Drawing.Color.Navy
        Me.LEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LEmpleado.Location = New System.Drawing.Point(135, 9)
        Me.LEmpleado.Name = "LEmpleado"
        Me.LEmpleado.Size = New System.Drawing.Size(822, 34)
        Me.LEmpleado.TabIndex = 704
        Me.LEmpleado.Text = "Seleccione el Empleado"
        Me.LEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LEmpleado)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1148, 50)
        Me.Panel1.TabIndex = 706
        '
        'FEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1148, 604)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Ficha de Empleado."
        Me.MenuCat.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        CType(Me.FotoNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Zona.ResumeLayout(False)
        Me.Zona.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuCat As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CrearCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurarCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents General As System.Windows.Forms.TabPage
    Friend WithEvents TCelular As System.Windows.Forms.TextBox
    Friend WithEvents TTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TCI As System.Windows.Forms.TextBox
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents FechaIng As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CNacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Zona As System.Windows.Forms.GroupBox
    Friend WithEvents SanFelix As System.Windows.Forms.RadioButton
    Friend WithEvents PtoOrdaz As System.Windows.Forms.RadioButton
    Friend WithEvents CCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Foto As System.Windows.Forms.PictureBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Agregar As System.Windows.Forms.Label
    Friend WithEvents BQuitar As System.Windows.Forms.Button
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents Dialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TGrupoS As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TTelfContacto As System.Windows.Forms.TextBox
    Friend WithEvents TContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents FechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents TParentesco As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents THijos As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents CEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TEdad As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LEmpleado As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FotoNew As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TCorreo As System.Windows.Forms.TextBox
    Friend WithEvents BCargaos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents CBOpto As System.Windows.Forms.CheckBox
    Friend WithEvents CBAsesor As System.Windows.Forms.CheckBox
    Friend WithEvents CBMarketing As System.Windows.Forms.CheckBox
    Friend WithEvents CBGerente As System.Windows.Forms.CheckBox
End Class
