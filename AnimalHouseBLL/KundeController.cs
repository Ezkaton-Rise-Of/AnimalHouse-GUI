using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;
namespace AnimalHouseBLL
{
    public class KundeController
    {
        IKundeDB KundeDB;

        public KundeController()
        {
            KundePersistensFactory persistensFactory = KundePersistensFactory.GetInstance();
            KundeDB = persistensFactory.GetKundeDB();
        }

        public string OpretKunde(string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, DateTime oprettet, string email)
        {
            Kunde k = new Kunde(fnavn, lnavn, adresse, postnummer, tlf, kundetype, by, oprettet, email);
            return KundeDB.OpretKunde(k);

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

        public String UpdateKunde(string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, DateTime oprettet, string e_mail)
        {
            Kunde k = new Kunde( fnavn, lnavn, adresse, postnummer, tlf,kundetype, by, oprettet,e_mail);
            return KundeDB.UpdateKunde(k);
        }
    }
}
