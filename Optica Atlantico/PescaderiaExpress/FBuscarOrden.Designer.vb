<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBuscarOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBuscarOrden))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.Seleccionar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CNac = New System.Windows.Forms.ComboBox()
        Me.CTipoRif = New System.Windows.Forms.ComboBox()
        Me.BSiguiente = New System.Windows.Forms.Button()
        Me.BAnterior = New System.Windows.Forms.Button()
        Me.Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Desde = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TDesde = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TRIF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CAsesor = New System.Windows.Forms.ComboBox()
        Me.TNumOrden = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TCI = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BExportar = New System.Windows.Forms.Button()
        Me.BActualizar = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Salir, Me.Seleccionar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1417, 70)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.AutoSize = False
        Me.Salir.ForeColor = System.Drawing.Color.Navy
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(100, 67)
        Me.Salir.Text = "Salir"
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Salir.ToolTipText = "Salir."
        '
        'Seleccionar
        '
        Me.Seleccionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Seleccionar.AutoSize = False
        Me.Seleccionar.ForeColor = System.Drawing.Color.Navy
        Me.Seleccionar.Image = CType(resources.GetObject("Seleccionar.Image"), System.Drawing.Image)
        Me.Seleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Size = New System.Drawing.Size(120, 67)
        Me.Seleccionar.Text = "Seleccionar Orden"
        Me.Seleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Seleccionar.ToolTipText = "Guardar."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CNac)
        Me.GroupBox1.Controls.Add(Me.CTipoRif)
        Me.GroupBox1.Controls.Add(Me.BSiguiente)
        Me.GroupBox1.Controls.Add(Me.BAnterior)
        Me.GroupBox1.Controls.Add(Me.Hasta)
        Me.GroupBox1.Controls.Add(Me.Desde)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TNombre)
        Me.GroupBox1.Controls.Add(Me.TRIF)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CAsesor)
        Me.GroupBox1.Controls.Add(Me.TNumOrden)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TCI)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BExportar)
        Me.GroupBox1.Controls.Add(Me.BActualizar)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1417, 166)
        Me.GroupBox1.TabIndex = 235
        Me.GroupBox1.TabStop = False
        '
        'CNac
        '
        Me.CNac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNac.FormattingEnabled = True
        Me.CNac.Items.AddRange(New Object() {"V", "E"})
        Me.CNac.Location = New System.Drawing.Point(507, 40)
        Me.CNac.Name = "CNac"
        Me.CNac.Size = New System.Drawing.Size(50, 26)
        Me.CNac.TabIndex = 987
        '
        'CTipoRif
        '
        Me.CTipoRif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CTipoRif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTipoRif.FormattingEnabled = True
        Me.CTipoRif.Items.AddRange(New Object() {"J", "G", "V", "E"})
        Me.CTipoRif.Location = New System.Drawing.Point(732, 39)
        Me.CTipoRif.Name = "CTipoRif"
        Me.CTipoRif.Size = New System.Drawing.Size(50, 26)
        Me.CTipoRif.TabIndex = 986
        '
        'BSiguiente
        '
        Me.BSiguiente.BackColor = System.Drawing.Color.White
        Me.BSiguiente.BackgroundImage = CType(resources.GetObject("BSiguiente.BackgroundImage"), System.Drawing.Image)
        Me.BSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BSiguiente.CausesValidation = False
        Me.BSiguiente.Location = New System.Drawing.Point(285, 17)
        Me.BSiguiente.Name = "BSiguiente"
        Me.BSiguiente.Size = New System.Drawing.Size(35, 129)
        Me.BSiguiente.TabIndex = 985
        Me.BSiguiente.UseVisualStyleBackColor = False
        '
        'BAnterior
        '
        Me.BAnterior.BackColor = System.Drawing.Color.White
        Me.BAnterior.BackgroundImage = CType(resources.GetObject("BAnterior.BackgroundImage"), System.Drawing.Image)
        Me.BAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BAnterior.CausesValidation = False
        Me.BAnterior.Location = New System.Drawing.Point(9, 17)
        Me.BAnterior.Name = "BAnterior"
        Me.BAnterior.Size = New System.Drawing.Size(35, 129)
        Me.BAnterior.TabIndex = 984
        Me.BAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAnterior.UseVisualStyleBackColor = False
        '
        'Hasta
        '
        Me.Hasta.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.Hasta.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        Me.Hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Hasta.Location = New System.Drawing.Point(56, 104)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Size = New System.Drawing.Size(220, 26)
        Me.Hasta.TabIndex = 982
        Me.Hasta.Value = New Date(2015, 10, 1, 0, 0, 0, 0)
        '
        'Desde
        '
        Me.Desde.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.Desde.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        Me.Desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Desde.Location = New System.Drawing.Point(56, 54)
        Me.Desde.Name = "Desde"
        Me.Desde.Size = New System.Drawing.Size(220, 26)
        Me.Desde.TabIndex = 980
        Me.Desde.Value = New Date(2015, 10, 1, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(56, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 26)
        Me.Label5.TabIndex = 983
        Me.Label5.Text = "Hasta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TDesde
        '
        Me.TDesde.BackColor = System.Drawing.Color.Transparent
        Me.TDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesde.ForeColor = System.Drawing.Color.Navy
        Me.TDesde.Location = New System.Drawing.Point(56, 29)
        Me.TDesde.Name = "TDesde"
        Me.TDesde.Size = New System.Drawing.Size(184, 26)
        Me.TDesde.TabIndex = 981
        Me.TDesde.Text = "Desde:"
        Me.TDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(339, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 24)
        Me.Label2.TabIndex = 978
        Me.Label2.Text = "Nombre y Apellido:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(339, 116)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(295, 26)
        Me.TNombre.TabIndex = 979
        '
        'TRIF
        '
        Me.TRIF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TRIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRIF.Location = New System.Drawing.Point(788, 39)
        Me.TRIF.MaxLength = 9
        Me.TRIF.Name = "TRIF"
        Me.TRIF.Size = New System.Drawing.Size(153, 26)
        Me.TRIF.TabIndex = 976
        Me.TRIF.Tag = "0"
        Me.TRIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(731, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 977
        Me.Label1.Text = "RIF:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CAsesor
        '
        Me.CAsesor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CAsesor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CAsesor.BackColor = System.Drawing.Color.White
        Me.CAsesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CAsesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAsesor.FormattingEnabled = True
        Me.CAsesor.ItemHeight = 18
        Me.CAsesor.Location = New System.Drawing.Point(646, 116)
        Me.CAsesor.Margin = New System.Windows.Forms.Padding(0)
        Me.CAsesor.Name = "CAsesor"
        Me.CAsesor.Size = New System.Drawing.Size(295, 26)
        Me.CAsesor.TabIndex = 975
        '
        'TNumOrden
        '
        Me.TNumOrden.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TNumOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNumOrden.Location = New System.Drawing.Point(339, 39)
        Me.TNumOrden.Name = "TNumOrden"
        Me.TNumOrden.Size = New System.Drawing.Size(153, 26)
        Me.TNumOrden.TabIndex = 968
        Me.TNumOrden.Tag = "0"
        Me.TNumOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(338, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 24)
        Me.Label9.TabIndex = 969
        Me.Label9.Text = "Nº Orden:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TCI
        '
        Me.TCI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCI.Location = New System.Drawing.Point(563, 39)
        Me.TCI.MaxLength = 9
        Me.TCI.Name = "TCI"
        Me.TCI.Size = New System.Drawing.Size(153, 26)
        Me.TCI.TabIndex = 970
        Me.TCI.Tag = "0"
        Me.TCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(646, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 24)
        Me.Label8.TabIndex = 973
        Me.Label8.Text = "Asesor:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(506, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 24)
        Me.Label3.TabIndex = 971
        Me.Label3.Text = "C.I:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BExportar
        '
        Me.BExportar.BackColor = System.Drawing.Color.White
        Me.BExportar.BackgroundImage = CType(resources.GetObject("BExportar.BackgroundImage"), System.Drawing.Image)
        Me.BExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BExportar.Location = New System.Drawing.Point(1108, 28)
        Me.BExportar.Name = "BExportar"
        Me.BExportar.Size = New System.Drawing.Size(123, 103)
        Me.BExportar.TabIndex = 966
        Me.BExportar.UseVisualStyleBackColor = False
        '
        'BActualizar
        '
        Me.BActualizar.BackColor = System.Drawing.Color.Transparent
        Me.BActualizar.BackgroundImage = CType(resources.GetObject("BActualizar.BackgroundImage"), System.Drawing.Image)
        Me.BActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BActualizar.Location = New System.Drawing.Point(961, 28)
        Me.BActualizar.Name = "BActualizar"
        Me.BActualizar.Size = New System.Drawing.Size(123, 103)
        Me.BActualizar.TabIndex = 964
        Me.BActualizar.UseVisualStyleBackColor = False
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(1109, 129)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(123, 18)
        Me.Label33.TabIndex = 967
        Me.Label33.Text = "Exportar Excel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(962, 129)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(123, 18)
        Me.Label45.TabIndex = 965
        Me.Label45.Text = "Buscar Orden"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.ColumnHeadersHeight = 28
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.Location = New System.Drawing.Point(0, 236)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        Me.Grid.RowTemplate.Height = 25
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(1417, 408)
        Me.Grid.TabIndex = 4
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.White
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LTitulo.Location = New System.Drawing.Point(21, 18)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(816, 34)
        Me.LTitulo.TabIndex = 237
        Me.LTitulo.Text = "Listado de Ordenes."
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FBuscarOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1417, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FBuscarOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarSoft: Buscar."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Seleccionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents LTitulo As System.Windows.Forms.Label
    Friend WithEvents BActualizar As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BExportar As System.Windows.Forms.Button
    Friend WithEvents TRIF As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CAsesor As System.Windows.Forms.ComboBox
    Friend WithEvents TNumOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TCI As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents BSiguiente As System.Windows.Forms.Button
    Friend WithEvents BAnterior As System.Windows.Forms.Button
    Friend WithEvents Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TDesde As System.Windows.Forms.Label
    Friend WithEvents CNac As System.Windows.Forms.ComboBox
    Friend WithEvents CTipoRif As System.Windows.Forms.ComboBox
End Class
