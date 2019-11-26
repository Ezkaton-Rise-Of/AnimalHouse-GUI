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
        public int Id { get; set; }
        public string Fnavn { get; set; }
        public string Lnavn { get; set; }
        public string Adresse { get; set; }
        public string  Postnummer { get; set; }
        public string  Tlf { get; set; }
        public string  Kundetype { get; set; }
        public string  By { get; set; }

        public DateTime Oprettet { get; set; }
        public string E_mail { get; set; }

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
