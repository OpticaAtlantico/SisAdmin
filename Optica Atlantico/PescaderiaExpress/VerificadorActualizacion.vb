Imports System.Net
Imports Newtonsoft.Json

Public Class VerificadorActualizacion
    ''' <summary>
    ''' Consulta la versión más reciente publicada y compara con la instalada.
    ''' </summary>
    ''' <param name="miVersion">Versión actual de tu aplicación (ej: "1.2.0")</param>
    ''' <param name="versionOnline">Se devuelve la versión publicada</param>
    ''' <param name="urlDescarga">Se devuelve la URL de descarga desde GitHub</param>
    ''' <param name="notas">Texto con novedades de la versión</param>
    ''' <returns>True si hay versión nueva; False si estás actualizado</returns>
    Public Shared Function HayNuevaVersion(miVersion As String,
                                           ByRef versionOnline As String,
                                           ByRef urlDescarga As String,
                                           ByRef notas As String) As Boolean
        Try
            Dim urlJson As String = "https://raw.githubusercontent.com/OpticaAtlantico/SisAdmin/main/Ultima_Version.json"
            Dim jsonStr As String = New WebClient().DownloadString(urlJson)

            Dim data = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(jsonStr)

            versionOnline = data("version")
            urlDescarga = data("url_descarga")
            notas = data("notas")

            Return (versionOnline <> miVersion)

        Catch ex As Exception
            ' En caso de error (sin internet, archivo no accesible...), se considera sin actualización.
            Return False
        End Try
    End Function
End Class
