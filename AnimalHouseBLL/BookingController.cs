//Holger
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
        public List<Booking> HentAlleBooking(Kunde k)
        {

            return BookingDB.HentAlleBooking(k);
        }

        public List<BookingTime> HentAlleFritider(Ansat ansat, DateTime dateTime, Servicetype servicetype)
        {
            return BookingDB.HentAlleFritider(ansat, dateTime, servicetype);
        }

        public List<BookingTime> HentAlleHentMuligeSlutTider(Ansat ansat, BookingTime dateTime, DateTime dato, Servicetype servicetype)
        {
            return BookingDB.HentAlleHentMuligeSlutTider(ansat, dateTime, dato, servicetype);
        }

        public bool SletBooking(Booking b)
        {
            return BookingDB.SletBooking(b);
        }
        public bool UpdateBooking(Booking b)
        {
            return BookingDB.UpdaterBooking(b);
        }

        internal bool InsertBooking(Booking k)
        {

            return BookingDB.OpretBooking(k);
        }
        internal bool OpretbookingBur(string text, Dyr dyr, DateTime start, DateTime slut, Bur bur)
        {
            return BookingDB.OpretbookingBur(text, dyr, start, slut, bur);
        }
    }
}
