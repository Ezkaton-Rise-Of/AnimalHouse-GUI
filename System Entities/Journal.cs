// Radwan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Entities
{
    public class Journal
    {
        public int journalId { get; set; }
        public int behandlerId { get; set; }
        public int dyrId { get; set; }
        public string beskrivelse { get; set; }
        public DateTime dato { get; set; }

        public Journal() { }
        public Journal (int id, int behandlerid, int dyrid, string beskrivelse)
        {
            this.journalId = id;
            this.behandlerId = behandlerid;
            this.dyrId = dyrid;
            this.beskrivelse = beskrivelse;
        }

        public Journal(int behandlerid, int dyrid, string beskrivelse)
        {
            this.behandlerId = behandlerid;
            this.dyrId = dyrid;
            this.beskrivelse = beskrivelse;
        }
    }
}
