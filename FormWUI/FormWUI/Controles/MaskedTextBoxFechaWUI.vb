Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxItem(True)>
<DesignerCategory("WilmerUI")>
<Description("MaskedTextBox para fechas con estilo WilmerUI")>
Public Class MaskedTextBoxFechaWUI
    Inherits MaskedTextBox

    Private _borderColor As Color = Color.Gray
    Private _focusColor As Color = Color.DeepSkyBlue
    Private _hasFocus As Boolean = False
    Private _backColorCustom As Color = Color.White
    Private _shadowColor As Color = Color.FromArgb(30, Color.Black)
    Private _borderRadius As Integer = 6

    Public Sub New()
        Me.Mask = "00/00/0000"
        Me.Font = New Font("Segoe UI", 10)
        Me.Size = New Size(297, 35)
        Me.BorderStyle = BorderStyle.None
        Me.BackColor = Color.Transparent
    End Sub

    <Category("WilmerUI")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
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
    Public Property BackgroundColorCustom As Color
        Get
            Return _backColorCustom
        End Get
        Set(value As Color)
            _backColorCustom = value
            Me.Invalidate()
        End Set
    End Property

    <Category("WilmerUI")>
    Public Property ShadowColor As Color
        Get
            Return _shadowColor
        End Get
        Set(value As Color)
            _shadowColor = value
            Me.Invalidate()
        End Set
    End Property

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

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        _hasFocus = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        MyBase.OnLostFocus(e)
        _hasFocus = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        Dim g = pe.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        ' Sombra
        Dim shadowRect = New Rectangle(rect.X + 1, rect.Y + 1, rect.Width, rect.Height)
        g.FillRectangle(New SolidBrush(_shadowColor), shadowRect)

        ' Bordes redondeados
        Dim path = New GraphicsPath()
        path.AddArc(rect.X, rect.Y, _borderRadius, _borderRadius, 180, 90)
        path.AddArc(rect.Right - _borderRadius, rect.Y, _borderRadius, _borderRadius, 270, 90)
        path.AddArc(rect.Right - _borderRadius, rect.Bottom - _borderRadius, _borderRadius, _borderRadius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - _borderRadius, _borderRadius, _borderRadius, 90, 90)
        path.CloseFigure()

        ' Relleno
        g.FillPath(New SolidBrush(_backColorCustom), path)

        ' Borde
        Dim penColor = If(_hasFocus, _focusColor, _borderColor)
        Using pen As New Pen(penColor, 1.5F)
            g.DrawPath(pen, path)
        End Using

        ' Texto
        Dim textRect = New Rectangle(10, 0, Me.Width - 20, Me.Height)
        TextRenderer.DrawText(g, Me.Text, Me.Font, textRect, Color.Black, TextFormatFlags.VerticalCenter)
    End Sub
End Class
