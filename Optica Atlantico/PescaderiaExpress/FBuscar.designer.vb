<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBuscar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBuscar))
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Buscar = New System.Windows.Forms.ToolStripSplitButton()
        Me.CódigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.LBusqueda = New System.Windows.Forms.Label()
        Me.TBusqueda = New System.Windows.Forms.TextBox()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(0, 126)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(1342, 564)
        Me.DataGrid.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Buscar, Me.Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1342, 70)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Buscar
        '
        Me.Buscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CódigoToolStripMenuItem, Me.NombreToolStripMenuItem})
        Me.Buscar.ForeColor = System.Drawing.Color.Navy
        Me.Buscar.Image = CType(resources.GetObject("Buscar.Image"), System.Drawing.Image)
        Me.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(64, 67)
        Me.Buscar.Text = "Buscar"
        Me.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Buscar.ToolTipText = "Buscar."
        '
        'CódigoToolStripMenuItem
        '
        Me.CódigoToolStripMenuItem.Name = "CódigoToolStripMenuItem"
        Me.CódigoToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.CódigoToolStripMenuItem.Text = "Código"
        '
        'NombreToolStripMenuItem
        '
        Me.NombreToolStripMenuItem.Name = "NombreToolStripMenuItem"
        Me.NombreToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.NombreToolStripMenuItem.Text = "Nombre"
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
        'LBusqueda
        '
        Me.LBusqueda.AutoSize = True
        Me.LBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBusqueda.ForeColor = System.Drawing.Color.Navy
        Me.LBusqueda.Location = New System.Drawing.Point(12, 89)
        Me.LBusqueda.Name = "LBusqueda"
        Me.LBusqueda.Size = New System.Drawing.Size(70, 20)
        Me.LBusqueda.TabIndex = 14
        Me.LBusqueda.Text = "Código:"
        '
        'TBusqueda
        '
        Me.TBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.TBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBusqueda.Location = New System.Drawing.Point(88, 85)
        Me.TBusqueda.Name = "TBusqueda"
        Me.TBusqueda.Size = New System.Drawing.Size(1246, 26)
        Me.TBusqueda.TabIndex = 15
        '
        'FBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1342, 690)
        Me.ControlBox = False
        Me.Controls.Add(Me.TBusqueda)
        Me.Controls.Add(Me.LBusqueda)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGrid)
        Me.Name = "FBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Buscar."
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Buscar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents CódigoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LBusqueda As System.Windows.Forms.Label
    Friend WithEvents TBusqueda As System.Windows.Forms.TextBox
End Class
