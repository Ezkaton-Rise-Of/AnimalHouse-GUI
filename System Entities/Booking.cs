//Holger
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Booking
    {
        public string Notat;
        public int BookingId { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }
        public int DyrId;
        public int AnsatId;

        public Service service;
        public Bur bur;
        public BookingTime startTid;
        public BookingTime slutTid;
        
        public Booking()
        {
            
        }

        public string navn
        {
            get
            {
                return service.Navn;
            }
        }

        public string StartTid
        {
            get { return startTid.time; }
        }

        public string SlutTid
        {
            get { return slutTid.time; }
        }



    }
}
