Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxItem(True)>
<DesignerCategory("WilmerUI")>
<Description("Botón animado estilo Material Design tipo WilmerUI")>
Public Class ButtonWUI
    Inherits Button

    Private _rippleColor As Color = Color.FromArgb(100, Color.White)
    Private _baseColor As Color = Color.DeepSkyBlue
    Private _textColor As Color = Color.White
    Private rippleRadius As Integer = 0
    Private isRippling As Boolean = False
    Private rippleOrigin As Point

    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        Me.BackColor = _baseColor
        Me.ForeColor = _textColor
        Me.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        Me.Size = New Size(120, 35)
        Me.DoubleBuffered = True
    End Sub

    <Category("WilmerUI")>
    Public Property RippleColor As Color
        Get
            Return _rippleColor
        End Get
        Set(value As Color)
            _rippleColor = value
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

    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        MyBase.OnMouseDown(mevent)
        rippleOrigin = mevent.Location
        rippleRadius = 0
        isRippling = True
        Dim timer As New Timer With {.Interval = 15}
        AddHandler timer.Tick, Sub()
                                   rippleRadius += 8
                                   If rippleRadius > Me.Width * 2 Then
                                       isRippling = False
                                       timer.Stop()
                                       timer.Dispose()
                                   End If
                                   Me.Invalidate()
                               End Sub
        timer.Start()
    End Sub

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)

        ' Ripple efecto
        If isRippling Then
            Using g As Graphics = pe.Graphics
                g.SmoothingMode = SmoothingMode.AntiAlias
                Using brush As New SolidBrush(_rippleColor)
                    g.FillEllipse(brush, rippleOrigin.X - rippleRadius, rippleOrigin.Y - rippleRadius, rippleRadius * 2, rippleRadius * 2)
                End Using
            End Using
        End If
    End Sub

    'COMO USARLO EN EL FOMULARIO

    'Dim btnGuardar As New ButtonMaterialWilmer()
    'btnGuardar.Text = "Guardar"
    'btnGuardar.BaseColor = Color.MediumSeaGreen
    'btnGuardar.RippleColor = Color.FromArgb(120, Color.White)
    'btnGuardar.TextColor = Color.White
    'Me.Controls.Add(btnGuardar)

End Class
