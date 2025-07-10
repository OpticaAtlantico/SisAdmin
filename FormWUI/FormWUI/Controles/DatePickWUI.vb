Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxItem(True)>
<DesignerCategory("WilmerUI")>
<Description("Selector de fecha visual tipo WilmerUI con calendario flotante")>
Public Class DatePickWUI
    Inherits UserControl

    Private txtFecha As New MaskedTextBoxFechaWUI()
    Private btnCalendario As New Label()
    Private popupCalendario As New MonthCalendar()
    Private sombraPanel As New Panel()

    Public Sub New()
        Me.Size = New Size(297, 35)
        Me.BackColor = Color.Transparent
        Me.DoubleBuffered = True

        txtFecha.Location = New Point(0, 0)
        Me.Controls.Add(txtFecha)

        btnCalendario.Text = ChrW(&HF073) ' fa-calendar
        btnCalendario.Font = New Font("Font Awesome 6 Free Solid", 10)
        btnCalendario.Size = New Size(35, 35)
        btnCalendario.TextAlign = ContentAlignment.MiddleCenter
        btnCalendario.ForeColor = Color.Gray
        btnCalendario.BackColor = Color.Transparent
        btnCalendario.Location = New Point(Me.Width - 35, 0)
        Me.Controls.Add(btnCalendario)

        sombraPanel.Size = New Size(250, 180)
        sombraPanel.BackColor = Color.White
        sombraPanel.BorderStyle = BorderStyle.FixedSingle
        sombraPanel.Visible = False
        sombraPanel.Location = New Point(0, Me.Height + 2)
        sombraPanel.Controls.Add(popupCalendario)
        popupCalendario.Dock = DockStyle.Fill
        popupCalendario.MaxSelectionCount = 1

        Me.Controls.Add(sombraPanel)
        Me.BringToFront()

        AddHandler btnCalendario.Click, Sub() sombraPanel.Visible = Not sombraPanel.Visible
        AddHandler popupCalendario.DateSelected, Sub(s, e)
                                                     txtFecha.Text = e.Start.ToString("dd/MM/yyyy")
                                                     sombraPanel.Visible = False
                                                 End Sub
    End Sub

    <Category("WilmerUI")>
    Public Property FechaSeleccionada As Date
        Get
            Return If(Date.TryParse(txtFecha.Text, Nothing), Convert.ToDateTime(txtFecha.Text), Date.Today)
        End Get
        Set(value As Date)
            txtFecha.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    <Category("WilmerUI")>
    Public ReadOnly Property TextBoxFecha As MaskedTextBoxFechaWUI
        Get
            Return txtFecha
        End Get
    End Property
End Class
