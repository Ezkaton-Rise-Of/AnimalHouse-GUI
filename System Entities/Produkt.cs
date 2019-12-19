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
        public Kategori kategori { get; set; }
        public bool Service{get; set;}
        public int KategoriId { get; set; }
        public string Navn { get; set; }
       
        public Produkt()
        {

        }

        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }
        public Produkt(int produktId, string beskrivelse, decimal pris, Kategori kategori, bool service, int kategoriId, string navn)
        {
            ProduktId = produktId;
            Beskrivelse = beskrivelse;
            Pris = pris;
            this.kategori = kategori;
            Service = service;
            KategoriId = kategoriId;
            Navn = navn;
        }

        public Produkt(int produktId, string beskrivelse, decimal pris, bool service, int kategoriId, string navn)
        {
            ProduktId = produktId;
            Beskrivelse = beskrivelse;
            Pris = pris;
            Service = service;
            KategoriId = kategoriId;
            Navn = navn;
        }

        public string HentInfo
        {
            get 
            {
                return $"{Navn}  Pris {Pris}Kr.";
            }
        }

        public string HentProdId
        {
            get
            {
                return $"{ProduktId}";
            }
        }
    }
}
