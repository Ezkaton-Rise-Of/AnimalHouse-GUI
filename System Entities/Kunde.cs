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
        public int Id;
        public string Fnavn;
        public string Lnavn;
        public string Adresse;
        public string Postnummer;
        public string Tlf;
        public string Kundetype;
        public string By;
        public DateTime Oprettet;
        public string E_mail;

        // Class Constructors
        public Kunde() { }
        public Kunde(string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, string e_mail)
        {
            Fnavn = fnavn;
            Lnavn = lnavn;
            Adresse = adresse;
            Postnummer = postnummer;
            Tlf = tlf;
            Kundetype = kundetype;
            By = by;
            E_mail = e_mail;
        }
    }
}
