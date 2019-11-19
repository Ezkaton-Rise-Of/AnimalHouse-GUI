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
        string SletKunde(int id);
        string UpdateKunde(Kunde k);
        Kunde HentKundeByTlf(string tlf);
        List<Kunde> HentAlleKunder();

    }
}
