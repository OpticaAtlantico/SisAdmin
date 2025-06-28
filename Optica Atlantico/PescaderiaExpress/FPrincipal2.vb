Imports System.Data.SqlClient
Public Class FPrincipal2
    Dim numOptica As Integer
    Private Sub BMantenimiento_Click(sender As Object, e As EventArgs) Handles BMantenimiento.Click
        FFacturacion.ShowDialog()
    End Sub
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub
    Private Sub BReportes_Click(sender As Object, e As EventArgs) Handles BReportes.Click, Button5.Click
        FReportesRango.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FReporteSemanal.ShowDialog()
    End Sub

End Class