// Radwan + Holger
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
namespace AnimalHouseDB
{
    public interface IProduktDB
    {

        List<Kategori> HentAlleKategorier();
        Produkt HentProdukt(int Id);
        List<Produkt> HentAlleProdukter();
        List<Produkt> HentAlleProduktByKategori(Kategori k);
        bool UpdaterProdukt(Produkt p);
        bool ProduktFromExtern(List<Produkt> Lines);
    }
}
