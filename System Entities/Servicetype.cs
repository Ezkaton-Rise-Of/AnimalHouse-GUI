// holger
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Servicetype
    {
        public Servicetype()
        {
        }

        public Servicetype(string serviceType, int serviceTypeId)
        {
            ServiceType = serviceType;
            ServiceTypeId = serviceTypeId;
        }

        public string ServiceType { get; set; }
        public int ServiceTypeId { get; set; }

      

    }
}
