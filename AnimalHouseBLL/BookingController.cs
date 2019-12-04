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

        public List<Booking> bookings = new List<Booking>();

        public BookingController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            BookingDB = persistensFactory.GetBookingDB();

        }

        public bool OpretBooking(Booking k)
        {
            return BookingDB.OpretBooking(k);
        }


        public void HentBookingByKundeId(int id)
        {

            bookings =BookingDB.HentBookingByKunde(id);
        }

        public void HentBookingByKunde(int Kundeid)
        {

            bookings = BookingDB.HentBookingByKunde(Kundeid);
        } 

        public void HentAlleBooking()
        {

            bookings = BookingDB.HentAlleBooking();
        }

        public bool SletBooking(int id)
        {
            return BookingDB.SletBooking(id);
        }

        public bool UpdateBooking(Booking b)
        {
            return BookingDB.UpdaterBooking(b);
        }





    }
}
