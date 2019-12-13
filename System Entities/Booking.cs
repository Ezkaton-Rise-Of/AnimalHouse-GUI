using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Booking
    {

        public int BookingId { get; set; }
        public int DyrId { get; set; }
        public int AnsatId { get; set; }
        public string Notat { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }
        public Service service { get; set; }
        public Bur bur { get; set; }
        public BookingTime startTid {get; set;}
        public BookingTime slutTid { get; set; }
        
        public Booking()
        {
            
        }


    }
}
