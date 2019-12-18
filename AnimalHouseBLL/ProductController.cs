using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;

namespace AnimalHouseBLL
{
    public class ProductController: IProdukt
    {
        IProduktDB produktDB;

        public ProductController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            produktDB = persistensFactory.GetProduktDB();
        }

        public List<Kategori> Hentkategorier()
        {
            return produktDB.HentAlleKategorier();
        }
        public List<Produkt> HentAlleProduktByKategori(Kategori k)
        {
            return produktDB.HentAlleProduktByKategori(k);
        }

        public List<Produkt> HentAlleProdukter()
        {
            return produktDB.HentAlleProdukter();
        }

        public Produkt HentAlleProdukt(int id)
        {
            return produktDB.HentProdukt(id);
        }

        private Produkt ExtractProdukt(string inputProdukt)
        {
            Char delimiter = '#';
            String[] substrings = inputProdukt.Split(delimiter);
            Produkt produkt = new Produkt();
            produkt.Supplier = new Supplier();
            produkt.Supplier.SupplierNavn = substrings[0];
            produkt.varenummer = Convert.ToInt32(substrings[1]);
            produkt.Navn = substrings[2];
            produkt.Pris = Convert.ToInt32(substrings[3]);
            produkt.Beskrivelse = substrings[4];
            return produkt;
        }

        public bool ProduktFromExtern(List<string> Lines)
        {

            List<Produkt> produkts = new List<Produkt>();
            foreach  (string line in Lines)
            {
                produkts.Add(ExtractProdukt(line));
            }
            return produktDB.ProduktFromExtern(produkts);
        }
    }
}
