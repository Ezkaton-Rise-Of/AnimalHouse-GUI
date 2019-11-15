using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entites
{
    public class Dyr
    {
        // attributes
        public int DyrId;
        public int KundeId;
        public string Art;
        public string Race;
        public int Alder;
        public char Sex;

        public Dyr() { }

        // Class Constructor
        public Dyr(int kundeid, string art, string race, int alder, char sex)
        {
            this.KundeId = kundeid;
            this.Art = art;
            this.Race = race;
            this.Alder = alder;
            this.Sex = sex;
        }
    }
}
