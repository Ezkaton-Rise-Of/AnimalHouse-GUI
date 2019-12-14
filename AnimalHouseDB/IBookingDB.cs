﻿using System;
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
        bool SletBooking(Booking b);
        Booking HentBooking(int Id);
        List<Booking> HentBookingByKunde(int KundeId);
        List<Booking> HentAlleBooking(Kunde k);
        List<BookingTime> HentAlleFritider(Ansat ansat, DateTime dateTime);
        List<BookingTime> HentAlleHentMuligeSlutTider(Ansat ansat, BookingTime startTid, DateTime dateTime);
        bool OpretbookingBur(string text, Dyr dyr, DateTime start, DateTime slut, Bur bur);
    }
}
