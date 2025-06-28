<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FImprimirFacturaCajaLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FImprimirFacturaCajaLista))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.Editar = New System.Windows.Forms.ToolStripButton()
        Me.GridAlquilerPunto = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridAlquilerPunto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Imprimir, Me.ToolStripSeparator1, Me.Guardar, Me.Salir, Me.Editar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(859, 70)
        Me.ToolStrip1.TabIndex = 127
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Imprimir
        '
        Me.Imprimir.ForeColor = System.Drawing.Color.Navy
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(57, 67)
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Imprimir.ToolTipText = "Imprimir."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 70)
        '
        'Guardar
        '
        Me.Guardar.ForeColor = System.Drawing.Color.Navy
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(83, 67)
        Me.Guardar.Text = "Guardar Pago"
        Me.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Guardar.ToolTipText = "Guardar."
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
        'Editar
        '
        Me.Editar.ForeColor = System.Drawing.Color.Navy
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(63, 67)
        Me.Editar.Text = "Actualizar"
        Me.Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Editar.ToolTipText = "Editar."
        '
        'GridAlquilerPunto
        '
        Me.GridAlquilerPunto.AllowUserToAddRows = False
        Me.GridAlquilerPunto.AllowUserToDeleteRows = False
        Me.GridAlquilerPunto.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridAlquilerPunto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridAlquilerPunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridAlquilerPunto.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridAlquilerPunto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridAlquilerPunto.EnableHeadersVisualStyles = False
        Me.GridAlquilerPunto.Location = New System.Drawing.Point(0, 152)
        Me.GridAlquilerPunto.Name = "GridAlquilerPunto"
        Me.GridAlquilerPunto.ReadOnly = True
        Me.GridAlquilerPunto.RowHeadersVisible = False
        Me.GridAlquilerPunto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridAlquilerPunto.Size = New System.Drawing.Size(859, 324)
        Me.GridAlquilerPunto.TabIndex = 301
        '
        'FImprimirFacturaCajaLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(859, 476)
        Me.Controls.Add(Me.GridAlquilerPunto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FImprimirFacturaCajaLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Imprimir Factura."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridAlquilerPunto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridAlquilerPunto As System.Windows.Forms.DataGridView
End Class
