//Holger
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseDB;
using AnimalHouse_Entities;
namespace AnimalHouseBLL
{
    public class EmailController
    {
        IEmail emailDB;
        public List<Email> emailList;

        public EmailController()
        {
            //A = ansatDB.HentAlleAnsate();
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            emailDB = persistensFactory.GetEmailDB();  
        }

        public void HentEmail(int emailId)
        {
            emailList = emailDB.HentEmail(emailId);
        }

        public void HentAlleEmails()
        {
            emailList = emailDB.HentEmails();
        }

        public void HentEmailsByKunde(int emailId)
        {
            emailList = emailDB.HentEmailsByKunde(emailId);
        }

        public bool InsertEmail(Email e)
        {
            return emailDB.InsertMail(e);
        }

        public List<Dyr> HentDyrDerManglerMail(int visit, int mail)
        {
            return emailDB.HentKunderDerManglerMail(visit, mail);
        }



    }
}
