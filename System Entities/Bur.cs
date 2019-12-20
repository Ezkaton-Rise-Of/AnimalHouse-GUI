
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Bur
    {
        // attributes 
        public int Id { get; set; }
        public string Art { get; set; }
        public char Booket { get; set; }

        // Class Constructors
        public Bur() { }
        public Bur(string art, char booket)
        {
            Art = art;
            Booket = booket;
        }
    }
}
