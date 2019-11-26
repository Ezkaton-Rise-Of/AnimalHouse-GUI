using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;

namespace AnimalHouseDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde(4, "Red", "def", "adresse", "6000", "4567890", "Erhverv", "Kolding", "Red@test.dk");
            AnimalhouseKundeDatabase db = new AnimalhouseKundeDatabase();
            Console.WriteLine(db.UpdateKunde(k));
            Console.ReadLine();
        }
    }
}
