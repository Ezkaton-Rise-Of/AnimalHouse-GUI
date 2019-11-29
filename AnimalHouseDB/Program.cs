﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouse_Entites;
namespace AnimalHouseDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kunde k = new Kunde(4, "Red", "def", "adresse", "6000", "4567890", "Erhverv", "Kolding", "Red@test.dk");
            //AnimalhouseKundeDatabase db = new AnimalhouseKundeDatabase();
            //Console.WriteLine(db.UpdateKunde(k));
            //Console.ReadLine();

            AnimalhouseDyrDatabase d = new AnimalhouseDyrDatabase();
            List<Dyr> hej = new List<Dyr>();
            hej = d.HentDyrByKundeId(5);
            for (int i = 0; i < hej.Count; i++)
            {
                Console.Write(hej[i].DyrId + " ");
                Console.Write(hej[i].KundeId + " ");
                Console.Write(hej[i].Art + " ");
                Console.Write(hej[i].Race + " ");
                Console.Write(hej[i].Alder + " ");
                Console.Write(hej[i].Sex + " ");
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
