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
        public double amount;

        public Salg()
        {
            
        }

        public void AddItemToLine(Produkt p, int antal)
        {
            salgitems.Add(new SalgItemLine(p, antal));
        }

        public double GetTotal()
        {
            double dblTotal = 0;
            double dblSubTotal = 0;
            foreach (SalgItemLine lineItem in salgitems)
            {
                dblSubTotal = lineItem.GetSubTotal();
                dblTotal = dblTotal + dblSubTotal;
            }
            return dblTotal;
        }

        public double GetTotalDiscount()
        {
            return GetTotal()-((GetTotal() * 3)/100);
        }
    }
}
