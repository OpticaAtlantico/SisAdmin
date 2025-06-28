<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBuscarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBuscarProducto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.Seleccionar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBActivo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.BExportar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CSubCategoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CCategoria = New System.Windows.Forms.ComboBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.LCodigo = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.GridBuscar = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.White
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LTitulo.Location = New System.Drawing.Point(23, 16)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(816, 34)
        Me.LTitulo.TabIndex = 239
        Me.LTitulo.Text = "Listado de Productos."
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Salir, Me.Seleccionar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(993, 70)
        Me.ToolStrip1.TabIndex = 238
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
        'Seleccionar
        '
        Me.Seleccionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Seleccionar.ForeColor = System.Drawing.Color.Navy
        Me.Seleccionar.Image = CType(resources.GetObject("Seleccionar.Image"), System.Drawing.Image)
        Me.Seleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Size = New System.Drawing.Size(71, 67)
        Me.Seleccionar.Text = "Seleccionar"
        Me.Seleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Seleccionar.ToolTipText = "Seleccionar Producto."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CBActivo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.BExportar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CSubCategoria)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CCategoria)
        Me.Panel1.Controls.Add(Me.BBuscar)
        Me.Panel1.Controls.Add(Me.LCodigo)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.TCodigo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(993, 191)
        Me.Panel1.TabIndex = 240
        '
        'CBActivo
        '
        Me.CBActivo.AutoSize = True
        Me.CBActivo.Checked = True
        Me.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBActivo.ForeColor = System.Drawing.Color.Navy
        Me.CBActivo.Location = New System.Drawing.Point(377, 128)
        Me.CBActivo.Name = "CBActivo"
        Me.CBActivo.Size = New System.Drawing.Size(75, 24)
        Me.CBActivo.TabIndex = 971
        Me.CBActivo.Text = "Activo."
        Me.CBActivo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(666, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 18)
        Me.Label4.TabIndex = 970
        Me.Label4.Text = "Buscar Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(826, 141)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(119, 18)
        Me.Label33.TabIndex = 969
        Me.Label33.Text = "Exportar Excel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BExportar
        '
        Me.BExportar.BackColor = System.Drawing.Color.White
        Me.BExportar.BackgroundImage = CType(resources.GetObject("BExportar.BackgroundImage"), System.Drawing.Image)
        Me.BExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BExportar.Location = New System.Drawing.Point(826, 29)
        Me.BExportar.Name = "BExportar"
        Me.BExportar.Size = New System.Drawing.Size(119, 109)
        Me.BExportar.TabIndex = 968
        Me.BExportar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(18, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 245
        Me.Label2.Text = "Sub-Categoria:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CSubCategoria
        '
        Me.CSubCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSubCategoria.FormattingEnabled = True
        Me.CSubCategoria.Location = New System.Drawing.Point(141, 128)
        Me.CSubCategoria.Name = "CSubCategoria"
        Me.CSubCategoria.Size = New System.Drawing.Size(212, 28)
        Me.CSubCategoria.TabIndex = 244
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(17, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 243
        Me.Label1.Text = "Categoria:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CCategoria
        '
        Me.CCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCategoria.FormattingEnabled = True
        Me.CCategoria.Location = New System.Drawing.Point(140, 93)
        Me.CCategoria.Name = "CCategoria"
        Me.CCategoria.Size = New System.Drawing.Size(212, 28)
        Me.CCategoria.TabIndex = 242
        '
        'BBuscar
        '
        Me.BBuscar.BackgroundImage = CType(resources.GetObject("BBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBuscar.Location = New System.Drawing.Point(666, 29)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(119, 109)
        Me.BBuscar.TabIndex = 239
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'LCodigo
        '
        Me.LCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCodigo.ForeColor = System.Drawing.Color.Navy
        Me.LCodigo.Location = New System.Drawing.Point(18, 29)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(117, 20)
        Me.LCodigo.TabIndex = 241
        Me.LCodigo.Text = "Código:"
        Me.LCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(140, 60)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(484, 26)
        Me.TNombre.TabIndex = 237
        '
        'LNombre
        '
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.Navy
        Me.LNombre.Location = New System.Drawing.Point(18, 63)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(117, 20)
        Me.LNombre.TabIndex = 240
        Me.LNombre.Text = "Nombre:"
        Me.LNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TCodigo
        '
        Me.TCodigo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(140, 27)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(212, 26)
        Me.TCodigo.TabIndex = 238
        Me.TCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GridBuscar
        '
        Me.GridBuscar.AllowUserToAddRows = False
        Me.GridBuscar.AllowUserToDeleteRows = False
        Me.GridBuscar.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridBuscar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridBuscar.ColumnHeadersHeight = 28
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridBuscar.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBuscar.EnableHeadersVisualStyles = False
        Me.GridBuscar.Location = New System.Drawing.Point(0, 261)
        Me.GridBuscar.Name = "GridBuscar"
        Me.GridBuscar.ReadOnly = True
        Me.GridBuscar.RowHeadersVisible = False
        Me.GridBuscar.RowTemplate.Height = 25
        Me.GridBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridBuscar.Size = New System.Drawing.Size(993, 488)
        Me.GridBuscar.TabIndex = 241
        '
        'FBuscarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(993, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FBuscarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Buscar Productos."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LTitulo As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Seleccionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridBuscar As System.Windows.Forms.DataGridView
    Friend WithEvents BBuscar As System.Windows.Forms.Button
    Friend WithEvents LCodigo As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CSubCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BExportar As System.Windows.Forms.Button
    Friend WithEvents CBActivo As System.Windows.Forms.CheckBox
End Class
