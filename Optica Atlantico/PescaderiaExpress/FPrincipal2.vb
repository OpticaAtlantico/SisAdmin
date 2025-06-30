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
        'Dim miVersion As String = FileVersionInfo.GetVersionInfo(rutaExe).ProductVersion

        'Dim verOnline As String = "", url As String = "", notas As String = ""

        'If VerificadorActualizacion.HayNuevaVersion(miVersion, verOnline, url, notas) Then
        '    Dim form As New FVerificarActualizacion With {
        '    .VersionActual = miVersion,
        '    .VersionNueva = verOnline,
        '    .URLDescarga = url,
        '    .Notas = notas
        '}

        '    form.ShowDialog()

        '    ' Puedes cerrar la app si deseas evitar que continúe con versión anterior:
        '    'Application.Exit()
        '    Return
        'End If

        ' Si no hay nueva versión, continúa con la lógica normal de carga
    End Sub
End Class