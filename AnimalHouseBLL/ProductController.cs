using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;

namespace AnimalHouseBLL
{
    public class ProductController
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
    }
}
