using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Entities
{
    public class SalgItemLine
    {
        public decimal amount;
        public Produkt p;

        public SalgItemLine(Produkt p, decimal amount)
        {
            this.amount = amount;
            this.p = p;
        }

        public decimal BeregneSubTotal()
        {
            return p.Pris * amount;
        }
    }
}
