<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBuscarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBuscarProveedor))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.TRif = New System.Windows.Forms.TextBox()
        Me.LCedula = New System.Windows.Forms.Label()
        Me.TAlias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FInventarioNivelar = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.BExportar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.FInventarioNivelar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.White
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LTitulo.Location = New System.Drawing.Point(24, 19)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(427, 34)
        Me.LTitulo.TabIndex = 923
        Me.LTitulo.Text = "Listado de Proveedores."
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Salir, Me.Guardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1051, 70)
        Me.ToolStrip1.TabIndex = 6
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
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.Info
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(101, 69)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(540, 26)
        Me.TNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(14, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 26)
        Me.Label2.TabIndex = 929
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(680, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 927
        Me.Label1.Text = "Buscar Proveedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.White
        Me.BClientes.BackgroundImage = CType(resources.GetObject("BClientes.BackgroundImage"), System.Drawing.Image)
        Me.BClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BClientes.CausesValidation = False
        Me.BClientes.Location = New System.Drawing.Point(680, 16)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Size = New System.Drawing.Size(123, 103)
        Me.BClientes.TabIndex = 4
        Me.BClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'TRif
        '
        Me.TRif.BackColor = System.Drawing.SystemColors.Info
        Me.TRif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRif.Location = New System.Drawing.Point(101, 107)
        Me.TRif.Name = "TRif"
        Me.TRif.Size = New System.Drawing.Size(264, 26)
        Me.TRif.TabIndex = 3
        '
        'LCedula
        '
        Me.LCedula.BackColor = System.Drawing.Color.Transparent
        Me.LCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCedula.ForeColor = System.Drawing.Color.Navy
        Me.LCedula.Location = New System.Drawing.Point(14, 107)
        Me.LCedula.Name = "LCedula"
        Me.LCedula.Size = New System.Drawing.Size(84, 26)
        Me.LCedula.TabIndex = 926
        Me.LCedula.Text = "R.I.F.:"
        Me.LCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TAlias
        '
        Me.TAlias.BackColor = System.Drawing.SystemColors.Info
        Me.TAlias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAlias.Location = New System.Drawing.Point(101, 31)
        Me.TAlias.Name = "TAlias"
        Me.TAlias.Size = New System.Drawing.Size(540, 26)
        Me.TAlias.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(14, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 26)
        Me.Label3.TabIndex = 931
        Me.Label3.Text = "Alias:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FInventarioNivelar
        '
        Me.FInventarioNivelar.AllowUserToAddRows = False
        Me.FInventarioNivelar.AllowUserToDeleteRows = False
        Me.FInventarioNivelar.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FInventarioNivelar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.FInventarioNivelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FInventarioNivelar.DefaultCellStyle = DataGridViewCellStyle4
        Me.FInventarioNivelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FInventarioNivelar.EnableHeadersVisualStyles = False
        Me.FInventarioNivelar.Location = New System.Drawing.Point(0, 231)
        Me.FInventarioNivelar.Name = "FInventarioNivelar"
        Me.FInventarioNivelar.ReadOnly = True
        Me.FInventarioNivelar.RowHeadersVisible = False
        Me.FInventarioNivelar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FInventarioNivelar.Size = New System.Drawing.Size(1051, 511)
        Me.FInventarioNivelar.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.BExportar)
        Me.Panel1.Controls.Add(Me.BClientes)
        Me.Panel1.Controls.Add(Me.TRif)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LCedula)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.TAlias)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1051, 161)
        Me.Panel1.TabIndex = 932
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(828, 123)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(123, 18)
        Me.Label33.TabIndex = 969
        Me.Label33.Text = "Exportar Excel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BExportar
        '
        Me.BExportar.BackColor = System.Drawing.Color.White
        Me.BExportar.BackgroundImage = CType(resources.GetObject("BExportar.BackgroundImage"), System.Drawing.Image)
        Me.BExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BExportar.Location = New System.Drawing.Point(828, 16)
        Me.BExportar.Name = "BExportar"
        Me.BExportar.Size = New System.Drawing.Size(123, 103)
        Me.BExportar.TabIndex = 968
        Me.BExportar.UseVisualStyleBackColor = False
        '
        'FBuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1051, 742)
        Me.ControlBox = False
        Me.Controls.Add(Me.FInventarioNivelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FBuscarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Buscar Proveedor."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.FInventarioNivelar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LTitulo As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BClientes As System.Windows.Forms.Button
    Friend WithEvents TRif As System.Windows.Forms.TextBox
    Friend WithEvents LCedula As System.Windows.Forms.Label
    Friend WithEvents TAlias As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FInventarioNivelar As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BExportar As System.Windows.Forms.Button
End Class
