using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Booking
    {

        public int BookingId;
        public int DyrId;
        public int AnsatId;
        public string Notat;
        public DateTime StartDato;
        public DateTime SlutDato;
        public Service service;
        public Bur bur;

        public Booking()
        {
            
        }


    }
}
