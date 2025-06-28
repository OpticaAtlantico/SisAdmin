<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBuscarClienteEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBuscarClienteEmpleado))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LBBuscar = New System.Windows.Forms.Label()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.TCedula = New System.Windows.Forms.TextBox()
        Me.LCedula = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.FInventarioNivelar = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CTipoRif = New System.Windows.Forms.ComboBox()
        Me.BImprimir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TRif = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TEmpresa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.FInventarioNivelar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBBuscar
        '
        Me.LBBuscar.AutoSize = True
        Me.LBBuscar.ForeColor = System.Drawing.Color.Navy
        Me.LBBuscar.Location = New System.Drawing.Point(743, 165)
        Me.LBBuscar.Name = "LBBuscar"
        Me.LBBuscar.Size = New System.Drawing.Size(75, 13)
        Me.LBBuscar.TabIndex = 914
        Me.LBBuscar.Text = "Buscar Cliente"
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.White
        Me.BClientes.BackgroundImage = CType(resources.GetObject("BClientes.BackgroundImage"), System.Drawing.Image)
        Me.BClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BClientes.CausesValidation = False
        Me.BClientes.Location = New System.Drawing.Point(731, 80)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Size = New System.Drawing.Size(96, 82)
        Me.BClientes.TabIndex = 910
        Me.BClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'TCedula
        '
        Me.TCedula.BackColor = System.Drawing.SystemColors.Info
        Me.TCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCedula.Location = New System.Drawing.Point(103, 52)
        Me.TCedula.MaxLength = 8
        Me.TCedula.Name = "TCedula"
        Me.TCedula.Size = New System.Drawing.Size(222, 26)
        Me.TCedula.TabIndex = 907
        '
        'LCedula
        '
        Me.LCedula.BackColor = System.Drawing.Color.Transparent
        Me.LCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCedula.ForeColor = System.Drawing.Color.Navy
        Me.LCedula.Location = New System.Drawing.Point(16, 55)
        Me.LCedula.Name = "LCedula"
        Me.LCedula.Size = New System.Drawing.Size(84, 26)
        Me.LCedula.TabIndex = 911
        Me.LCedula.Text = "Cédula:"
        Me.LCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.Info
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(103, 89)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(540, 26)
        Me.TNombre.TabIndex = 915
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(16, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 26)
        Me.Label2.TabIndex = 916
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.White
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LTitulo.Location = New System.Drawing.Point(23, 18)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(289, 34)
        Me.LTitulo.TabIndex = 921
        Me.LTitulo.Text = "Listado de Clientes."
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
        Me.ToolStrip1.Size = New System.Drawing.Size(1032, 70)
        Me.ToolStrip1.TabIndex = 920
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
        'FInventarioNivelar
        '
        Me.FInventarioNivelar.AllowUserToAddRows = False
        Me.FInventarioNivelar.AllowUserToDeleteRows = False
        Me.FInventarioNivelar.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FInventarioNivelar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.FInventarioNivelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FInventarioNivelar.DefaultCellStyle = DataGridViewCellStyle2
        Me.FInventarioNivelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FInventarioNivelar.EnableHeadersVisualStyles = False
        Me.FInventarioNivelar.Location = New System.Drawing.Point(0, 282)
        Me.FInventarioNivelar.Name = "FInventarioNivelar"
        Me.FInventarioNivelar.ReadOnly = True
        Me.FInventarioNivelar.RowHeadersVisible = False
        Me.FInventarioNivelar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FInventarioNivelar.Size = New System.Drawing.Size(1032, 460)
        Me.FInventarioNivelar.TabIndex = 922
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TCodigo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CTipoRif)
        Me.Panel1.Controls.Add(Me.BImprimir)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TRif)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TEmpresa)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TCedula)
        Me.Panel1.Controls.Add(Me.LCedula)
        Me.Panel1.Controls.Add(Me.BClientes)
        Me.Panel1.Controls.Add(Me.LBBuscar)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 212)
        Me.Panel1.TabIndex = 923
        '
        'TCodigo
        '
        Me.TCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(103, 15)
        Me.TCodigo.MaxLength = 8
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(222, 26)
        Me.TCodigo.TabIndex = 924
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(16, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 925
        Me.Label6.Text = "Código"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CTipoRif
        '
        Me.CTipoRif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CTipoRif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTipoRif.FormattingEnabled = True
        Me.CTipoRif.Items.AddRange(New Object() {"J", "G", "V", "E"})
        Me.CTipoRif.Location = New System.Drawing.Point(103, 126)
        Me.CTipoRif.Name = "CTipoRif"
        Me.CTipoRif.Size = New System.Drawing.Size(50, 26)
        Me.CTipoRif.TabIndex = 923
        '
        'BImprimir
        '
        Me.BImprimir.BackColor = System.Drawing.Color.White
        Me.BImprimir.BackgroundImage = CType(resources.GetObject("BImprimir.BackgroundImage"), System.Drawing.Image)
        Me.BImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BImprimir.CausesValidation = False
        Me.BImprimir.Location = New System.Drawing.Point(841, 80)
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Size = New System.Drawing.Size(96, 82)
        Me.BImprimir.TabIndex = 921
        Me.BImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BImprimir.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(872, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 922
        Me.Label5.Text = "Imprimir"
        '
        'TRif
        '
        Me.TRif.BackColor = System.Drawing.SystemColors.Info
        Me.TRif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRif.Location = New System.Drawing.Point(158, 127)
        Me.TRif.MaxLength = 10
        Me.TRif.Name = "TRif"
        Me.TRif.Size = New System.Drawing.Size(167, 26)
        Me.TRif.TabIndex = 917
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(13, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 26)
        Me.Label3.TabIndex = 918
        Me.Label3.Text = "R.I.F:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TEmpresa
        '
        Me.TEmpresa.BackColor = System.Drawing.SystemColors.Info
        Me.TEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEmpresa.Location = New System.Drawing.Point(103, 163)
        Me.TEmpresa.Name = "TEmpresa"
        Me.TEmpresa.Size = New System.Drawing.Size(540, 26)
        Me.TEmpresa.TabIndex = 919
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(16, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 26)
        Me.Label4.TabIndex = 920
        Me.Label4.Text = "Empresa:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FBuscarClienteEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1032, 742)
        Me.ControlBox = False
        Me.Controls.Add(Me.FInventarioNivelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FBuscarClienteEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Buscar Cliente."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.FInventarioNivelar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBBuscar As System.Windows.Forms.Label
    Friend WithEvents BClientes As System.Windows.Forms.Button
    Friend WithEvents TCedula As System.Windows.Forms.TextBox
    Friend WithEvents LCedula As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LTitulo As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents FInventarioNivelar As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TRif As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BImprimir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CTipoRif As System.Windows.Forms.ComboBox
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
