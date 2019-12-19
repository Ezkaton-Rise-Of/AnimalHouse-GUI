using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;

namespace System_Entities
{
    public class Salg
    {
        public List<SalgItemLine> salgitems = new List<SalgItemLine>();
        public decimal amount;

        public Salg()
        {
            
        }

        public void TilføjeItemLine(Produkt p, int antal)
        {
            salgitems.Add(new SalgItemLine(p, antal));
        }

        public decimal BeregneTotal()
        {
            decimal dblTotal = 0;
            foreach (SalgItemLine lineItem in salgitems)
            {
                dblTotal += lineItem.BeregneSubTotal();
            }
            return dblTotal;
        }
    }
}
