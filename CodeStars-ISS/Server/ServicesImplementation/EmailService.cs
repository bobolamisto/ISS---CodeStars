using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Server.ServicesImplementation
{
    class EmailService : IEmailService
    {
        public void SendEmail(string toEmail, string subject, string message)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("codestars.iss@gmail.com");
            msg.To.Add(toEmail);
            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            System.Net.NetworkCredential netc = new NetworkCredential();
            netc.UserName = "codestars.iss@gmail.com";
            netc.Password = "codestars123";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = netc;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(msg);
                //Console.WriteLine("E-mail trimis cu succes!");
            }
            catch (Exception e)
            {
                throw e;
                //Console.WriteLine(e.ToString());
            }
        }
    }
}
