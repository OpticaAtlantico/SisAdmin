<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FComentarioSolo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FComentarioSolo))
        Me.LObservacion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.TComentario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LObservacion
        '
        Me.LObservacion.BackColor = System.Drawing.Color.Silver
        Me.LObservacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.LObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LObservacion.ForeColor = System.Drawing.Color.White
        Me.LObservacion.Location = New System.Drawing.Point(0, 0)
        Me.LObservacion.Name = "LObservacion"
        Me.LObservacion.Size = New System.Drawing.Size(774, 32)
        Me.LObservacion.TabIndex = 230
        Me.LObservacion.Text = "OBSERVACIÓN"
        Me.LObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(715, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 229
        Me.Label4.Text = "Salir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(640, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 228
        Me.Label3.Text = "Aceptar"
        '
        'BSalir
        '
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.Location = New System.Drawing.Point(699, 336)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(63, 52)
        Me.BSalir.TabIndex = 2
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Image = CType(resources.GetObject("BAceptar.Image"), System.Drawing.Image)
        Me.BAceptar.Location = New System.Drawing.Point(630, 336)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(63, 52)
        Me.BAceptar.TabIndex = 1
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'TComentario
        '
        Me.TComentario.BackColor = System.Drawing.SystemColors.Info
        Me.TComentario.Dock = System.Windows.Forms.DockStyle.Top
        Me.TComentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TComentario.Location = New System.Drawing.Point(0, 32)
        Me.TComentario.Multiline = True
        Me.TComentario.Name = "TComentario"
        Me.TComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TComentario.Size = New System.Drawing.Size(774, 298)
        Me.TComentario.TabIndex = 0
        '
        'FComentarioSolo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(774, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.TComentario)
        Me.Controls.Add(Me.LObservacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BAceptar)
        Me.Name = "FComentarioSolo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Observación."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LObservacion As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents TComentario As System.Windows.Forms.TextBox
End Class
