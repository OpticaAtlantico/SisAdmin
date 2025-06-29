<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FVerificarActualizacion
    Inherits System.Windows.Forms.Form

    Friend WithEvents lblVersionActual As Label
    Friend WithEvents lblVersionDisponible As Label
    Friend WithEvents rtxNotas As RichTextBox
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents btnDescargar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents picUpdate As PictureBox

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblVersionActual = New System.Windows.Forms.Label()
        Me.lblVersionDisponible = New System.Windows.Forms.Label()
        Me.rtxNotas = New System.Windows.Forms.RichTextBox()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.btnDescargar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.picUpdate = New System.Windows.Forms.PictureBox()
        CType(Me.picUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVersionActual
        '
        Me.lblVersionActual.AutoSize = True
        Me.lblVersionActual.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblVersionActual.Location = New System.Drawing.Point(30, 20)
        Me.lblVersionActual.Name = "lblVersionActual"
        Me.lblVersionActual.Size = New System.Drawing.Size(129, 17)
        Me.lblVersionActual.TabIndex = 0
        Me.lblVersionActual.Text = "Versión actual: v1.0.0"
        '
        'lblVersionDisponible
        '
        Me.lblVersionDisponible.AutoSize = True
        Me.lblVersionDisponible.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblVersionDisponible.Location = New System.Drawing.Point(280, 20)
        Me.lblVersionDisponible.Name = "lblVersionDisponible"
        Me.lblVersionDisponible.Size = New System.Drawing.Size(119, 17)
        Me.lblVersionDisponible.TabIndex = 1
        Me.lblVersionDisponible.Text = "Disponible: v1.1.0"
        '
        'rtxNotas
        '
        Me.rtxNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxNotas.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.rtxNotas.Location = New System.Drawing.Point(30, 60)
        Me.rtxNotas.Name = "rtxNotas"
        Me.rtxNotas.ReadOnly = True
        Me.rtxNotas.Size = New System.Drawing.Size(420, 120)
        Me.rtxNotas.TabIndex = 2
        Me.rtxNotas.Text = ""
        '
        'progressBar
        '
        Me.progressBar.ForeColor = System.Drawing.Color.SeaGreen
        Me.progressBar.Location = New System.Drawing.Point(30, 195)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(420, 20)
        Me.progressBar.TabIndex = 3
        '
        'btnDescargar
        '
        Me.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescargar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnDescargar.Location = New System.Drawing.Point(30, 230)
        Me.btnDescargar.Name = "btnDescargar"
        Me.btnDescargar.Size = New System.Drawing.Size(200, 35)
        Me.btnDescargar.TabIndex = 4
        Me.btnDescargar.Text = "Descargar actualización"
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnCerrar.Location = New System.Drawing.Point(350, 230)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(100, 35)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Cerrar"
        '
        'picUpdate
        '
        Me.picUpdate.Location = New System.Drawing.Point(0, 0)
        Me.picUpdate.Name = "picUpdate"
        Me.picUpdate.Size = New System.Drawing.Size(100, 50)
        Me.picUpdate.TabIndex = 6
        Me.picUpdate.TabStop = False
        '
        'FVerificarActualizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 290)
        Me.Controls.Add(Me.lblVersionActual)
        Me.Controls.Add(Me.lblVersionDisponible)
        Me.Controls.Add(Me.rtxNotas)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.btnDescargar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.picUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FVerificarActualizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualización disponible"
        CType(Me.picUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
