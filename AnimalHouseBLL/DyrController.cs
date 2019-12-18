using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;

namespace AnimalHouseBLL
{
    public class DyrController
    {
        IDyrDB DyrDB;
        public DyrController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            DyrDB = persistensFactory.GetDyrDB();
        }

        public string OpretDyr(int kundeId, string art, string race, int alder, char sex,string behandler)
        {
            Dyr d = new Dyr(kundeId, art, race, alder, sex,behandler);
            return DyrDB.OpretDyr(d);
        }

        public List<Dyr> HentAlleDyr()
        {
            return DyrDB.HentAlleDyr();
        }

        public List<Dyr> HentAlleKundesDyr(int Kundeid)
        {
            return DyrDB.HentDyrByKundeId(Kundeid);
        }

        public Dyr HentDyr(int id) 
        {
            return DyrDB.HentDyr(id); 
        }

        public string SletDyr(int id)
        {
            return DyrDB.SletDyr(id);
        }

        public string UpdateDyr(int dyrId, int kundeId, string art, string race, int alder, char sex) {
            Dyr d = new Dyr();
            d.Alder = alder;
            d.DyrId = dyrId;
            d.Art = art;
            d.KundeId = kundeId;
            d.Race = race;
            d.Sex = sex;
            return DyrDB.UpdaterDyr(d);
                }


        internal void TilknytBehandler(int dyrId, string behandler)
        {
            DyrDB.TilknytBehandler(dyrId, behandler);
        }
    }
}
