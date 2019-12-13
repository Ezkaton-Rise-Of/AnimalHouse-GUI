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
        bool OpretService(Service s);
        bool SletService(int s);
        bool UpdateService(Service s);
        Service HentService(int s);
        List<Service> HentAlleService();
        List<Service> HentAlleServiceType();
    }
}
