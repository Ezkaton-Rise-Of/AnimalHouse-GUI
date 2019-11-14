using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Kunde
    {
        // attributes 
        public string Fnavn;
        public string Lnavn;
        public string Adresse;
        public string Postnummer;
        public string Tlf;
        public string Kundetype;
        public string By;
        public DateTime Oprettet;

        // Class Constructor
        public Kunde(string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, DateTime oprettet)
        {
            Fnavn = fnavn;
            Lnavn = lnavn;
            Adresse = adresse;
            Postnummer = postnummer;
            Tlf = tlf;
            Kundetype = kundetype;
            By = by;
            Oprettet = oprettet;
        }
    }
}
