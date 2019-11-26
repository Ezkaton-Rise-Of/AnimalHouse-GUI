using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Entities;

namespace AnimalHouseDB
{
    public interface IAnsatDB
    {
        string OpretAnsat(Ansat a);
        string UpdateAnsat(Ansat a);
        string SletAnsat(int ansatId);
        Ansat HentAnsatById(int ansatId);
        Ansat HentAnsatByNavn (string ansatNavn);
        List<Ansat> HentAlleAnsate();
        List<Ansat> HentAnsateByType(int ansattype);
    }
}
