using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseDB;
using System_Entities;

namespace AnimalHouseBLL
{
    public class SalgController
    {
        ISalg salgDB;
        public SalgController()
        {
            PersistensFactory factory = PersistensFactory.GetInstance();
            salgDB = factory.GetSalgDB();
        }
        public List<Faktura> HentKundesFaktura(int kundeId)
        {
            return salgDB.HentKundesFaktura(kundeId);
        }

        public List<Faktura> HentAlleFaktura()
        {
            return salgDB.HentAlleFaktura();
        }
        public string GemFaktura(Faktura f)
        {
            return salgDB.GemFaktura(f);
        }
    }
}
