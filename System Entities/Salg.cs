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
        public Kunde k;
        public List<SalgItemLine> salgitems = new List<SalgItemLine>();
        public decimal amount;

        public Salg(Kunde k)
        {
            this.k = k;
        }

        public void AddItemToLine(Produkt p, int antal)
        {
            salgitems.Add(new SalgItemLine(p, antal));
        }

        public decimal GetTotal()
        {
            decimal dblTotal = 0;
            decimal dblSubTotal = 0;
            foreach (SalgItemLine lineItem in salgitems)
            {
                dblSubTotal = lineItem.GetSubTotal();
                dblTotal = dblTotal + dblSubTotal;
            }
            return dblTotal;
        }

        public decimal GetTotalDiscount()
        {
            return GetTotal()-((GetTotal() * k.GetDiscount())/100);
        }
    }
}
