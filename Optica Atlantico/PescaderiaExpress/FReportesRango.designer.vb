<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FReportesRango
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FReportesRango))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.COpto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BSiguiente = New System.Windows.Forms.Button()
        Me.BAnterior = New System.Windows.Forms.Button()
        Me.Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Desde = New System.Windows.Forms.DateTimePicker()
        Me.BListado = New System.Windows.Forms.Button()
        Me.TDesde = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayBackgroundEdge = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 121)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1370, 301)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.COpto)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.BSiguiente)
        Me.Panel2.Controls.Add(Me.BAnterior)
        Me.Panel2.Controls.Add(Me.Hasta)
        Me.Panel2.Controls.Add(Me.Desde)
        Me.Panel2.Controls.Add(Me.BListado)
        Me.Panel2.Controls.Add(Me.TDesde)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label45)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 121)
        Me.Panel2.TabIndex = 922
        '
        'COpto
        '
        Me.COpto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.COpto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.COpto.BackColor = System.Drawing.Color.White
        Me.COpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COpto.FormattingEnabled = True
        Me.COpto.ItemHeight = 18
        Me.COpto.Location = New System.Drawing.Point(379, 51)
        Me.COpto.Margin = New System.Windows.Forms.Padding(0)
        Me.COpto.Name = "COpto"
        Me.COpto.Size = New System.Drawing.Size(301, 26)
        Me.COpto.TabIndex = 924
        Me.COpto.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(379, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(301, 24)
        Me.Label7.TabIndex = 923
        Me.Label7.Text = "Seleccione el Tipo de Reporte:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'BSiguiente
        '
        Me.BSiguiente.BackColor = System.Drawing.Color.White
        Me.BSiguiente.BackgroundImage = CType(resources.GetObject("BSiguiente.BackgroundImage"), System.Drawing.Image)
        Me.BSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BSiguiente.CausesValidation = False
        Me.BSiguiente.Location = New System.Drawing.Point(175, 5)
        Me.BSiguiente.Name = "BSiguiente"
        Me.BSiguiente.Size = New System.Drawing.Size(35, 112)
        Me.BSiguiente.TabIndex = 922
        Me.BSiguiente.UseVisualStyleBackColor = False
        '
        'BAnterior
        '
        Me.BAnterior.BackColor = System.Drawing.Color.White
        Me.BAnterior.BackgroundImage = CType(resources.GetObject("BAnterior.BackgroundImage"), System.Drawing.Image)
        Me.BAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BAnterior.CausesValidation = False
        Me.BAnterior.Location = New System.Drawing.Point(5, 5)
        Me.BAnterior.Name = "BAnterior"
        Me.BAnterior.Size = New System.Drawing.Size(35, 112)
        Me.BAnterior.TabIndex = 921
        Me.BAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAnterior.UseVisualStyleBackColor = False
        '
        'Hasta
        '
        Me.Hasta.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.Hasta.CustomFormat = "dd/MM/yyyy"
        Me.Hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Hasta.Location = New System.Drawing.Point(49, 72)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Size = New System.Drawing.Size(119, 26)
        Me.Hasta.TabIndex = 210
        Me.Hasta.Value = New Date(2015, 10, 1, 0, 0, 0, 0)
        '
        'Desde
        '
        Me.Desde.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.Desde.CustomFormat = "dd/MM/yyyy"
        Me.Desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Desde.Location = New System.Drawing.Point(49, 22)
        Me.Desde.Name = "Desde"
        Me.Desde.Size = New System.Drawing.Size(119, 26)
        Me.Desde.TabIndex = 208
        Me.Desde.Value = New Date(2015, 10, 1, 0, 0, 0, 0)
        '
        'BListado
        '
        Me.BListado.BackColor = System.Drawing.Color.Transparent
        Me.BListado.BackgroundImage = CType(resources.GetObject("BListado.BackgroundImage"), System.Drawing.Image)
        Me.BListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BListado.Location = New System.Drawing.Point(252, 9)
        Me.BListado.Name = "BListado"
        Me.BListado.Size = New System.Drawing.Size(88, 86)
        Me.BListado.TabIndex = 213
        Me.BListado.UseVisualStyleBackColor = False
        '
        'TDesde
        '
        Me.TDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesde.ForeColor = System.Drawing.Color.Navy
        Me.TDesde.Location = New System.Drawing.Point(49, 3)
        Me.TDesde.Name = "TDesde"
        Me.TDesde.Size = New System.Drawing.Size(119, 20)
        Me.TDesde.TabIndex = 209
        Me.TDesde.Text = "Desde:"
        Me.TDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(49, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "Hasta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(240, 89)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(109, 25)
        Me.Label45.TabIndex = 918
        Me.Label45.Text = "Actualizar Busqueda"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FReportesRango
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 422)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FReportesRango"
        Me.Text = "MarSoft: Reportes."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BSiguiente As System.Windows.Forms.Button
    Friend WithEvents BAnterior As System.Windows.Forms.Button
    Friend WithEvents Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents BListado As System.Windows.Forms.Button
    Friend WithEvents TDesde As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents COpto As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
