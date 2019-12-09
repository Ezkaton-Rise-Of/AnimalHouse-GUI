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
        public double Pris;
        public int KategoriId;
        public Service Service;
        public Produkt()
        {

        }

        public Produkt(int produktId, string beskrivelse, double pris, int kategoriId)
        {
            ProduktId = produktId;
            Beskrivelse = beskrivelse;
            Pris = pris;
            KategoriId = kategoriId;
        }

        public Produkt(int produktId, string beskrivelse, double pris, int kategoriId, Service service) : this(produktId, beskrivelse, pris, kategoriId)
        {
            Service = service;
        }
    }
}
