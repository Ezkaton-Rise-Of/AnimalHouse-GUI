using AnimalHouseDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseBLL
{
    public class KundePersistensFactory
    {
        private static KundePersistensFactory _instance = null;
        private KundePersistensFactory() { }
        public static KundePersistensFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new KundePersistensFactory();
                return _instance;
            }
            else return _instance;
        }

        public IKundeDB GetKundeDB()
        {
            return new AnimalhouseKundeDatabase();
        }
    }
}
