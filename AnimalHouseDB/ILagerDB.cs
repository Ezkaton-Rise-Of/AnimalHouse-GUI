using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;

namespace AnimalHouseDB
{
    public interface ILagerDB
    {
            Lager SøgId(int id);
            //string HentLagerByVareNavn(LagerStatus L);
            Lager HentLagerVareNummer(string varenummer);
            List<Lager> HentLager();
            List<Lager> HentLagerNavnEllerVareNummer(string input);
            List<Lager> HentLagerVareNavn(string varenavn);
        }
}
