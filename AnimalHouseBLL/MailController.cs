using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;
namespace AnimalHouseBLL
{
    public class MailController
    {
        IEmail EmailDB;

        public List<Email> Emails = new List<Email>();

        public MailController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            EmailDB = persistensFactory.GetEmailDB();
           }

        public void HentEmail(int emailid)
        {

           Emails = EmailDB.HentEmail(emailid);
        }

        public void HentAlleEmails()
        {
            Emails = EmailDB.HentEmails();
        }

        public void HentEmailsByKunde(int Kundeid)
        {
            Emails = EmailDB.HentEmailsByKunde(Kundeid);
        }

        public bool InsertMail(Email e)
        {
            return EmailDB.InsertMail(e);
        }
    }
}
