using System;
using System.Net;
using System.Net.Mail;


namespace Capa_Negocios
{
    public class Mail
    {
        MailMessage m = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        // correo , contrase;a asunto , aquien va dirigido, mensaje
        public bool Enviar(string from, string contra, string asun, string to, string mensaje)
        {
            try
            {
                m.From = new MailAddress(from);//desde donde envio 
                m.To.Add(new MailAddress(to));//aquien envio 
                m.Body = mensaje;
                m.Subject = asun;

                smtp.Host = "smtp.mail.yahoo.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(from, contra);
                smtp.EnableSsl = true;
                smtp.Timeout = 60000;

                smtp.Send(m);
                m.IsBodyHtml = true;
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
                throw;
            }
        }
    }
}
