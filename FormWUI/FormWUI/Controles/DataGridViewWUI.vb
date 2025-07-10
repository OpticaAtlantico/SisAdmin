Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxItem(True)>
<DesignerCategory("WilmerUI")>
<Description("DataGridView visual con estilo WilmerUI y columnas con íconos")>
Public Class DataGridViewWUI
    Inherits DataGridView

    Public Sub New()
        Me.DoubleBuffered = True
        Me.EnableHeadersVisualStyles = False
        Me.BackgroundColor = Color.White
        Me.BorderStyle = BorderStyle.None
        Me.GridColor = Color.LightGray
        Me.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Estilo encabezado
        Me.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
        Me.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.ColumnHeadersHeight = 36

        ' Estilo celdas
        Me.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        Me.DefaultCellStyle.BackColor = Color.White
        Me.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        Me.DefaultCellStyle.SelectionForeColor = Color.Black
        Me.RowTemplate.Height = 36
    End Sub

    Protected Overrides Sub OnCellPainting(e As DataGridViewCellPaintingEventArgs)
        MyBase.OnCellPainting(e)

        ' Personalización para columnas con íconos (ejemplo índice 0, 1 y 2)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso Me.Columns(e.ColumnIndex) IsNot Nothing Then
            Dim nombreCol = Me.Columns(e.ColumnIndex).Name.ToLower()

            If nombreCol = "ver" OrElse nombreCol = "editar" OrElse nombreCol = "eliminar" Then
                e.PaintBackground(e.CellBounds, True)
                Dim iconoUnicode As String = ChrW(&HF06E) ' fa-eye por defecto

                If nombreCol = "editar" Then iconoUnicode = ChrW(&HF044) ' fa-edit
                If nombreCol = "eliminar" Then iconoUnicode = ChrW(&HF1F8) ' fa-trash

                Dim faFont = New Font("Font Awesome 6 Free Solid", 12)
                Dim iconSize = TextRenderer.MeasureText(iconoUnicode, faFont)
                Dim centerX = e.CellBounds.Left + (e.CellBounds.Width - iconSize.Width) \ 2
                Dim centerY = e.CellBounds.Top + (e.CellBounds.Height - iconSize.Height) \ 2
                Dim iconRect = New Rectangle(centerX, centerY, iconSize.Width, iconSize.Height)

                TextRenderer.DrawText(e.Graphics, iconoUnicode, faFont, iconRect, Color.Gray)
                e.Handled = True
            End If
        End If
    End Sub

    'COMO USUARLO

    'Dim colVer As New DataGridViewTextBoxColumn() With {.Name = "Ver", .Width = 40}
    'Dim colEdit As New DataGridViewTextBoxColumn() With {.Name = "Editar", .Width = 40}
    'Dim colDelete As New DataGridViewTextBoxColumn() With {.Name = "Eliminar", .Width = 40}

    'DataGridViewWilmerUI1.Columns.AddRange({colVer, colEdit, colDelete})

    'Recuerda que puedes capturar eventos en "CellClick" para cada acción.

End Class
