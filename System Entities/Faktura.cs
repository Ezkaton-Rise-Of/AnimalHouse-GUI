// Radwan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Entities
{
    public class Faktura
    {
        public int FakturaId { get; set; }
        public int KundeId { get; set; }
        public string Total { get; set; }
        public string Rabat { get; set; }
        public DateTime Dato { get; set; }
        public string Produkter { get; set; }

        public Faktura() { }
        public Faktura(int kundeId, string total, string rabat, string produkter) 
        {
            KundeId = kundeId;
            Total = total;
            Rabat = rabat;
            Produkter = produkter;
        }

        public Faktura(int fakturaId, int kundeId, DateTime dato, string total, string rabat)
        {
            this.FakturaId = fakturaId;
            this.KundeId = kundeId;
            this.Dato = dato;
            this.Total = total;
            this.Rabat = rabat;
        }
    }
}
