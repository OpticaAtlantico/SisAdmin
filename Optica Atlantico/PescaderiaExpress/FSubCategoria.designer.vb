<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSubCategoria
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSubCategoria))
        Me.GridCategoria = New System.Windows.Forms.DataGridView()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idSubCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.Editar = New System.Windows.Forms.ToolStripButton()
        Me.Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CCategoria1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GridCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridCategoria
        '
        Me.GridCategoria.AllowUserToAddRows = False
        Me.GridCategoria.AllowUserToDeleteRows = False
        Me.GridCategoria.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridCategoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.idCategoria, Me.Categoria, Me.idSubCategoria, Me.SubCategoria})
        Me.GridCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCategoria.EnableHeadersVisualStyles = False
        Me.GridCategoria.Location = New System.Drawing.Point(0, 164)
        Me.GridCategoria.Name = "GridCategoria"
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridCategoria.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GridCategoria.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.GridCategoria.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.GridCategoria.RowTemplate.Height = 25
        Me.GridCategoria.RowTemplate.ReadOnly = True
        Me.GridCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GridCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridCategoria.Size = New System.Drawing.Size(949, 497)
        Me.GridCategoria.TabIndex = 309
        '
        'Num
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Num.DefaultCellStyle = DataGridViewCellStyle2
        Me.Num.HeaderText = "Nº"
        Me.Num.Name = "Num"
        Me.Num.Width = 80
        '
        'idCategoria
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.idCategoria.DefaultCellStyle = DataGridViewCellStyle3
        Me.idCategoria.HeaderText = "Código"
        Me.idCategoria.Name = "idCategoria"
        Me.idCategoria.ReadOnly = True
        Me.idCategoria.ToolTipText = "Código Categoria."
        Me.idCategoria.Width = 120
        '
        'Categoria
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Categoria.DefaultCellStyle = DataGridViewCellStyle4
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Width = 300
        '
        'idSubCategoria
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.idSubCategoria.DefaultCellStyle = DataGridViewCellStyle5
        Me.idSubCategoria.HeaderText = "Código"
        Me.idSubCategoria.Name = "idSubCategoria"
        Me.idSubCategoria.ReadOnly = True
        Me.idSubCategoria.ToolTipText = "Código Sub-Categoria."
        Me.idSubCategoria.Width = 120
        '
        'SubCategoria
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.SubCategoria.DefaultCellStyle = DataGridViewCellStyle6
        Me.SubCategoria.HeaderText = "Sub Categoria"
        Me.SubCategoria.Name = "SubCategoria"
        Me.SubCategoria.Width = 300
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(292, 41)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(247, 29)
        Me.TNombre.TabIndex = 308
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(292, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 307
        Me.Label4.Text = "Sub Categoria:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.Guardar, Me.Editar, Me.Eliminar, Me.Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(949, 73)
        Me.ToolStrip1.TabIndex = 306
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Nuevo
        '
        Me.Nuevo.AutoSize = False
        Me.Nuevo.ForeColor = System.Drawing.Color.Navy
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(100, 70)
        Me.Nuevo.Text = "     Nuevo     "
        Me.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Guardar
        '
        Me.Guardar.AutoSize = False
        Me.Guardar.ForeColor = System.Drawing.Color.Navy
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(100, 70)
        Me.Guardar.Text = "     Guardar     "
        Me.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Guardar.ToolTipText = "Guardar."
        '
        'Editar
        '
        Me.Editar.AutoSize = False
        Me.Editar.ForeColor = System.Drawing.Color.Navy
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(100, 70)
        Me.Editar.Text = "     Actualizar     "
        Me.Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Editar.ToolTipText = "Editar."
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(17, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 311
        Me.Label7.Text = "Categoria:"
        '
        'CCategoria1
        '
        Me.CCategoria1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CCategoria1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCategoria1.FormattingEnabled = True
        Me.CCategoria1.Location = New System.Drawing.Point(17, 42)
        Me.CCategoria1.Name = "CCategoria1"
        Me.CCategoria1.Size = New System.Drawing.Size(246, 28)
        Me.CCategoria1.TabIndex = 310
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CCategoria1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(949, 91)
        Me.Panel1.TabIndex = 313
        '
        'FSubCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(949, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridCategoria)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FSubCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: SubCategoria de Gastos."
        CType(Me.GridCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridCategoria As System.Windows.Forms.DataGridView
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CCategoria1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idSubCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
