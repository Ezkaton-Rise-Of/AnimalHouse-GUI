// Radwan
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
        public double amount;

        public Salg()
        {
            amount = 0;
        }

        public void TilføjeItemLine(Produkt p, int antal)
        {
            salgitems.Add(new SalgItemLine(p, antal));
        }

        public double BeregneTotal()
        {
            foreach (SalgItemLine lineItem in salgitems)
            {
                amount += lineItem.BeregneSubTotal();
            }
            return amount;
        }
    }
}
