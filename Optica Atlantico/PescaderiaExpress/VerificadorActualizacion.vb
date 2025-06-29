Imports System.Net
Imports Newtonsoft.Json

Public Class VerificadorActualizacion
    Public Shared Function HayNuevaVersion(miVersion As String, ByRef versionOnline As String, ByRef urlDescarga As String, ByRef notas As String) As Boolean
        Try
            Dim urlJson As String = "https://raw.githubusercontent.com/OpticaAtlantico/SisAdmin/main/Ultima_Version.json"
            Dim jsonData As String = New WebClient().DownloadString(urlJson)
            Dim info = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(jsonData)

            versionOnline = info("version")
            urlDescarga = info("url_descarga")
            notas = info("notas")

            Return (versionOnline <> miVersion)
        Catch
            Return False
        End Try
    End Function
End Class
