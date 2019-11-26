using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;
namespace AnimalHouseBLL
{
    public class BookingController
    {
        IBookingDB BookingDB;

        List<Booking> bookings = new List<Booking>();

        public BookingController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
        }

        public string OpretBooking(Booking k)
        {
            return BookingDB.OpretBooking(k);
        }

        public void 

        public void HentBookingByKundeId(int id)
        {

            bookings =BookingDB.HentBookingByKunde(id);
        }

        public void HentBookingByKunde(int Kundeid)
        {
            bookings = null;
            bookings = new List<Booking>();
            bookings = add(BookingDB.HentBookingByKunde(kundeid));
        } 

        public void HentAlleBooking()
        {

            bookings = BookingDB.HentAlleBooking();
        }

        public string SletKunde(int id)
        {
            return BookingDB.SletBooking(id);
        }

        public String UpdateKunde(Booking b)
        {
            return BookingDB.UpdateBooking(b);
        }





    }
}
