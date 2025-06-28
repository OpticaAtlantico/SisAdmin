<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCategoria))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.Editar = New System.Windows.Forms.ToolStripButton()
        Me.Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GridCategoria = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.Guardar, Me.Editar, Me.Eliminar, Me.Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(573, 70)
        Me.ToolStrip1.TabIndex = 129
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Nuevo
        '
        Me.Nuevo.ForeColor = System.Drawing.Color.Navy
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(76, 67)
        Me.Nuevo.Text = "     Nuevo     "
        Me.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Guardar
        '
        Me.Guardar.ForeColor = System.Drawing.Color.Navy
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(83, 67)
        Me.Guardar.Text = "     Guardar     "
        Me.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Guardar.ToolTipText = "Guardar."
        '
        'Editar
        '
        Me.Editar.ForeColor = System.Drawing.Color.Navy
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(93, 67)
        Me.Editar.Text = "     Actualizar     "
        Me.Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Editar.ToolTipText = "Editar."
        '
        'Eliminar
        '
        Me.Eliminar.ForeColor = System.Drawing.Color.Navy
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(84, 67)
        Me.Eliminar.Text = "     Eliminar     "
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
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(14, 39)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(533, 29)
        Me.TNombre.TabIndex = 131
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(14, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 24)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Nombre de Categoria:"
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
        Me.GridCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.id, Me.Categoria})
        Me.GridCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCategoria.EnableHeadersVisualStyles = False
        Me.GridCategoria.Location = New System.Drawing.Point(0, 158)
        Me.GridCategoria.Name = "GridCategoria"
        Me.GridCategoria.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridCategoria.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GridCategoria.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.GridCategoria.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GridCategoria.RowTemplate.ReadOnly = True
        Me.GridCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GridCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridCategoria.Size = New System.Drawing.Size(573, 503)
        Me.GridCategoria.TabIndex = 305
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 88)
        Me.Panel1.TabIndex = 307
        '
        'Num
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Num.DefaultCellStyle = DataGridViewCellStyle2
        Me.Num.HeaderText = "Nº"
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        Me.Num.Width = 70
        '
        'id
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.id.DefaultCellStyle = DataGridViewCellStyle3
        Me.id.HeaderText = "Cód."
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.ToolTipText = "Código"
        Me.id.Width = 80
        '
        'Categoria
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Categoria.DefaultCellStyle = DataGridViewCellStyle4
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        Me.Categoria.Width = 400
        '
        'FCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(573, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridCategoria)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Categorias de Gastos."
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridCategoria As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
