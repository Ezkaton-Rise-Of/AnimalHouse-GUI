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
        Email HentEmail();
        List<Email> HentEmails();
        List<Email> HentEmailsByKunde(int id);
        bool InsertMail(Email E);

        
    }
}
