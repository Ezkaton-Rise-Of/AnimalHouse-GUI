using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseDB;
using System_Entities;

namespace AnimalHouseBLL
{
    public class JournalController
    {
        IJournal journalDB;
        public JournalController()
        {
            PersistensFactory pf = PersistensFactory.GetInstance();
            journalDB = pf.GetJournalDB();
        }

        public string OpretJournal(int ansatid, int dyrid, string beskrivelse)
        {
            Journal j = new Journal(ansatid, dyrid, beskrivelse);
            return journalDB.OpretJournal(j);
        }

        public string SletJournal(int id)
        {
            return journalDB.SletJournal(id);
        }

        public List<Journal> HentAlleJournale()
        {
            return journalDB.HentAlleJournale();
        }

        public List<Journal> HentAlleDyrJournale(int dyrid)
        {
            return journalDB.HentAlleDyrJournale(dyrid);
        }

        public List<Journal> HentAlleAnsatJournal(int ansatid)
        {
            return journalDB.HentAlleAnsatJournale(ansatid);
        }
        public Journal HentJournal(int id)
        {
            return journalDB.HentJournal(id);
        }
    }
}
