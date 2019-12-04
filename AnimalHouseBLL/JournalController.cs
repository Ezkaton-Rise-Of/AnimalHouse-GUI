using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;

namespace AnimalHouseBLL
{
    public class JournalController
    {
        IJournal journalDB;

        public JournalController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            journalDB = persistensFactory.GetJournalDB();
        }
        public List<Journal> HentAlleJournial()
        {
            return journalDB.HentAlleJournal();           
        }

        public List<Journal> HentAlleAnsatJournial(int ansatid)
        {
            return journalDB.HentAlleAnsatjournal(ansatid);
        }

        public List<Journal> HentAlleDyrJournial(int dyrid)
        {
            return journalDB.HentAlleDyrJournal(dyrid);
        }

        public string SletJournal(int id)
        {
            return journalDB.SletJournal(id);
        }

        public string OpretJournal(Journal j)
        {
            return journalDB.OpretJournal(j);
        }
    }
}
