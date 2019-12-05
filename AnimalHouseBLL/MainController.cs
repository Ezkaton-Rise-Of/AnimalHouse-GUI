using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using System_Entities;
using AnimalHouseDB;
using AnimalHouseBLL;

namespace AnimalHouseBLL
{
    public class MainController
    {

        public List<Dyr> D = new List<Dyr>();
        public List<Kunde> K = new List<Kunde>();
        public List<Lager> L = new List<Lager>();

        KundeController Kc;
        DyrController Dc;
        AnsatController Ac;
        BookingController Bc;
        LagerController Lc;
        JournalController Jc;

        public MainController()
        {
            Kc = new KundeController();
            Dc = new DyrController();
            Ac = new AnsatController();
            Bc = new BookingController();
            Lc = new LagerController();
            Jc = new JournalController();
        }

        public string OpretKunde(string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, string email)
        {

            Kunde k = new Kunde(fnavn, lnavn, adresse, postnummer, tlf, kundetype, by, email);
            return Kc.OpretKunde(k);
        }

        public bool Opretbooking(string notat, DateTime startDato, DateTime slutDato, int serviceId, int dyrId, int ansatId)
        {
            Booking k = new Booking();
            k.AnsatId = ansatId;
            k.StartDato = slutDato;
            k.Notat = notat;
            k.SlutDato = slutDato;
            k.DyrId = dyrId;
            return Bc.OpretBooking(k);
        }

        public List<Ansat> HentAlleAnsate()
        {
            return Ac.HentAlleAnsatte();
        }
        public int HentAnsatId(string navn)
        {
            return Ac.HentAnsatId(navn);
        }
        public Ansat HentAnsateByNavn(string ansatNavn)
        {
            return Ac.HentAnsatteByNavn(ansatNavn);
        }

        public Kunde HentKundByTlf(string tlf)
        {
            return Kc.HentKundetByTlf(tlf);
        }

        public string HentBynavn(string postnr)
        {
            return Kc.HentByNavn(postnr);
        }

        public string OpretAnsat(string navn, string Stelling, string tlf)
        {
            Ansat a = new Ansat(navn, Stelling, tlf);
            return Ac.OpretAnsat(a);
        }

        public List<Kunde> HentAlleKunde()
        {
            return Kc.HentAlleKunde();
        }
        public string SletEjer(int id)
        {
            return Kc.SletKunde(id);
        }
        public string OpretDyr(int kundeId, string art, string race, int alder, char sex)
        {
            return Dc.OpretDyr(kundeId, art, race, alder, sex);
        }

        public List<Dyr> HentAlleDyr()
        {
            return Dc.HentAlleDyr();
        }

        public string SletAnsat(int id)
        {
            return Ac.SletAnsat(id);
        }
        public Ansat HentAnsatByNavn(string navn)
        {
            return Ac.HentAnsatByName(navn);
        }
        public List<Dyr> HentAlleKundesDyr(int kundeId)
        {

           return Dc.HentAlleKundesDyr(kundeId);
        }

        public Dyr HentDyr(int id)
        {
            return Dc.HentDyr(id);
        }

        public string SletDyr(int id)
        {
            return Dc.SletDyr(id);
        }

        public string UpdateDyr(int dyrId, int kundeId, string art, string race, int alder, char sex)
        {
            return Dc.UpdateDyr(dyrId, kundeId, art, race, alder, sex);
        }

        public string UpdateKunde(int id,string fnavn, string lnavn, string adress, string postnummer, string tlf, string kundetype, string by, string email)
        {
            return Kc.UpdateKunde(id,fnavn, lnavn, adress, postnummer, tlf, kundetype, by, email);
        }

        public string UpdateAnsat(int id, string navn, string stelling, string tlf)
        { 
            return Ac.UpdateAnsat(id, navn, stelling,tlf);
        }

        public void HentKundeByTlf(string tlf)
        {
             K.Add(Kc.HentKundetByTlf(tlf));
        }

        public void HentKundeByTlforNavn(string input)
        {
            K= Kc.HentKundeByTlforNavn(input);
        }

        public List<Lager> HentLagerVareNavn(string varenavn)
        {
            return Lc.HentLagerVareNavn(varenavn);
        }

        public Lager HentLagerVareNummer(string varenummer)
        {
            return Lc.HentLagerVareNummer(varenummer);
        }

        public Lager SøgId(int id)
        {
            return Lc.SøgId(id);
        }

        public List<Lager> HentLager()
        {
            return Lc.HentLager();
        }

        public List<Lager> HentLagerNavnEllerVareNummer(string input)
        {
            return Lc.HentLagerNavnEllerVareNummer(input);
        }

        public int HentKundeId(string navn)
        {
            return Kc.HentKundeId(navn);
        }

        public Ansat HentAnsatById(int id)
        {
            return Ac.HentAnsatById(id);
        }

        //Journal Funktioner
        public string Opretjournal(int ansatid, int dyrid, string beskrivelse)
        {
            return Jc.OpretJournal(ansatid, dyrid, beskrivelse);
        }

        public string SletJournal(int id)
        {
            return Jc.SletJournal(id);
        }

        public List<Journal> HentAlleJournale()
        {
            return Jc.HentAlleJournale();
        }

        public List<Journal> HentAlleDyrJournale(int dyrid)
        {
            return Jc.HentAlleDyrJournale(dyrid);
        }
        
        public List<Journal> HentAlleAnsateJournale(int ansatId)
        {
            return Jc.HentAlleAnsatJournal(ansatId);
        }

        public Journal HentJournal(int id)
        {
            return Jc.HentJournal(id);
        }
    }
}
