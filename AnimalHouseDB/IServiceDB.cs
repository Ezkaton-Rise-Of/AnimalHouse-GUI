using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
namespace AnimalHouseDB
{
    public interface IServiceDB
    {
        List<Service> HentAlleServiceByServiceType(Servicetype servicetype);
        List<Servicetype> HentAlleServiceType();
    }
}
