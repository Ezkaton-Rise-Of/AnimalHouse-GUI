using System;

namespace AnimalHouse_Entities
{
    public interface IBookingBur
    {
        DateTime SlutDato { get; set; }
        string SlutTid { get; }
        string StartTid { get; }
    }
}