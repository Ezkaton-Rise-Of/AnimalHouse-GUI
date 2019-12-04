using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Journal
    {

        public int dyrId { get; set; }
        public int journalId { get; set; }
        public int behandlerId { get; set; }
        public string beskrivelse { get; set; }
        public DateTime dato { get; set; }

        public Journal() { }
        public Journal(int id, int bId, int dId, string bes, DateTime date)
        {
            this.journalId = id;
            this.behandlerId = bId;
            this.dyrId = dId;
            this.beskrivelse = bes;
            this.dato = date;
        }
        public Journal( int bId, int dId, string bes)
        {
            this.behandlerId = bId;
            this.dyrId = dId;
            this.beskrivelse = bes;
        }
    }
}
