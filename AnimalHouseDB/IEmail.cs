using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
namespace AnimalHouseDB
{
    public interface IEmail
    {
        List<Email> HentEmail(int id);
        List<Email> HentEmails();
        List<Email> HentEmailsByKunde(int id);
        bool InsertMail(Email E);
        List<Dyr> HentKunderDerManglerMail(int mailLast, int visitLast);

        
    }
}
