Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxItem(True)>
<DesignerCategory("WilmerUI")>
<Description("Botón de alternancia de tema claro/oscuro estilo WilmerUI")>
Public Class ThemeToggleWUI
    Inherits Button

    Private _isDark As Boolean = False
    Private _lightColor As Color = Color.White
    Private _darkColor As Color = Color.FromArgb(30, 30, 30)
    Private _lightTextColor As Color = Color.Black
    Private _darkTextColor As Color = Color.White
    Private _onThemeChanged As Action(Of Boolean)

    Public Sub New()
        Me.Size = New Size(140, 35)
        Me.FlatStyle = FlatStyle.Flat
        Me.Font = New Font("Font Awesome 6 Free Solid", 10)
        Me.Text = ChrW(&HF185) & " Claro"
        Me.BackColor = _lightColor
        Me.ForeColor = _lightTextColor
    End Sub

    <Category("WilmerUI")>
    Public Property IsDarkTheme As Boolean
        Get
            Return _isDark
        End Get
        Set(value As Boolean)
            _isDark = value
            Me.Text = If(value, ChrW(&HF186) & " Oscuro", ChrW(&HF185) & " Claro")
            Me.BackColor = If(value, _darkColor, _lightColor)
            Me.ForeColor = If(value, _darkTextColor, _lightTextColor)
            _onThemeChanged?.Invoke(_isDark)
            Me.Invalidate()
        End Set
    End Property

    <Category("WilmerUI")>
    Public Property OnThemeChanged As Action(Of Boolean)
        Get
            Return _onThemeChanged
        End Get
        Set(value As Action(Of Boolean))
            _onThemeChanged = value
        End Set
    End Property

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        Me.IsDarkTheme = Not Me.IsDarkTheme
    End Sub

    'COMO USARLO

    'Dim themeToggle As New WilmerThemeToggle()
    'themeToggle.Location = New Point(10, 10)
    'themeToggle.OnThemeChanged = Sub(isDark)
    'Me.BackColor = If(isDark, Color.FromArgb(30, 30, 30), Color.White)
    '' Aplica colores a tus controles WilmerUI...
    'End Sub
    'Me.Controls.Add(themeToggle)

End Class
