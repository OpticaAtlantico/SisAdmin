Imports System.IO
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports System.Threading

Module GmailOAuth
    Public Function ObtenerCredenciales() As UserCredential
        Dim credPath As String = "token.json"

        Using stream = New FileStream("client_secret.json", FileMode.Open, FileAccess.Read)
            Dim secrets = GoogleClientSecrets.FromStream(stream)
            Dim credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                secrets.Secrets,
                {GmailService.Scope.GmailSend},
                "user",
                CancellationToken.None,
                New FileDataStore(credPath, True)
            ).Result

            Return credential
        End Using

    End Function
End Module
