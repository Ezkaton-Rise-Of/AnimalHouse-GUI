using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Booking_1
    {
        public DateTime StartDato { get; set; }
        public int DyrId;
        public Service service;
        public Booking_1()
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
