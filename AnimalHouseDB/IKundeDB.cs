// Radwan
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using System_Entities;

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
        string HentByNavn(string postnr);

        List<Kunde> HentKunderByTlfOrNavn(string input);
        int HentKundeId(string tlf);
    }
}
