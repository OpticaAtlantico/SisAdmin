<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPrincipal2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPrincipal2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BMantenimiento = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BReportes = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(953, 144)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Vivaldi", 35.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(0, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(953, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sistema Administrativo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BMantenimiento
        '
        Me.BMantenimiento.BackColor = System.Drawing.Color.LightCyan
        Me.BMantenimiento.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMantenimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BMantenimiento.Image = CType(resources.GetObject("BMantenimiento.Image"), System.Drawing.Image)
        Me.BMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BMantenimiento.Location = New System.Drawing.Point(97, 257)
        Me.BMantenimiento.Name = "BMantenimiento"
        Me.BMantenimiento.Size = New System.Drawing.Size(341, 72)
        Me.BMantenimiento.TabIndex = 74
        Me.BMantenimiento.Text = "   Facturación"
        Me.BMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BMantenimiento.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(466, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(341, 72)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "   Cierre de Caja"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BReportes
        '
        Me.BReportes.BackColor = System.Drawing.Color.LightCyan
        Me.BReportes.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BReportes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BReportes.Image = CType(resources.GetObject("BReportes.Image"), System.Drawing.Image)
        Me.BReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BReportes.Location = New System.Drawing.Point(466, 344)
        Me.BReportes.Name = "BReportes"
        Me.BReportes.Size = New System.Drawing.Size(341, 72)
        Me.BReportes.TabIndex = 77
        Me.BReportes.Text = "   Reportes"
        Me.BReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BReportes.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(897, 545)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Salir"
        '
        'BSalir
        '
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.Location = New System.Drawing.Point(878, 490)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(63, 52)
        Me.BSalir.TabIndex = 78
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightCyan
        Me.Button4.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(97, 344)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(341, 72)
        Me.Button4.TabIndex = 76
        Me.Button4.Text = "  Analisis Ventas"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightCyan
        Me.Button5.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(466, 344)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(341, 72)
        Me.Button5.TabIndex = 77
        Me.Button5.Text = "   Reporte Ventas"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'FPrincipal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(953, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BReportes)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BMantenimiento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FPrincipal2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Principal."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BMantenimiento As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BReportes As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
