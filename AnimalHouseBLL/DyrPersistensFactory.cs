using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseDB;
using AnimalHouse_Entities;

namespace AnimalHouseBLL
{
    public class DyrPersistensFactory
    {
        private static DyrPersistensFactory _instance = null;
        private DyrPersistensFactory() { }
        public static DyrPersistensFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DyrPersistensFactory();
                return _instance;
            }
            else return _instance;
        }
        
            public IDyrDB GetDyrDB()
            {
                return new AnimalhouseDyrDatabase();
            } 




    }
}
