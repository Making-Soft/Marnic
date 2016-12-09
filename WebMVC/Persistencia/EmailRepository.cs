using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace WebMVC.Persistencia
{
    class EmailRepository
    {
        public void SendEmail(string ToAddress, string subject, string body, bool isBodyHtml = true)
        {
            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(ToAddress); 
            mailMessage.To.Add("info@marniciluminacion.com.ar");
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.IsBodyHtml = isBodyHtml;

            var smtpClient = new SmtpClient { EnableSsl = false };
            smtpClient.Send(mailMessage);
        }
    }
}
