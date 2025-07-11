Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxItem(True)>
<DesignerCategory("WilmerUI")>
<Description("Botón tipo comando profesional estilo WilmerUI")>
Public Class CommandButtonWUI
    Inherits Button

    Private _borderRadius As Integer = 6
    Private _focusColor As Color = Color.DeepSkyBlue
    Private _baseColor As Color = Color.SteelBlue
    Private _textColor As Color = Color.White
    Private _fontAwesomeChar As String = ""
    Private _shadowColor As Color = Color.FromArgb(40, Color.Black)

    Public Sub New()
        Me.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        Me.Size = New Size(120, 35)
        Me.FlatStyle = FlatStyle.Flat
        Me.BackColor = _baseColor
        Me.ForeColor = _textColor
        Me.TextAlign = ContentAlignment.MiddleCenter
        Me.DoubleBuffered = True
    End Sub

    <Category("WilmerUI")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Me.Invalidate()
        End Set
    End Property

    <Category("WilmerUI")>
    Public Property FocusColor As Color
        Get
            Return _focusColor
        End Get
        Set(value As Color)
            _focusColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("WilmerUI")>
    Public Property BaseColor As Color
        Get
            Return _baseColor
        End Get
        Set(value As Color)
            _baseColor = value
            Me.BackColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("WilmerUI")>
    Public Property TextColor As Color
        Get
            Return _textColor
        End Get
        Set(value As Color)
            _textColor = value
            Me.ForeColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("WilmerUI")>
    Public Property IconFontAwesome As String
        Get
            Return _fontAwesomeChar
        End Get
        Set(value As String)
            _fontAwesomeChar = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim g = pe.Graphics
        Dim rect = Me.ClientRectangle

        ' Bordes redondeados
        Dim path = New GraphicsPath()
        path.AddArc(0, 0, _borderRadius, _borderRadius, 180, 90)
        path.AddArc(rect.Width - _borderRadius, 0, _borderRadius, _borderRadius, 270, 90)
        path.AddArc(rect.Width - _borderRadius, rect.Height - _borderRadius, _borderRadius, _borderRadius, 0, 90)
        path.AddArc(0, rect.Height - _borderRadius, _borderRadius, _borderRadius, 90, 90)
        path.CloseFigure()

        ' Fondo y borde
        g.FillPath(New SolidBrush(Me.BackColor), path)
        Using pen As New Pen(_focusColor, 1.5F)
            g.DrawPath(pen, path)
        End Using

        ' Texto con ícono opcional
        Dim texto = If(String.IsNullOrEmpty(_fontAwesomeChar), Me.Text, _fontAwesomeChar & "  " & Me.Text)
        TextRenderer.DrawText(g, texto, Me.Font, rect, Me.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    'COMO UTILIZARLO

    ' Agrega un botón al formulario y establece sus propiedades:
    ' Dim btn As New CommandButtonWUI()
    ' btn.Text = "Enviar"
    ' btn.IconFontAwesome = ChrW(&HF078) ' Icono de FontAwesome (opcional)
    ' btn.BorderRadius = 8
    ' btn.FocusColor = Color.DeepSkyBlue
    ' btn.BaseColor = Color.SteelBlue
    ' btn.TextColor = Color.White
    ' btn.Size = New Size(120, 35)
    ' btn.Location = New Point(10, 10)
    ' Me.Controls.Add(btn)


End Class
