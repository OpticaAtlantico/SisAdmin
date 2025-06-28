Imports System.Net.Mail
Imports System.Net

Public Class EmailSender
    Private ReadOnly smtpServer As String = "smtp-mail.outlook.com"
    Private ReadOnly smtpPort As Integer = 587
    Private ReadOnly enableSSL As Boolean = True

    ' Método para enviar correos
    Public Function EnviarCorreo(ByVal remitente As String, ByVal contraseña As String,
                                 ByVal destinatario As String, ByVal asunto As String,
                                 ByVal cuerpo As String, ByVal archivoAdjunto As String) As Boolean
        Try
            Using smtp As New SmtpClient(smtpServer)
                smtp.Port = smtpPort
                smtp.EnableSsl = enableSSL
                smtp.Credentials = New NetworkCredential(remitente, contraseña)

                ' Configuración del mensaje
                Using correo As New MailMessage()
                    correo.From = New MailAddress(remitente)
                    correo.To.Add(destinatario)
                    correo.Subject = asunto
                    correo.Body = cuerpo
                    correo.IsBodyHtml = True ' Permite formato HTML

                    ' Adjuntar archivo si existe
                    If Not String.IsNullOrEmpty(archivoAdjunto) AndAlso IO.File.Exists(archivoAdjunto) Then
                        correo.Attachments.Add(New Attachment(archivoAdjunto))
                    End If

                    ' Enviar correo
                    smtp.Send(correo)
                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
