using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Lager
    {

        public List<Lager> LagerList;
        public decimal Pris { get; set; }
        public int Antal { get; set; }
        public Produkt Produkt;

        public Lager()
        {
        }

        public Lager(decimal pris, int antal, Produkt produkt)
        {

            this.Pris = pris;
            this.Antal = antal;
            this.Produkt = produkt;
        }

        public int ProduktId
        {
            get { return Produkt.ProduktId; }
           
        
        }



    }
}
