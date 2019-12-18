using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class BookingService: Booking_1
    {
        public int AnsatId;
        public BookingTime startTid;
        public BookingTime slutTid;
        public BookingService()
        {
        }

        public new string navn
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
