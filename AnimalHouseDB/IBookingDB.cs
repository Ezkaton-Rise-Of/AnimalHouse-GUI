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
        string OpretDBooking(Booking b);
        string UpdaterBooking(Booking b);
        string SletBooking(int id);
        Booking HentBooking(int Id);
        List<Booking> HentBookingByKunde(int Id);
        List<Booking> HentAlleBooking();
    }
}
