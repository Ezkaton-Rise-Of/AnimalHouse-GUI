using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public abstract class Booking_new
    {
        public int BookingId { get; set; }
        public string Notat;
        public DateTime StartDato { get; set; }
        public Dyr Dyr;
        public Service service;
        public Booking_new()
        {  
        }
        public string navn
        {
            get
            {
                return service.Navn;
            }
        }
    }
}
