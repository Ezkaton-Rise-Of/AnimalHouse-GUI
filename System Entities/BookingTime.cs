//holger
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class BookingTime
    {
        public int timeId { get; set; }
        public string time { get; set; }

        public BookingTime(int timeId, string time)
        {
            this.timeId = timeId;
            this.time = time;
        }

        public BookingTime()
        {
        }
    }
}
