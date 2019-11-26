using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseDB;
using System_Entities;

namespace AnimalHousePersistenslag
{
    public class AnsatController
    {
        IAnsatDB ansatDB;
        public List<Ansat> A;

        public AnsatController()
        {
            A = ansatDB.HentAlleAnsate();
        }

        public string OpretAnsat(Ansat a)
        {
            return ansatDB.OpretAnsat(a);
        }
        public string SeltAnsat(int ansatId)
        {
            return ansatDB.SletAnsat(ansatId);
        }

        public string UpdateAnsat(Ansat a)
        {
            return ansatDB.UpdateAnsat(a);
        }
        public Ansat HentAnsatById(int ansatid)
        {
            return ansatDB.HentAnsatById(ansatid);
        }
        public List<Ansat> HentAlleAnsate()
        {
            return ansatDB.HentAlleAnsate();
        }
        public List<Ansat> HentAnsateByType(int ansattype)
        {
            return ansatDB.HentAnsateByType(ansattype);
        }
        public Ansat HentAnsatByName(string navn)
        {
            return ansatDB.HentAnsatByNavn(navn);
        }

    }
}
