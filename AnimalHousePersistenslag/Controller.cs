using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entites;
using AnimalHouse_Entities;
using AnimalHouseDB;
namespace AnimalHouseBLL
{
    public class Controller
    {

        IDyrDB Idyr;
        IKundeDB IKunde;

        public Controller()
        {
            PersistensFactory persistensFactory = new PersistensFactory();
            //?
        }

        public string CreateKunde(Kunde k)
        {
            return IKunde.OpretKunde(k);
        }

        public string CreateDyr(Dyr d)
        {
            return Idyr.OpretDyr(d);
        }
    }
}
