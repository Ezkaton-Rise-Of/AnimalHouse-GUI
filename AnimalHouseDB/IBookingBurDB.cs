using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;

namespace AnimalHouseDB
{
    public interface IBookingBurDB
    {
        string OpretBur (Bur b);
        string SletBur  (int id);
        string UpdateBur(Bur b);
        Bur HentBurByID(int id);
        List<Bur> HentAlleBure();

        //Holger
        List<Bur> HentFribure(DateTime startdato, DateTime slutdato);
    }   
}
