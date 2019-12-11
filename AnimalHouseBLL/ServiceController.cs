using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseDB;
using AnimalHouse_Entities;
namespace AnimalHouseBLL
{
    class ServiceController
    {
        IServiceDB ServiceDB;


        public ServiceController()
        {
            //A = ansatDB.HentAlleAnsate();
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            ServiceDB = persistensFactory.GetServiceDB();

        }

        public List<Service> HentAlleService()
        {
            return ServiceDB.HentAlleService();
        } 


    }
}
