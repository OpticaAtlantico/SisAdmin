<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBuscarGenericoxx
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBuscarGenericoxx))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BActualizar = New System.Windows.Forms.Button()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.LCodigo = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.GridBuscar = New System.Windows.Forms.DataGridView()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Salir, Me.Guardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(657, 70)
        Me.ToolStrip1.TabIndex = 5
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
        'Guardar
        '
        Me.Guardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Guardar.ForeColor = System.Drawing.Color.Navy
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(71, 67)
        Me.Guardar.Text = "Seleccionar"
        Me.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Guardar.ToolTipText = "Guardar."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BActualizar)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.LCodigo)
        Me.GroupBox1.Controls.Add(Me.TNombre)
        Me.GroupBox1.Controls.Add(Me.LNombre)
        Me.GroupBox1.Controls.Add(Me.TCodigo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 144)
        Me.GroupBox1.TabIndex = 235
        Me.GroupBox1.TabStop = False
        '
        'BActualizar
        '
        Me.BActualizar.BackColor = System.Drawing.Color.Transparent
        Me.BActualizar.BackgroundImage = CType(resources.GetObject("BActualizar.BackgroundImage"), System.Drawing.Image)
        Me.BActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BActualizar.Location = New System.Drawing.Point(488, 17)
        Me.BActualizar.Name = "BActualizar"
        Me.BActualizar.Size = New System.Drawing.Size(123, 103)
        Me.BActualizar.TabIndex = 964
        Me.BActualizar.UseVisualStyleBackColor = False
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(488, 118)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(123, 18)
        Me.Label45.TabIndex = 965
        Me.Label45.Text = "Buscar"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LCodigo
        '
        Me.LCodigo.AutoSize = True
        Me.LCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCodigo.ForeColor = System.Drawing.Color.Navy
        Me.LCodigo.Location = New System.Drawing.Point(12, 17)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(63, 20)
        Me.LCodigo.TabIndex = 236
        Me.LCodigo.Text = "Código:"
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(12, 100)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(392, 26)
        Me.TNombre.TabIndex = 1
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.Navy
        Me.LNombre.Location = New System.Drawing.Point(12, 77)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(69, 20)
        Me.LNombre.TabIndex = 233
        Me.LNombre.Text = "Nombre:"
        '
        'TCodigo
        '
        Me.TCodigo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(12, 40)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(149, 26)
        Me.TCodigo.TabIndex = 2
        Me.TCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GridBuscar
        '
        Me.GridBuscar.AllowUserToAddRows = False
        Me.GridBuscar.AllowUserToDeleteRows = False
        Me.GridBuscar.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridBuscar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
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
        Me.GridBuscar.Location = New System.Drawing.Point(0, 214)
        Me.GridBuscar.Name = "GridBuscar"
        Me.GridBuscar.ReadOnly = True
        Me.GridBuscar.RowHeadersVisible = False
        Me.GridBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridBuscar.Size = New System.Drawing.Size(657, 415)
        Me.GridBuscar.TabIndex = 4
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.White
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LTitulo.Location = New System.Drawing.Point(21, 18)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(473, 34)
        Me.LTitulo.TabIndex = 237
        Me.LTitulo.Text = "Titulo."
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FBuscarGenericoxx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(657, 629)
        Me.ControlBox = False
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.GridBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FBuscarGenericoxx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Buscar."
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LCodigo As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GridBuscar As System.Windows.Forms.DataGridView
    Friend WithEvents LTitulo As System.Windows.Forms.Label
    Friend WithEvents BActualizar As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
End Class
