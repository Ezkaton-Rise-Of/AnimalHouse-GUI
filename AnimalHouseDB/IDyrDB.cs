using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
namespace AnimalHouseDB
{
    public interface IDyrDB
    {
            string OpretDyr(Dyr d);
            string UpdaterDyr(Dyr d);
            string SletDyr(int Id);
            Dyr HentDyr(int Id);
            List<Dyr> HentDyrByKundeId(int KId);
            List<Dyr> HentAlleDyr();
            void TilknytBehandler(int dyrId, string behandler);
    }
}
