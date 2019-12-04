using System.Collections.Generic;
using System.Threading;
using AnimalHouse_Entities;

namespace AnimaleHouseModel
{
    public class EmailSystem
    {
        public List<Email> EmailList = new List<Email>();
        public EmailSystem() { }
        public void CreateEmail()
        {
            foreach (Email email in EmailList)
            {
                Thread t = new Thread(() => SendEmail(email));
                t.Start();
            }
        }
        private void SendEmail(Email e)
        {
            Email email = new Email();
            //email.SendEmail(e.Title, e.Indhold, e.ModtagerEmaiL);
        }
    }
}
