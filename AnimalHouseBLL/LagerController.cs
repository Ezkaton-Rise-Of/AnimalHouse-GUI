using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseBLL;
using AnimalHouseDB;

namespace AnimalHouseBLL
{
    public class LagerController
    {
        ILagerDB LagerDB;
        public List<Lager> L;

        public LagerController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            LagerDB = persistensFactory.GetLagerDB();
        }

        public List<Lager> HentLagerVareNavn(string varenavn)
        {
            return LagerDB.HentLagerVareNavn(varenavn);
        }

        public Lager HentLagerVareNummer(string varenummer)
        {
            return LagerDB.HentLagerVareNummer(varenummer);
        }

        public Lager SøgId(int id)
        {
            return LagerDB.SøgId(id);
        }

        public List<Lager> HentLager()
        {
            return LagerDB.HentLager();
        }

        public List<Lager> HentLagerNavnEllerVareNummer(string input)
        {
            return LagerDB.HentLagerNavnEllerVareNummer(input);
        }
    }
}
