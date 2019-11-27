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
        string OpretService(Service s);
        string SletService(int s);
        string UpdateService(Service s);
        Service HentService(int s);
        List<Service> HentAlleService();

    }
}
