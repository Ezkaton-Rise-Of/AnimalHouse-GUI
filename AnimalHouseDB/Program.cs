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
            Kunde k = new Kunde("Rick","Smith","Pakhustorvet22","6000","4343435","Private","Kolding",DateTime.Now);
            String t =AnimalhouseKundeDatabase.GetInstance().OpretKunde(k);
            Console.WriteLine(t);
            Console.ReadKey();
            
        }
    }
}
