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
        public int ammount;
        public Produkt p;

        public SalgItemLine(Produkt p, int ammount)
        {
            this.ammount = ammount;
            this.p = p;
        }

        public double GetSubTotal()
        {
            return  p.Pris* ammount;
        }
    }
}
