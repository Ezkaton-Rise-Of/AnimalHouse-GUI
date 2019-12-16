using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Service :Produkt
    {
        public Servicetype Servicetype { get; set; }

        public Service()
        {
        }

        public Service(Servicetype servicetype)
        {
            Servicetype = servicetype;
        }

        public Service(int produktId, string beskrivelse, double pris, bool service, int kategoriId, string navn) : base(produktId, beskrivelse, pris, service, kategoriId, navn)
        {
        }

        public Service(int produktId, string beskrivelse, double pris, Kategori kategori, bool service, int kategoriId, string navn) : base(produktId, beskrivelse, pris, kategori, service, kategoriId, navn)
        {
        }
    }
}
