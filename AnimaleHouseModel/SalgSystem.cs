using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Entities;

namespace AnimaleHouseModel
{
    public class SalgSystem
    {
        Salg s = new Salg();
        decimal total;
        public SalgSystem()
        {
            s = new Salg();
        }

        public void TilføjeItemLine(Produkt p, int antal)
        {
            s.TilføjeItemLine(p,antal);
        }
        public decimal BeregneTotal()
        {
            return s.BeregneTotal();
        }
        public decimal BeregneTilbud(decimal procent)
        {
            return  BeregneTotal() - ((BeregneTotal()*procent)/100);
        }

        public decimal HentTotal(decimal rabat)
        {
            BeregneTotal();
            total = Math.Round(BeregneTilbud(rabat), 2,MidpointRounding.ToEven);
            return total;
        }
    }
}
