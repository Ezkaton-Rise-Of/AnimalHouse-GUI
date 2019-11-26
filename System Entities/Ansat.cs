using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Entities
{
    public class Ansat
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int Ansattype { get; set; }
        public Ansat() { }
        public Ansat(int id, string navn, int ansattype)
        {
            this.Id = id;
            this.Navn = navn;
            this.Ansattype = ansattype;
        }
        public Ansat(string navn ,int ansattype)
        {
            this.Navn = navn;
            this.Ansattype = ansattype;
        }
    }
}
