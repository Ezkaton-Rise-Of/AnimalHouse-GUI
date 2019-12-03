using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;

namespace AnimalHouseDB
{
    public interface ILagerStatusDB
    {
        LagerStatus SøgStatusById (int id);
        //string HentLagerByVareNavn(LagerStatus L);
        LagerStatus HentLagerByVarenummer(string varenummer);
        List<LagerStatus> HentLagerStatuses();
        List<LagerStatus> HentLagerByNavnEllerVarenummer(string input);
        List<LagerStatus> HentLagerVareByNavn(string varenavn);
    }
}
