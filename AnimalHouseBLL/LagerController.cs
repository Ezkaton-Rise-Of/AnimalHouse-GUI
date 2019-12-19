using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;

namespace  AnimalHouseBLL
{
    public class LagerController
    {
        ILagerDB LagerDB;
        public LagerController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            LagerDB = persistensFactory.GetLagerDB();
        }

        public Lager SøgId(int ProduktId)
        {
            return LagerDB.SøgId(ProduktId);
        }
        public List<Lager> HentLager()
        {
            return LagerDB.HentLager();
        }
        public string TilføjLager(Lager L)
        {
            return LagerDB.TilføjLager(L);
        }
    }
}
