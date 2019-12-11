using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Service :Produkt
    {
        public string ServiceType;

        public Service()
        {
        }

        public Service(int produktId, string beskrivelse, double pris, int kategoriId) : base(produktId, beskrivelse, pris, kategoriId)
        {
        }
    }
}
