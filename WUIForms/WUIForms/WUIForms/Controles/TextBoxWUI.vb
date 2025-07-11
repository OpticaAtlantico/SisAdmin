Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxItem(True)>
<DesignerCategory("WilmerUI")>
<Description("TextBox estilizado tipo WilmerUI")>
Public Class TextBoxWUI
    Inherits TextBox

    Private _borderColor As Color = Color.Gray
    Private _focusBorderColor As Color = Color.DeepSkyBlue
    Private _borderRadius As Integer = 6
    Private _shadowColor As Color = Color.FromArgb(40, Color.Black)
    Private _backColorCustom As Color = Color.White
    Private _hasFocus As Boolean = False

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        Me.ForeColor = Color.Black
        Me.Size = New Size(297, 35)
        Me.Multiline = False
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
    Public Property FocusBorderColor As Color
        Get
            Return _focusBorderColor
        End Get
        Set(value As Color)
            _focusBorderColor = value
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
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim rect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        ' Sombra
        Dim shadowRect = New Rectangle(rect.X + 1, rect.Y + 1, rect.Width, rect.Height)
        pe.Graphics.FillRectangle(New SolidBrush(_shadowColor), shadowRect)

        ' Bordes redondeados
        Dim path = New GraphicsPath()
        path.AddArc(rect.X, rect.Y, _borderRadius, _borderRadius, 180, 90)
        path.AddArc(rect.Right - _borderRadius, rect.Y, _borderRadius, _borderRadius, 270, 90)
        path.AddArc(rect.Right - _borderRadius, rect.Bottom - _borderRadius, _borderRadius, _borderRadius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - _borderRadius, _borderRadius, _borderRadius, 90, 90)
        path.CloseAllFigures()

        pe.Graphics.FillPath(New SolidBrush(_backColorCustom), path)
        Dim penColor = If(_hasFocus, _focusBorderColor, _borderColor)
        Using pen As New Pen(penColor, 1.5F)
            pe.Graphics.DrawPath(pen, path)
        End Using

        ' Texto
        Dim textRect = New Rectangle(10, 0, Me.Width - 20, Me.Height)
        TextRenderer.DrawText(pe.Graphics, Me.Text, Me.Font, textRect, Me.ForeColor, TextFormatFlags.VerticalCenter)
    End Sub
End Class
