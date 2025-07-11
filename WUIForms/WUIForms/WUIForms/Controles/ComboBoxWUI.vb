Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
<ToolboxItem(True)>
<DesignerCategory("WilmerUI")>
<Description("ComboBox estilizado tipo WilmerUI")>
Public Class ComboBoxWUI
    Inherits ComboBox

    Private _borderColor As Color = Color.Gray
    Private _focusColor As Color = Color.DeepSkyBlue
    Private _borderRadius As Integer = 6
    Private _textColor As Color = Color.Black

    Public Sub New()
        Me.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Font = New Font("Segoe UI", 10)
        Me.Size = New Size(297, 35)
        Me.BackColor = Color.White
        Me.ForeColor = _textColor
        Me.FlatStyle = FlatStyle.Flat
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

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim rect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path = New GraphicsPath()
        path.AddArc(rect.X, rect.Y, _borderRadius, _borderRadius, 180, 90)
        path.AddArc(rect.Right - _borderRadius, rect.Y, _borderRadius, _borderRadius, 270, 90)
        path.AddArc(rect.Right - _borderRadius, rect.Bottom - _borderRadius, _borderRadius, _borderRadius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - _borderRadius, _borderRadius, _borderRadius, 90, 90)
        path.CloseFigure()

        pe.Graphics.FillPath(New SolidBrush(Me.BackColor), path)
        Dim penColor = If(Me.Focused, _focusColor, _borderColor)
        Using pen As New Pen(penColor, 1.5F)
            pe.Graphics.DrawPath(pen, path)
        End Using

        Dim icon = ChrW(&HF078) ' FontAwesome angle-down
        Dim faFont = New Font("Font Awesome 6 Free Solid", 10)
        Dim iconSize = TextRenderer.MeasureText(icon, faFont)
        Dim iconRect = New Rectangle(Me.Width - iconSize.Width - 10, (Me.Height - iconSize.Height) \ 2, iconSize.Width, iconSize.Height)
        TextRenderer.DrawText(pe.Graphics, icon, faFont, iconRect, _textColor)
    End Sub
End Class
