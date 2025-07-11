Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Gestor global para aplicar tema claro u oscuro a formularios con controles WilmerUI.
''' </summary>
Public Module ThemeManagerWUI

    ''' <summary>
    ''' Aplica el tema claro a todos los controles compatibles del formulario.
    ''' </summary>
    Public Sub ApplyLightTheme(formulario As Form)
        formulario.BackColor = Color.White

        For Each ctrl In formulario.Controls
            If TypeOf ctrl Is TextBoxWUI Then
                With CType(ctrl, TextBoxWUI)
                    .BackgroundColorCustom = Color.White
                    .ForeColor = Color.Black
                    .FocusBorderColor = Color.DeepSkyBlue
                End With
            ElseIf TypeOf ctrl Is ComboBoxWUI Then
                With CType(ctrl, ComboBoxWUI)
                    .BackColor = Color.White
                    .TextColor = Color.Black
                    .FocusColor = Color.DeepSkyBlue
                End With
            ElseIf TypeOf ctrl Is CommandButtonWUI Then
                With CType(ctrl, CommandButtonWUI)
                    .BaseColor = Color.SteelBlue
                    .TextColor = Color.White
                End With
            ElseIf TypeOf ctrl Is OptionButtonWUI Then
                With CType(ctrl, OptionButtonWUI)
                    .CheckedColor = Color.DeepSkyBlue
                    .TextColor = Color.Black
                End With
            End If
        Next
    End Sub

    ''' <summary>
    ''' Aplica el tema oscuro a todos los controles compatibles del formulario.
    ''' </summary>
    Public Sub ApplyDarkTheme(formulario As Form)
        formulario.BackColor = Color.FromArgb(30, 30, 30)

        For Each ctrl In formulario.Controls
            If TypeOf ctrl Is TextBoxWUI Then
                With CType(ctrl, TextBoxWUI)
                    .BackgroundColorCustom = Color.FromArgb(45, 45, 45)
                    .ForeColor = Color.White
                    .FocusBorderColor = Color.MediumPurple
                End With
            ElseIf TypeOf ctrl Is ComboBoxWUI Then
                With CType(ctrl, ComboBoxWUI)
                    .BackColor = Color.FromArgb(45, 45, 45)
                    .TextColor = Color.White
                    .FocusColor = Color.MediumPurple
                End With
            ElseIf TypeOf ctrl Is CommandButtonWUI Then
                With CType(ctrl, CommandButtonWUI)
                    .BaseColor = Color.MediumPurple
                    .TextColor = Color.White
                End With
            ElseIf TypeOf ctrl Is OptionButtonWUI Then
                With CType(ctrl, OptionButtonWUI)
                    .CheckedColor = Color.MediumPurple
                    .TextColor = Color.White
                End With
            End If
        Next
    End Sub


    'COMO USARLO

    'themeToggle.OnThemeChanged = Sub(isDark)
    'If isDark Then
    '    ThemeManagerWilmerUI.ApplyDarkTheme(Me)
    'Else
    '    ThemeManagerWilmerUI.ApplyLightTheme(Me)
    'End If
    'End Sub

End Module
