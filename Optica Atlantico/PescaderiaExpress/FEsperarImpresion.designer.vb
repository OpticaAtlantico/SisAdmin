<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEsperarImpresion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FEsperarImpresion))
        Me.Titulo = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImagenBase = New System.Windows.Forms.PictureBox()
        Me.ImagenCalcular = New System.Windows.Forms.PictureBox()
        Me.ImagenImprimir = New System.Windows.Forms.PictureBox()
        Me.ImagenGuardar = New System.Windows.Forms.PictureBox()
        Me.ImagenCalcularPrecios = New System.Windows.Forms.PictureBox()
        Me.ExportarExcel = New System.Windows.Forms.PictureBox()
        CType(Me.ImagenBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenCalcular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenCalcularPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportarExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.Color.Navy
        Me.Titulo.Location = New System.Drawing.Point(12, 21)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(280, 22)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Imprimiendo..."
        Me.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 245)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(304, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 1
        '
        'ImagenBase
        '
        Me.ImagenBase.BackgroundImage = CType(resources.GetObject("ImagenBase.BackgroundImage"), System.Drawing.Image)
        Me.ImagenBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImagenBase.Location = New System.Drawing.Point(32, 46)
        Me.ImagenBase.Name = "ImagenBase"
        Me.ImagenBase.Size = New System.Drawing.Size(238, 194)
        Me.ImagenBase.TabIndex = 2
        Me.ImagenBase.TabStop = False
        '
        'ImagenCalcular
        '
        Me.ImagenCalcular.BackgroundImage = CType(resources.GetObject("ImagenCalcular.BackgroundImage"), System.Drawing.Image)
        Me.ImagenCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImagenCalcular.Location = New System.Drawing.Point(246, 21)
        Me.ImagenCalcular.Name = "ImagenCalcular"
        Me.ImagenCalcular.Size = New System.Drawing.Size(46, 49)
        Me.ImagenCalcular.TabIndex = 3
        Me.ImagenCalcular.TabStop = False
        Me.ImagenCalcular.Visible = False
        '
        'ImagenImprimir
        '
        Me.ImagenImprimir.BackgroundImage = CType(resources.GetObject("ImagenImprimir.BackgroundImage"), System.Drawing.Image)
        Me.ImagenImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImagenImprimir.Location = New System.Drawing.Point(246, 76)
        Me.ImagenImprimir.Name = "ImagenImprimir"
        Me.ImagenImprimir.Size = New System.Drawing.Size(58, 40)
        Me.ImagenImprimir.TabIndex = 4
        Me.ImagenImprimir.TabStop = False
        Me.ImagenImprimir.Visible = False
        '
        'ImagenGuardar
        '
        Me.ImagenGuardar.BackgroundImage = CType(resources.GetObject("ImagenGuardar.BackgroundImage"), System.Drawing.Image)
        Me.ImagenGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImagenGuardar.Location = New System.Drawing.Point(246, 122)
        Me.ImagenGuardar.Name = "ImagenGuardar"
        Me.ImagenGuardar.Size = New System.Drawing.Size(58, 40)
        Me.ImagenGuardar.TabIndex = 5
        Me.ImagenGuardar.TabStop = False
        Me.ImagenGuardar.Visible = False
        '
        'ImagenCalcularPrecios
        '
        Me.ImagenCalcularPrecios.BackgroundImage = CType(resources.GetObject("ImagenCalcularPrecios.BackgroundImage"), System.Drawing.Image)
        Me.ImagenCalcularPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImagenCalcularPrecios.Location = New System.Drawing.Point(234, 168)
        Me.ImagenCalcularPrecios.Name = "ImagenCalcularPrecios"
        Me.ImagenCalcularPrecios.Size = New System.Drawing.Size(58, 40)
        Me.ImagenCalcularPrecios.TabIndex = 6
        Me.ImagenCalcularPrecios.TabStop = False
        Me.ImagenCalcularPrecios.Visible = False
        '
        'ExportarExcel
        '
        Me.ExportarExcel.BackgroundImage = CType(resources.GetObject("ExportarExcel.BackgroundImage"), System.Drawing.Image)
        Me.ExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExportarExcel.Location = New System.Drawing.Point(32, 46)
        Me.ExportarExcel.Name = "ExportarExcel"
        Me.ExportarExcel.Size = New System.Drawing.Size(238, 194)
        Me.ExportarExcel.TabIndex = 7
        Me.ExportarExcel.TabStop = False
        Me.ExportarExcel.Visible = False
        '
        'FEsperarImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(304, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExportarExcel)
        Me.Controls.Add(Me.ImagenCalcularPrecios)
        Me.Controls.Add(Me.ImagenGuardar)
        Me.Controls.Add(Me.ImagenImprimir)
        Me.Controls.Add(Me.ImagenCalcular)
        Me.Controls.Add(Me.ImagenBase)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Titulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FEsperarImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ImagenBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenCalcular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenCalcularPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportarExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Titulo As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImagenBase As System.Windows.Forms.PictureBox
    Friend WithEvents ImagenCalcular As System.Windows.Forms.PictureBox
    Friend WithEvents ImagenImprimir As System.Windows.Forms.PictureBox
    Friend WithEvents ImagenGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents ImagenCalcularPrecios As System.Windows.Forms.PictureBox
    Friend WithEvents ExportarExcel As System.Windows.Forms.PictureBox
End Class
