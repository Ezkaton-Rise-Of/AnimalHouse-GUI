using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;

namespace AnimalHouseDB
{
    public interface IAnsatDB
    {
        string OpretAnsat(Ansat a);
        string UpdateAnsat(Ansat a);
        string SletAnsat(Ansat a);
        Ansat HentAnsat(int ansatId);
        Ansat HentAnsatByNavn (string ansatNavn);
        List<Ansat> HentAlleAnsatte();
        List<Ansat> HentAnsateByType(int ansattype);
        int HentAnsatId(string navn);
        string HentAnsatNavn(int id);
        List<Ansat> HentAlleBehandler();
        List<Ansat> HentAnsatByNavn2(string ansatNavn);
    }
}
