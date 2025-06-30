Imports System.Diagnostics
Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json

Module GeneradorJson
    Sub Main()
        Dim rutaExe = "C:\MiApp\bin\Release\MiApp.exe"
        Dim version = FileVersionInfo.GetVersionInfo(rutaExe).ProductVersion
        Dim fecha = Date.Today.ToString("yyyy-MM-dd")
        Dim urlZip = $"https://github.com/OpticaAtlantico/SisAdmin/releases/download/v{version}/MiApp_v{version}.zip"
        Dim changelog = File.ReadAllText("changelog.txt")

        Dim info = New Dictionary(Of String, String) From {
            {"version", version},
            {"fecha", fecha},
            {"url_descarga", urlZip},
            {"notas", changelog}
        }

        File.WriteAllText("ultima-version.json", JsonConvert.SerializeObject(info, Newtonsoft.Json.Formatting.Indented))
        Console.WriteLine("✅ JSON generado correctamente.")
    End Sub
End Module