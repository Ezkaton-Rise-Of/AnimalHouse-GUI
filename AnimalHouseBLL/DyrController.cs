using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entites;
using AnimalHouseDB;
namespace AnimalHouseBLL
{
    public class DyrController
    {
        IDyrDB DyrDB;
        public DyrController()
        {
            DyrPersistensFactory persistensFactory = DyrPersistensFactory.GetInstance();
            DyrDB = persistensFactory.GetDyrDB();
        }

        public string OpretDyr(int kundeId, string art, string race, int alder, char sex)
        {
            Dyr d = new Dyr(kundeId, art, race, alder, sex);
            return DyrDB.OpretDyr(d);
        }
    }
}
