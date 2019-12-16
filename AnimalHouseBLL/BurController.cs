using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;
namespace AnimalHouseBLL
{
    public class BurController
    {
        IBookingBurDB BurDB;
        public BurController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            BurDB = persistensFactory.GetBurDB();
        }


        public List<Bur> BookingHentFriBur(DateTime start, DateTime slut)
        {
            return BurDB.HentFribure(start, slut);
        }
    }
}
