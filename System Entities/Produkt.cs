using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Produkt
    {
        public int ProduktId;
        public string Beskrivelse;
        public decimal Pris;
        public int KategoriId;
        public Service Service;
        public Produkt()
        {

        }

        public Produkt(int produktId, string beskrivelse, decimal pris, int kategoriId)
        {
            ProduktId = produktId;
            Beskrivelse = beskrivelse;
            Pris = pris;
            KategoriId = kategoriId;
        }

        public Produkt(int produktId, string beskrivelse, decimal pris, int kategoriId, Service service) : this(produktId, beskrivelse, pris, kategoriId)
        {
            Service = service;
        }
    }
}
