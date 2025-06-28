<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMarca))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.Buscar = New System.Windows.Forms.ToolStripButton()
        Me.Editar = New System.Windows.Forms.ToolStripButton()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DptGeneral = New System.Windows.Forms.TabPage()
        Me.CBActivo = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TDescripcion = New System.Windows.Forms.TextBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.DptGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.Buscar, Me.ToolStripSeparator1, Me.Editar, Me.Guardar, Me.Eliminar, Me.Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(617, 73)
        Me.ToolStrip1.TabIndex = 126
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
        Me.Nuevo.Text = "Nuevo"
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
        Me.Buscar.Text = "Buscar"
        Me.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Buscar.ToolTipText = "Buscar."
        '
        'Editar
        '
        Me.Editar.AutoSize = False
        Me.Editar.ForeColor = System.Drawing.Color.Navy
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(100, 70)
        Me.Editar.Text = "Actualizar"
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
        Me.Guardar.Text = "Guardar"
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
        Me.Eliminar.Text = "Eliminar"
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
        Me.Salir.Text = "Salir"
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Salir.ToolTipText = "Salir."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DptGeneral)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(617, 229)
        Me.TabControl1.TabIndex = 127
        '
        'DptGeneral
        '
        Me.DptGeneral.BackColor = System.Drawing.Color.White
        Me.DptGeneral.Controls.Add(Me.CBActivo)
        Me.DptGeneral.Controls.Add(Me.Label23)
        Me.DptGeneral.Controls.Add(Me.Label16)
        Me.DptGeneral.Controls.Add(Me.Label15)
        Me.DptGeneral.Controls.Add(Me.TNombre)
        Me.DptGeneral.Controls.Add(Me.TDescripcion)
        Me.DptGeneral.Controls.Add(Me.TCodigo)
        Me.DptGeneral.Location = New System.Drawing.Point(4, 29)
        Me.DptGeneral.Name = "DptGeneral"
        Me.DptGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.DptGeneral.Size = New System.Drawing.Size(609, 196)
        Me.DptGeneral.TabIndex = 0
        Me.DptGeneral.Text = "General"
        '
        'CBActivo
        '
        Me.CBActivo.AutoSize = True
        Me.CBActivo.Checked = True
        Me.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBActivo.ForeColor = System.Drawing.Color.Navy
        Me.CBActivo.Location = New System.Drawing.Point(455, 41)
        Me.CBActivo.Name = "CBActivo"
        Me.CBActivo.Size = New System.Drawing.Size(75, 24)
        Me.CBActivo.TabIndex = 58
        Me.CBActivo.Text = "Activo."
        Me.CBActivo.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(15, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(168, 20)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Descripción Detallada:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(163, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 20)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Nombre:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(15, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 20)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Código:"
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(163, 41)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(276, 26)
        Me.TNombre.TabIndex = 54
        '
        'TDescripcion
        '
        Me.TDescripcion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDescripcion.Location = New System.Drawing.Point(15, 109)
        Me.TDescripcion.Multiline = True
        Me.TDescripcion.Name = "TDescripcion"
        Me.TDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TDescripcion.Size = New System.Drawing.Size(580, 66)
        Me.TDescripcion.TabIndex = 53
        '
        'TCodigo
        '
        Me.TCodigo.BackColor = System.Drawing.Color.Gainsboro
        Me.TCodigo.Enabled = False
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(15, 41)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(142, 26)
        Me.TCodigo.TabIndex = 52
        Me.TCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 73)
        '
        'FMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(617, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Marcas."
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.DptGeneral.ResumeLayout(False)
        Me.DptGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents DptGeneral As System.Windows.Forms.TabPage
    Friend WithEvents CBActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents TDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
