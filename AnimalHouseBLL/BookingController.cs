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


        public List<Booking> HentBookingByKundeId(int id)
        {

            return BookingDB.HentBookingByKunde(id);
        }

        public List<Booking> HentBookingByKunde(int Kundeid)
        {

            return BookingDB.HentBookingByKunde(Kundeid);
        } 

        public List<Booking> HentAlleBooking()
        {

            return BookingDB.HentAlleBooking();
        }

        public List<BookingTime> HentAlleFritider(Ansat ansat, DateTime dateTime)
        {
            return BookingDB.HentAlleFritider(ansat, dateTime);
        }

        public List<BookingTime> HentAlleHentMuligeSlutTider(Ansat ansat, int dateTime)
        {
            return BookingDB.HentAlleHentMuligeSlutTider(ansat, dateTime);
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
