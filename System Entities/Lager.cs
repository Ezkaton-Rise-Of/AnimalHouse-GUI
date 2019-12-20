using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Kenneth A. Kun
namespace AnimalHouse_Entities
{
    public class Lager
    {
        public double Pris { get; set; }
        public int Antal { get; set; }
        public int ProduktId { get; set; }
        public bool Service { get; set; }

        public List<Lager> LagerList;

        public Lager()
        {

        }

        public Lager(double pris, int antal, int produktid)
        {

            Pris = pris;
            Antal = antal;
            ProduktId = produktid;

        }



    }
}
