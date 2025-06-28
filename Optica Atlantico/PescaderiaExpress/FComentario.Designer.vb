<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FComentario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FComentario))
        Me.TComentario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LCodigo = New System.Windows.Forms.Label()
        Me.LCI = New System.Windows.Forms.Label()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.TipoMoneda = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TComentario
        '
        Me.TComentario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TComentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TComentario.Location = New System.Drawing.Point(2, 112)
        Me.TComentario.Multiline = True
        Me.TComentario.Name = "TComentario"
        Me.TComentario.Size = New System.Drawing.Size(628, 214)
        Me.TComentario.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(578, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Salir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(503, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Aceptar"
        '
        'BSalir
        '
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.Location = New System.Drawing.Point(562, 333)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(63, 52)
        Me.BSalir.TabIndex = 23
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Image = CType(resources.GetObject("BAceptar.Image"), System.Drawing.Image)
        Me.BAceptar.Location = New System.Drawing.Point(493, 333)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(63, 52)
        Me.BAceptar.TabIndex = 22
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.LCodigo)
        Me.Panel1.Controls.Add(Me.LCI)
        Me.Panel1.Controls.Add(Me.LCliente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 74)
        Me.Panel1.TabIndex = 26
        '
        'LNombre
        '
        Me.LNombre.BackColor = System.Drawing.Color.Transparent
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.Black
        Me.LNombre.Location = New System.Drawing.Point(183, 34)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(442, 34)
        Me.LNombre.TabIndex = 224
        Me.LNombre.Text = "Coca Cola"
        Me.LNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LCodigo
        '
        Me.LCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCodigo.ForeColor = System.Drawing.Color.Black
        Me.LCodigo.Location = New System.Drawing.Point(183, 0)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(442, 34)
        Me.LCodigo.TabIndex = 223
        Me.LCodigo.Text = "050505"
        Me.LCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LCI
        '
        Me.LCI.BackColor = System.Drawing.Color.Transparent
        Me.LCI.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCI.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LCI.Location = New System.Drawing.Point(3, 34)
        Me.LCI.Name = "LCI"
        Me.LCI.Size = New System.Drawing.Size(174, 34)
        Me.LCI.TabIndex = 222
        Me.LCI.Text = "Producto:"
        Me.LCI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LCliente
        '
        Me.LCliente.BackColor = System.Drawing.Color.Transparent
        Me.LCliente.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCliente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LCliente.Location = New System.Drawing.Point(3, 0)
        Me.LCliente.Name = "LCliente"
        Me.LCliente.Size = New System.Drawing.Size(174, 34)
        Me.LCliente.TabIndex = 221
        Me.LCliente.Text = "Código:"
        Me.LCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoMoneda
        '
        Me.TipoMoneda.BackColor = System.Drawing.Color.Silver
        Me.TipoMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoMoneda.ForeColor = System.Drawing.Color.White
        Me.TipoMoneda.Location = New System.Drawing.Point(0, 77)
        Me.TipoMoneda.Name = "TipoMoneda"
        Me.TipoMoneda.Size = New System.Drawing.Size(634, 32)
        Me.TipoMoneda.TabIndex = 224
        Me.TipoMoneda.Text = "OBSERVACIÓN"
        Me.TipoMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FComentario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 404)
        Me.ControlBox = False
        Me.Controls.Add(Me.TipoMoneda)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.TComentario)
        Me.Name = "FComentario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Comentario."
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents LCodigo As System.Windows.Forms.Label
    Friend WithEvents LCI As System.Windows.Forms.Label
    Friend WithEvents LCliente As System.Windows.Forms.Label
    Friend WithEvents TipoMoneda As System.Windows.Forms.Label
End Class
