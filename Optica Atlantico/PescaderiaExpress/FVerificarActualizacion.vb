Public Class FVerificarActualizacion
    Public Property VersionActual As String
    Public Property VersionNueva As String
    Public Property URLDescarga As String
    Public Property Notas As String

    Private Sub FVerificarActualizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersionActual.Text = $"Versión actual: {VersionActual}"
        lblVersionDisponible.Text = $"Versión disponible: {VersionNueva}"
        rtxNotas.Text = Notas
        progressBar.Value = 0 ' Inicializa la barra de progreso
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class