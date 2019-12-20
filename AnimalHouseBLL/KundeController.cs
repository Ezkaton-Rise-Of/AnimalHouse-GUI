// Radwan
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;
using System_Entities;

namespace AnimalHouseBLL
{
    public class KundeController
    {
        IKundeDB KundeDB;

        public KundeController()
        {
            PersistensFactory persistensFactory = PersistensFactory.GetInstance();
            KundeDB = persistensFactory.GetKundeDB();
        }

        public string OpretKunde(string fnavn,string lnavn,string adresse,string postnummer,string tlf,string kundetype,string by,string email)
        {
            Kunde k = new Kunde(fnavn, lnavn, adresse, postnummer, tlf, kundetype, by, email);
            return KundeDB.OpretKunde(k);
        }

        public int HentKundeId(string tlf)
        {
            return KundeDB.HentKundeId(tlf);
        }
        public Kunde SøgeKundeById(int id)
        {
            return KundeDB.HentKundeById(id);
        }



        public List<Kunde> HentAlleKunde()
        {
            return KundeDB.HentAlleKunder();
        }

        public string SletKunde(int id)
        {
            return KundeDB.SletKunde(id);
        }

        public String UpdateKunde(int id, string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, string e_mail)
        {
            Kunde k = new Kunde(id, fnavn, lnavn, adresse, postnummer, tlf, kundetype, by, e_mail);
            return KundeDB.UpdateKunde(k);
        }

        public Kunde HentKundetByTlf(string tlf)
        {
            return KundeDB.HentKundeByTlf(tlf);
        }

        public string HentByNavn(string postnr)
        {
            return KundeDB.HentByNavn(postnr);
        }
        public List<Kunde> HentKundeByTlforNavn(string input)
        {
            return KundeDB.HentKunderByTlfOrNavn(input);
        }
    }
}
