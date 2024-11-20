using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;

public class EmailService
{
    private string smtpServer;
    private int smtpPort;
    private string smtpUsername = "unilocalsoporte@gmail.com";
    private string smtpPassword = "ykrl arao twvr bgbb";

    // Constructor para inicializar la clase con la configuración SMTP
    public EmailService()
    {
        this.smtpServer = "smtp.gmail.com";
        this.smtpPort = 587;
    }

    // Método para enviar correo con formato HTML
    public bool SendEmail(string toEmail, string subject, string bodyHtml, List<string> attachments = null)
    {
        try
        {
            // Configuración del cliente SMTP
            using (SmtpClient smtpClient = new SmtpClient(smtpServer))
            {
                smtpClient.Port = smtpPort;
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                // Crear el mensaje de correo
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.Subject = subject;
                    mailMessage.Body = bodyHtml;
                    mailMessage.IsBodyHtml = true;

                    // Agregar destinatarios
                    mailMessage.To.Add(toEmail);

                    // Agregar archivos adjuntos si existen
                    if (attachments != null)
                    {
                        foreach (string filePath in attachments)
                        {
                            mailMessage.Attachments.Add(new Attachment(filePath));
                        }
                    }

                    // Enviar el correo
                    smtpClient.Send(mailMessage);
                }
            }

            Console.WriteLine("Correo enviado exitosamente.");
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al enviar el correo: {ex.Message}");
            return false;
        }
    }

    // Método para crear un cuerpo de correo en formato HTML
    public string CreateHtmlBody(string title, string content)
    {
        return $@"
        <html>
            <head>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        color: #333;
                    }}
                    .email-container {{
                        width: 600px;
                        margin: 0 auto;
                        padding: 20px;
                        background-color: #f9f9f9;
                        border: 1px solid #ddd;
                    }}
                    .email-header {{
                        font-size: 24px;
                        font-weight: bold;
                        color: #4CAF50;
                    }}
                    .email-body {{
                        font-size: 16px;
                        margin-top: 10px;
                    }}
                </style>
            </head>
            <body>
                <div class='email-container'>
                    <div class='email-header'>{title}</div>
                    <div class='email-body'>{content}</div>
                </div>
            </body>
        </html>";
    }
}
