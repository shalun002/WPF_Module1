using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Wpf_Module1.Module
{
    public class Helper
    {
        public string SendMail(string to, string subject)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("shalun002@gmail.com", "Master Zen");

            msg.To.Add(to);
            msg.Subject = subject;
            msg.Body = "Tesb Body";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("shalun002@gmail.com", "");

            try
            {
                smtp.Send(msg);
                return "Сообщение отправлено!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}