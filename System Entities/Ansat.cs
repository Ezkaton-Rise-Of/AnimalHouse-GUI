using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Ansat
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Stelling { get; set; }
        public string Tlf { get; set; }
        public Ansat() { }
        public Ansat(int id, string navn, string stelling, string tlf)
        {
            this.Id = id;
            this.Navn = navn;
            this.Stelling = stelling;
            this.Tlf = tlf;
        }
        public Ansat(string navn ,string stelling, string tlf)
        {
            this.Navn = navn;
            this.Stelling = stelling;
            this.Tlf = tlf;
        }

        public string GetName
        {
            get
            {
                return $"{Navn}";
            }
        }
    }
}
