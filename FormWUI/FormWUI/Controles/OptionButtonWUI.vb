Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxItem(True)>
<DesignerCategory("WilmerUI")>
<Description("Botón de opción estilizado tipo WilmerUI")>
Public Class OptionButtonWUI
    Inherits RadioButton

    Private _borderColor As Color = Color.Gray
    Private _checkedColor As Color = Color.DeepSkyBlue
    Private _shadowColor As Color = Color.FromArgb(30, Color.Black)
    Private _textColor As Color = Color.Black
    Private _circleSize As Integer = 18

    Public Sub New()
        Me.AutoSize = False
        Me.Size = New Size(160, 35)
        Me.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        Me.ForeColor = _textColor
        Me.DoubleBuffered = True
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
    Public Property CheckedColor As Color
        Get
            Return _checkedColor
        End Get
        Set(value As Color)
            _checkedColor = value
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
        Dim g = pe.Graphics
        g.Clear(Me.BackColor)

        Dim circleRect As New Rectangle(10, (Me.Height - _circleSize) \ 2, _circleSize, _circleSize)
        Dim textRect As New Rectangle(circleRect.Right + 10, 0, Me.Width - circleRect.Right - 20, Me.Height)

        ' Sombra exterior
        Dim shadowRect As Rectangle = New Rectangle(circleRect.X + 1, circleRect.Y + 1, _circleSize, _circleSize)
        g.FillEllipse(New SolidBrush(_shadowColor), shadowRect)

        ' Círculo exterior
        g.FillEllipse(New SolidBrush(Color.White), circleRect)
        Using borderPen As New Pen(_borderColor, 1.5F)
            g.DrawEllipse(borderPen, circleRect)
        End Using

        ' Círculo interior si está seleccionado
        If Me.Checked Then
            Dim innerSize As Integer = _circleSize \ 2
            Dim innerRect As New Rectangle(circleRect.X + (_circleSize - innerSize) \ 2, circleRect.Y + (_circleSize - innerSize) \ 2, innerSize, innerSize)
            g.FillEllipse(New SolidBrush(_checkedColor), innerRect)
        End If

        ' Texto asociado
        TextRenderer.DrawText(g, Me.Text, Me.Font, textRect, Me.ForeColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
    End Sub

    'COMO USARLO

    'Dim optMasculino As New OptionButtonMaterialWilmer()
    'optMasculino.Text = "Masculino"
    'optMasculino.CheckedColor = Color.RoyalBlue

    'Dim optFemenino As New OptionButtonMaterialWilmer()
    'optFemenino.Text = "Femenino"
    'optFemenino.CheckedColor = Color.DeepPink

    'Me.Controls.Add(optMasculino)
    'Me.Controls.Add(optFemenino)


End Class
