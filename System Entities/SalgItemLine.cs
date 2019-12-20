// Radwan
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
        public double amount;
        public Produkt p;

        public SalgItemLine(Produkt p, double amount)
        {
            this.amount = amount;
            this.p = p;
        }

        public double BeregneSubTotal()
        {
            return p.Pris * amount;
        }
    }
}
