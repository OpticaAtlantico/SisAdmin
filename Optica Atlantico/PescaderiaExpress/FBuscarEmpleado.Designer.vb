<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBuscarEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBuscarEmpleado))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LBBuscar = New System.Windows.Forms.Label()
        Me.BEmpleados = New System.Windows.Forms.Button()
        Me.TCedula = New System.Windows.Forms.TextBox()
        Me.LCedula = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.Selecionar = New System.Windows.Forms.ToolStripButton()
        Me.GridEmpleados = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.BExportarNA = New System.Windows.Forms.Button()
        Me.FechaIng = New System.Windows.Forms.DateTimePicker()
        Me.TTipo = New System.Windows.Forms.ComboBox()
        Me.CBActivo = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CCargo = New System.Windows.Forms.ComboBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BImprimir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBBuscar
        '
        Me.LBBuscar.ForeColor = System.Drawing.Color.Navy
        Me.LBBuscar.Location = New System.Drawing.Point(721, 98)
        Me.LBBuscar.Name = "LBBuscar"
        Me.LBBuscar.Size = New System.Drawing.Size(96, 13)
        Me.LBBuscar.TabIndex = 914
        Me.LBBuscar.Text = "Buscar Empleado"
        Me.LBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BEmpleados
        '
        Me.BEmpleados.BackColor = System.Drawing.Color.White
        Me.BEmpleados.BackgroundImage = CType(resources.GetObject("BEmpleados.BackgroundImage"), System.Drawing.Image)
        Me.BEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BEmpleados.CausesValidation = False
        Me.BEmpleados.Location = New System.Drawing.Point(721, 13)
        Me.BEmpleados.Name = "BEmpleados"
        Me.BEmpleados.Size = New System.Drawing.Size(96, 82)
        Me.BEmpleados.TabIndex = 910
        Me.BEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BEmpleados.UseVisualStyleBackColor = False
        '
        'TCedula
        '
        Me.TCedula.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCedula.Location = New System.Drawing.Point(131, 51)
        Me.TCedula.MaxLength = 8
        Me.TCedula.Name = "TCedula"
        Me.TCedula.Size = New System.Drawing.Size(188, 26)
        Me.TCedula.TabIndex = 907
        '
        'LCedula
        '
        Me.LCedula.BackColor = System.Drawing.Color.Transparent
        Me.LCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCedula.ForeColor = System.Drawing.Color.Navy
        Me.LCedula.Location = New System.Drawing.Point(44, 51)
        Me.LCedula.Name = "LCedula"
        Me.LCedula.Size = New System.Drawing.Size(84, 26)
        Me.LCedula.TabIndex = 911
        Me.LCedula.Text = "Cédula:"
        Me.LCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(131, 89)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(188, 26)
        Me.TNombre.TabIndex = 915
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(44, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 26)
        Me.Label2.TabIndex = 916
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.White
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LTitulo.Location = New System.Drawing.Point(23, 18)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(768, 34)
        Me.LTitulo.TabIndex = 921
        Me.LTitulo.Text = "Listado de Empleados."
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Salir, Me.Selecionar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(988, 70)
        Me.ToolStrip1.TabIndex = 920
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.ForeColor = System.Drawing.Color.Navy
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(52, 67)
        Me.Salir.Text = "Salir"
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Salir.ToolTipText = "Salir."
        '
        'Selecionar
        '
        Me.Selecionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Selecionar.ForeColor = System.Drawing.Color.Navy
        Me.Selecionar.Image = CType(resources.GetObject("Selecionar.Image"), System.Drawing.Image)
        Me.Selecionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Selecionar.Name = "Selecionar"
        Me.Selecionar.Size = New System.Drawing.Size(71, 67)
        Me.Selecionar.Text = "Seleccionar"
        Me.Selecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Selecionar.ToolTipText = "Guardar."
        '
        'GridEmpleados
        '
        Me.GridEmpleados.AllowUserToAddRows = False
        Me.GridEmpleados.AllowUserToDeleteRows = False
        Me.GridEmpleados.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridEmpleados.ColumnHeadersHeight = 28
        Me.GridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEmpleados.EnableHeadersVisualStyles = False
        Me.GridEmpleados.Location = New System.Drawing.Point(0, 235)
        Me.GridEmpleados.Name = "GridEmpleados"
        Me.GridEmpleados.ReadOnly = True
        Me.GridEmpleados.RowHeadersVisible = False
        Me.GridEmpleados.RowHeadersWidth = 50
        Me.GridEmpleados.RowTemplate.Height = 80
        Me.GridEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridEmpleados.Size = New System.Drawing.Size(988, 507)
        Me.GridEmpleados.TabIndex = 922
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label37)
        Me.Panel1.Controls.Add(Me.BExportarNA)
        Me.Panel1.Controls.Add(Me.FechaIng)
        Me.Panel1.Controls.Add(Me.TTipo)
        Me.Panel1.Controls.Add(Me.CBActivo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.CCargo)
        Me.Panel1.Controls.Add(Me.TCodigo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.BImprimir)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TApellido)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TCedula)
        Me.Panel1.Controls.Add(Me.LCedula)
        Me.Panel1.Controls.Add(Me.BEmpleados)
        Me.Panel1.Controls.Add(Me.LBBuscar)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 165)
        Me.Panel1.TabIndex = 923
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Navy
        Me.Label37.Location = New System.Drawing.Point(839, 98)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(96, 18)
        Me.Label37.TabIndex = 975
        Me.Label37.Text = "Exportar Excel"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BExportarNA
        '
        Me.BExportarNA.BackColor = System.Drawing.Color.White
        Me.BExportarNA.BackgroundImage = CType(resources.GetObject("BExportarNA.BackgroundImage"), System.Drawing.Image)
        Me.BExportarNA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BExportarNA.Location = New System.Drawing.Point(839, 13)
        Me.BExportarNA.Name = "BExportarNA"
        Me.BExportarNA.Size = New System.Drawing.Size(96, 82)
        Me.BExportarNA.TabIndex = 974
        Me.BExportarNA.UseVisualStyleBackColor = False
        '
        'FechaIng
        '
        Me.FechaIng.CustomFormat = "dd/MM/yyyy"
        Me.FechaIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaIng.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaIng.Location = New System.Drawing.Point(522, 13)
        Me.FechaIng.Name = "FechaIng"
        Me.FechaIng.Size = New System.Drawing.Size(133, 29)
        Me.FechaIng.TabIndex = 959
        Me.FechaIng.Value = New Date(2014, 9, 27, 0, 0, 0, 0)
        '
        'TTipo
        '
        Me.TTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TTipo.BackColor = System.Drawing.Color.White
        Me.TTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTipo.FormattingEnabled = True
        Me.TTipo.ItemHeight = 20
        Me.TTipo.Items.AddRange(New Object() {" ", "=", "<", ">"})
        Me.TTipo.Location = New System.Drawing.Point(467, 13)
        Me.TTipo.Margin = New System.Windows.Forms.Padding(0)
        Me.TTipo.Name = "TTipo"
        Me.TTipo.Size = New System.Drawing.Size(49, 28)
        Me.TTipo.TabIndex = 958
        '
        'CBActivo
        '
        Me.CBActivo.AutoSize = True
        Me.CBActivo.Checked = True
        Me.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBActivo.ForeColor = System.Drawing.Color.Navy
        Me.CBActivo.Location = New System.Drawing.Point(467, 91)
        Me.CBActivo.Name = "CBActivo"
        Me.CBActivo.Size = New System.Drawing.Size(75, 24)
        Me.CBActivo.TabIndex = 957
        Me.CBActivo.Text = "Activo."
        Me.CBActivo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(338, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 26)
        Me.Label9.TabIndex = 952
        Me.Label9.Text = "Fecha Ingreso:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CCargo
        '
        Me.CCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CCargo.BackColor = System.Drawing.Color.White
        Me.CCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCargo.FormattingEnabled = True
        Me.CCargo.ItemHeight = 20
        Me.CCargo.Location = New System.Drawing.Point(467, 51)
        Me.CCargo.Margin = New System.Windows.Forms.Padding(0)
        Me.CCargo.Name = "CCargo"
        Me.CCargo.Size = New System.Drawing.Size(188, 28)
        Me.CCargo.TabIndex = 945
        '
        'TCodigo
        '
        Me.TCodigo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(131, 13)
        Me.TCodigo.MaxLength = 8
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(188, 26)
        Me.TCodigo.TabIndex = 924
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(44, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 925
        Me.Label6.Text = "Código:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BImprimir
        '
        Me.BImprimir.BackColor = System.Drawing.Color.White
        Me.BImprimir.BackgroundImage = CType(resources.GetObject("BImprimir.BackgroundImage"), System.Drawing.Image)
        Me.BImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BImprimir.CausesValidation = False
        Me.BImprimir.Location = New System.Drawing.Point(1060, 32)
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Size = New System.Drawing.Size(96, 82)
        Me.BImprimir.TabIndex = 921
        Me.BImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BImprimir.UseVisualStyleBackColor = False
        Me.BImprimir.Visible = False
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(1060, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 922
        Me.Label5.Text = "Imprimir"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'TApellido
        '
        Me.TApellido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TApellido.Location = New System.Drawing.Point(131, 127)
        Me.TApellido.MaxLength = 10
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(188, 26)
        Me.TApellido.TabIndex = 917
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(44, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 26)
        Me.Label3.TabIndex = 918
        Me.Label3.Text = "Apellido:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(380, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 26)
        Me.Label4.TabIndex = 920
        Me.Label4.Text = "Cargo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FBuscarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(988, 742)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridEmpleados)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FBuscarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Buscar Cliente."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBBuscar As System.Windows.Forms.Label
    Friend WithEvents BEmpleados As System.Windows.Forms.Button
    Friend WithEvents TCedula As System.Windows.Forms.TextBox
    Friend WithEvents LCedula As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LTitulo As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Selecionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BImprimir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBActivo As System.Windows.Forms.CheckBox
    Friend WithEvents TTipo As System.Windows.Forms.ComboBox
    Friend WithEvents FechaIng As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents BExportarNA As System.Windows.Forms.Button
End Class
