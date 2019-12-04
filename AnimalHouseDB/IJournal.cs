using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;

namespace AnimalHouseDB
{
    public interface IJournal
    {
        List<Journal> HentAlleJournal();
        List<Journal> HentAlleDyrJournal(int dyrId);
        List<Journal> HentAlleAnsatjournal(int ansatId);
        string OpretJournal(Journal j);
        string SletJournal(int id);
    }
}
