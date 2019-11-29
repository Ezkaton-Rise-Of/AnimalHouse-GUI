using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
namespace AnimaleHouseModel
{
    
    
    public class Email
    {
        MailMessage mail = new MailMessage();
        SmtpClient client;
        string OwnerEmail;
        
        public Email(string password = "Ld8m8N!-wV0V", string ownerEmail = "AnimalHouseHRK@gmail.com")
        {
            OwnerEmail = ownerEmail;
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(ownerEmail, password);
            client.EnableSsl = true;
        }

        public bool SendEmail(string subject, string message, string userEmail)
        {
            try
            {
                mail.From = new MailAddress(OwnerEmail);
                mail.Subject = subject;
                mail.Body = message;
                mail.To.Add(userEmail);
                client.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }




    }
}
