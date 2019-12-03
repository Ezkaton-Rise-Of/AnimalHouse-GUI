using System.Collections.Generic;
using System.Threading;

namespace AnimaleHouseModel
{
    public class EmailSystem
    {
        public List<AnimalHouse_Entities.Email> EmailList = new List<AnimalHouse_Entities.Email>();
        public EmailSystem() { }
        public void CreateEmail()
        {
            foreach (AnimalHouse_Entities.Email email in EmailList)
            {
                Thread t = new Thread(() => SendEmail(email));
                t.Start();
            }
        }
        public void SendEmail(AnimalHouse_Entities.Email e)
        {
            Email email = new Email();
            email.SendEmail(e.Title, e.Indhold, e.ModtagerEmaiL);
        }
    }
}
