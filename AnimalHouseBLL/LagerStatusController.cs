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
    public class LagerStatusController
    {
        ILagerStatusDB LagerStatusDB;
        public List<LagerStatus> L;

        public LagerStatusController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            LagerStatusDB = persistensFactory.GetLagerStatusDB();
        }

       // public string HentLagerVareByNavn(LagerStatus L)
        //{
        //    return LagerStatusDB.HentLagerByVareNavn(L);
        //}

        public List<LagerStatus> HentLagerVareByNavn(string varenavn)
        {
            return LagerStatusDB.HentLagerVareByNavn(varenavn);
        }

        public LagerStatus HentLagerByVarenummer(string varenummer)
        {
            return LagerStatusDB.HentLagerByVarenummer(varenummer);
        }

        public LagerStatus SøgStatusById (int id)
        {
            return LagerStatusDB.SøgStatusById(id);
        }

        public List<LagerStatus> HentLagerStatuses()
        {
            return LagerStatusDB.HentLagerStatuses();
        }

        public List<LagerStatus> HentLagerByNavnEllerVarenummer(string input)
        {
            return LagerStatusDB.HentLagerByNavnEllerVarenummer(input);
        }

    }
}

