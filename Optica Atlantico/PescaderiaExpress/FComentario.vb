Public Class FComentario

    Private Sub FComentario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TComentario.Focus()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Select Case VarForma
            Case "Facturacion"
                FFacturacion.Grid.Rows(FFacturacion.Grid.CurrentCell.RowIndex).Cells("Observacion").Value = Me.TComentario.Text
        End Select
        Me.Close()
    End Sub
End Class