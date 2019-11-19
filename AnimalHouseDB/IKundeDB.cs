using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
namespace AnimalHouseDB
{
    public interface IKundeDB
    {
        string OpretKunde(Kunde k);
        Kunde HentKundeById(int id);
        string DeleteKunde(int id);
        string UpdateKunde(Kunde k, int id);
        Kunde HentKundeByTlf(string k);
        List<Kunde> HentAlleKunder();

    }
}
