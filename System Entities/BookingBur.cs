using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class BookingBur:Booking_1
    {
        public DateTime SlutDato { get; set; }
        public Bur bur;
        public BookingTime startTid;
        public BookingTime slutTid;
        
        public BookingBur()
        {
            
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
