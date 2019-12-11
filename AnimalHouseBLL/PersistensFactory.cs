using AnimalHouseDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseBLL
{
    public class PersistensFactory
    {
        private static PersistensFactory _instance = null;
        private PersistensFactory() { }
        public static PersistensFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PersistensFactory();
                return _instance;
            }
            else return _instance;
        }

        public IBookingBurDB GetBurDB()
        {
            return new AnimalHouseBurDatabase();
        }

        public IKundeDB GetKundeDB()
        {
            return new AnimalhouseKundeDatabase();
        }

        public IDyrDB GetDyrDB()
        {
            return new AnimalhouseDyrDatabase();
        }

        public IBookingDB GetBookingDB()
        {
            return new AnimalhouseBookingDB();
        }

        public IAnsatDB GetAnsatDB()
        {
            return new AnimalHouseAnsatDataBase();
        }

        public IEmail GetEmailDB()
        {
            return new AnimalHouseEmailDB();
        }

        public ILagerDB GetLagerDB()
        {
            return new AnimalHouseLagerDatabase();
        }

        public IJournal GetJournalDB()
        {
            return new AnimalHouseJournalDataBase();
        }

        public IServiceDB GetServiceDB()
        {
            return new AnimalhouseServiceDatabase();
        }

    }
}
