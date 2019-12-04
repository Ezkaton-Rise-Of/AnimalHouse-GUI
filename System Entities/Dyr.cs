using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Dyr
    {
        // attributes
        public int DyrId { get; set; }
        public int KundeId { get; set; }
        public string Art { get; set; }
        public string Race { get; set; }
        public int  Alder { get; set; }
        public char Sex { get; set; }

        // Class Constructors
        public Dyr() { }
        public Dyr(int kundeid, string art, string race, int alder, char sex)
        {
            this.KundeId = kundeid;
            this.Art = art;
            this.Race = race;
            this.Alder = alder;
            this.Sex = sex;
        }

        public Dyr(int id, int kundeid, string art, string race, int alder, char sex)
        {
            this.DyrId = id;
            this.KundeId = kundeid;
            this.Art = art;
            this.Race = race;
            this.Alder = alder;
            this.Sex = sex;
        }
    }
}
