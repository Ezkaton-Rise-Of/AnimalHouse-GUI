using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
namespace AnimalHouseDB
{
    public interface IBookingDB
    {
        bool OpretBooking(Booking b);
        bool UpdaterBooking(Booking b);
        bool SletBooking(int id);
        Booking HentBooking(int Id);
        List<Booking> HentBookingByKunde(int KundeId);
        List<Booking> HentAlleBooking();
    }
}
