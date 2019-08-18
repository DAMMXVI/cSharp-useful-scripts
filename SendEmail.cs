using System;
using System.Linq;
using System.Net.Mail;

namespace Web_Programming_Project.Methods 
{
    public class SendEmail 
    {
        public static bool sendMail(string toMail, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage("yourmail@gmail.com", toMail, subject, body);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new System.Net.NetworkCredential("yourmail@gmail.com", "yourpass");
                client.EnableSsl = true;
                client.Send(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}