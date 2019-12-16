using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Produkt
    {
        public int ProduktId { get; set; }
        public string Beskrivelse { get; set; }
        public decimal Pris { get; set; }
        public int KategoriId { get; set; }
        public Service Service { get; set; }
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

        public string HentInfo
        {
            get
            {
                return $"{ProduktId}";
            }
        }
    }
}
