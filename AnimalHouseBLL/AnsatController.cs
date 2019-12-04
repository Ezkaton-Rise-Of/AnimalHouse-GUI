using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseDB;
using AnimalHouse_Entities;

namespace AnimalHouseBLL
{
    public class AnsatController
    {
        IAnsatDB ansatDB;
        public List<Ansat> A;

        public AnsatController()
        {
            //A = ansatDB.HentAlleAnsate();
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            ansatDB = persistensFactory.GetAnsatDB();
        }

        public string OpretAnsat(Ansat a)
        {
            return ansatDB.OpretAnsat(a);
        }
        public string SletAnsat(int ansatId)
        {
            return ansatDB.SletAnsat(ansatId);
        }
        public int HentAnsatId(string navn)
        {
            return ansatDB.HentAnsatId(navn);
        }
        public string UpdateAnsat(int id, string navn, string stelling, string tlf)
        {
            Ansat a = new Ansat(id, navn, stelling, tlf);
            return ansatDB.UpdateAnsat(a);
        }
        public Ansat HentAnsatById(int ansatid)
        {
            return ansatDB.HentAnsatById(ansatid);
        }
        public List<Ansat> HentAlleAnsatte()
        {
            return ansatDB.HentAlleAnsatte();
        }
        public List<Ansat> HentAnsateByType(int ansattype)
        {
            return ansatDB.HentAnsateByType(ansattype);
        }
        public Ansat HentAnsatByName(string navn)
        {
            return ansatDB.HentAnsatByNavn(navn);
        }

        public List<Ansat> HentAnsateByNavn(string ansatNavn)
        {
            return ansatDB.HentAnsateByNavn(ansatNavn);
        }
    }
}
