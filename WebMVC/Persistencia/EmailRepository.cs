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
        public void EnviarCorreo(StringBuilder mailBody, string userEmail)
        {
            MailMessage email = new MailMessage();
            iniciarMail(email, mailBody, userEmail);
            SmtpClient smtp = new SmtpClient();
            iniciarSMTP(smtp);
            try
            {
                smtp.Send(email);
                liberarServicios(email, smtp);
            }
            catch (Exception ex)
            {
                liberarServicios(email, smtp);
            }
        }

        private void liberarServicios(MailMessage email, SmtpClient smtp)
        {
            email.Dispose();
            smtp.Dispose();
        }

        private void iniciarMail(MailMessage email, StringBuilder mailBody, string userEmail)
        {
            string[] str_array = userEmail.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < str_array.Length; i++)
            {
                email.To.Add(new MailAddress(str_array[i].ToString()));
            }
            email.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["emailcuenta"]);  
            email.Body = mailBody.ToString();
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }
        private void iniciarSMTP(SmtpClient smtp)
        {
            smtp.Host = ConfigurationSettings.AppSettings["exchange"].ToString();
            smtp.Port = 25;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["emailuser"], System.Configuration.ConfigurationManager.AppSettings["emailpass"]);
            //smtp.UseDefaultCredentials = true;
            //smtp.Credentials = CredentialCache.DefaultNetworkCredentials;
        }
    }
}
