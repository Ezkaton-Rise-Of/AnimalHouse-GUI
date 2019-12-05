using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Entities;

namespace AnimalHouseDB
{
    public interface IJournal
    {
        List<Journal> HentAlleJournale();
        List<Journal> HentAlleDyrJournale(int dyrid);
        List<Journal> HentAlleAnsatJournale(int ansatid);
        string OpretJournal(Journal j);
        string SletJournal(int id);
        Journal HentJournal(int id);
    }
}
