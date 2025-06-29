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

    Private Sub FPrincipal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim miVersion As String = "1.0.0.17" ' ← versión actual de tu app
        Dim verOnline As String = "", url As String = "", notas As String = ""

        If VerificadorActualizacion.HayNuevaVersion(miVersion, verOnline, url, notas) Then
            Dim msg As String = $"Hay una nueva versión disponible: v{verOnline}.{vbCrLf}{vbCrLf}¿Deseas descargarla ahora?" &
                                $"{vbCrLf}{vbCrLf}Novedades:{vbCrLf}{notas}"

            If MessageBox.Show(msg, "Actualización disponible", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Process.Start(url)
                Application.Exit()
            End If
        End If
    End Sub
End Class