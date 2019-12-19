using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseBLL;
using AnimalHouseDB;

namespace AnimalHousePersistenslag
{
    public class LagerController
    {
        ILagerDB LagerDB;
        public LagerController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            LagerDB = persistensFactory.GetLagerDB();
        }
        public Lager SøgId(int id)
        {
            return LagerDB.SøgId(id);
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
