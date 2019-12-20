//holger
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
        public double Pris { get; set; }
        public Kategori kategori { get; set; }
        public bool Service{get; set;}
        public int KategoriId { get; set; }
        public string Navn { get; set; }
        public int varenummer;
        public Supplier Supplier;
       
        public Produkt()
        {

        }



        public Produkt(int produktId, string beskrivelse, double pris, Kategori kategori, bool service, int kategoriId, string navn)
        {
            ProduktId = produktId;
            Beskrivelse = beskrivelse;
            Pris = pris;
            this.kategori = kategori;
            Service = service;
            KategoriId = kategoriId;
            Navn = navn;
        }

        public Produkt(int produktId, string beskrivelse, double pris, bool service, int kategoriId, string navn)
        {
            ProduktId = produktId;
            Beskrivelse = beskrivelse;
            Pris = pris;
            Service = service;
            KategoriId = kategoriId;
            Navn = navn;
        }
        //radwan
        public string HentInfo
        {
            get 
            {
                return $"{Navn}  Pris {Pris}Kr.";
            }
        }
        //kenneth 
        public string HentInfo1
        {
            get
            {
                return $"{ProduktId}";
            }
        }
    }
}
