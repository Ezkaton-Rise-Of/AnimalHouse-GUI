using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseDB;
using AnimalHouse_Entities;

namespace AnimalHouseBLL
{
    class PersistensFactory
    {
        private static PersistensFactory _instance = null;
        public PersistensFactory() { }
        public static PersistensFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PersistensFactory();
                return _instance;
            }
            else return _instance;
        }
        
            public IDyrDB GetDyrDB()
            {
                return new AnimalhouseDyrDatabase();
            } 

            public IKundeDB GetKundeDB()
            {
                return new AnimalhouseKundeDatabase();
            }


    }
}
