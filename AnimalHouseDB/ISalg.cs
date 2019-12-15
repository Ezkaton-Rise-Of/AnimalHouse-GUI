using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Entities;

namespace AnimalHouseDB
{
    public interface ISalg
    {
        List<Faktura> HentKundesFaktura(int kundeId);
        List<Faktura> HentAlleFaktura();
    }
}
