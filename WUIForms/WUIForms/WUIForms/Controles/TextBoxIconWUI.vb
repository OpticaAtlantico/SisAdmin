Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxItem(True)>
<DesignerCategory("WilmerUI")>
<Description("TextBox con ícono embebido tipo WilmerUI")>
Public Class TextBoxIconWUI
    Inherits UserControl

    Private _icon As String = ChrW(&HF007) ' fa-user
    Private _iconColor As Color = Color.Gray
    Private _faFont As New Font("Font Awesome 6 Free Solid", 10)
    Private _borderRadius As Integer = 6
    Private _focusColor As Color = Color.DeepSkyBlue
    Private _borderColor As Color = Color.Gray
    Private _backColorCustom As Color = Color.White
    Private _textBox As New TextBox With {.BorderStyle = BorderStyle.None, .Font = New Font("Segoe UI", 10)}

    Private _hasFocus As Boolean = False

    Public Sub New()
        Me.Size = New Size(297, 35)
        Me.BackColor = Color.Transparent
        Me.DoubleBuffered = True
        _textBox.Location = New Point(35, 8)
        _textBox.Width = Me.Width - 40
        Me.Controls.Add(_textBox)
        AddHandler _textBox.GotFocus, Sub()
                                          _hasFocus = True
                                          Me.Invalidate()
                                      End Sub
        AddHandler _textBox.LostFocus, Sub()
                                           _hasFocus = False
                                           Me.Invalidate()
                                       End Sub
    End Sub

    <Category("WilmerUI")>
    Public Property IconUnicode As String
        Get
            Return _icon
        End Get
        Set(value As String)
            _icon = value
            Me.Invalidate()
        End Set
    End Property

    <Category("WilmerUI")>
    Public Property IconColor As Color
        Get
            Return _iconColor
        End Get
        Set(value As Color)
            _iconColor = value
            Me.Invalidate()
        End Set
    End Property

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

    Public ReadOnly Property TextBoxRef As TextBox
        Get
            Return _textBox
        End Get
    End Property

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        Dim g = pe.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        ' Fondo
        g.FillRectangle(New SolidBrush(_backColorCustom), rect)

        ' Borde
        Dim penColor = If(_hasFocus, _focusColor, _borderColor)
        Using pen As New Pen(penColor, 1.5F)
            g.DrawRectangle(pen, rect)
        End Using

        ' Ícono FontAwesome
        Dim iconRect = New Rectangle(8, 8, 20, 20)
        TextRenderer.DrawText(g, _icon, _faFont, iconRect, _iconColor, TextFormatFlags.NoPadding)
    End Sub

    'COMO USARLO EN EL FORMULARIO

    'Dim txtUsuario As New TextBoxIconWilmer()
    'txtUsuario.IconUnicode = ChrW(&HF007) ' fa-user
    'txtUsuario.IconColor = Color.DarkGray
    'txtUsuario.TextBoxRef.Text = "Wilmer Dev"
    'Me.Controls.Add(txtUsuario)

End Class
