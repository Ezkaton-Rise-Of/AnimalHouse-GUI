using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using System_Entities;
using AnimalHouseDB;
using AnimalHouseBLL;
using System.Data;

namespace AnimalHouseBLL
{
    public class MainController
    {

        public List<Dyr> D = new List<Dyr>();
        public List<Kunde> K = new List<Kunde>();
        public List<Lager> L = new List<Lager>();
        public List<Booking> B = new List<Booking>();
        public List<Bur> Bur = new List<Bur>();
        public List<Service> S = new List<Service>();
        KundeController Kc;
        DyrController Dc;
        AnsatController Ac;
        BookingController Bc;
        LagerController Lc;
        JournalController Jc;
        BurController BurC;
        ServiceController ServiceC;
        ProductController Pc;
        public MainController()
        {
            Kc = new KundeController();
            Dc = new DyrController();
            Ac = new AnsatController();
            Bc = new BookingController();
            Lc = new LagerController();
            Jc = new JournalController();
            BurC = new BurController();
            ServiceC = new ServiceController();
            Pc = new ProductController();
        }

        public string OpretKunde(string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, string email)
        {

            Kunde k = new Kunde(fnavn, lnavn, adresse, postnummer, tlf, kundetype, by, email);
            return Kc.OpretKunde(k);
        }

        public bool Opretbooking(string notat, BookingTime startTid, BookingTime slutTid, Ansat ansat, Service service, Dyr dyr, DateTime startDate, DateTime SlutDato)
        {
            Booking k = new Booking();
            k.AnsatId = ansat.Id;
            k.startTid = startTid;
            k.service = service;
            k.Notat = notat;
            k.slutTid = slutTid;
            k.DyrId = dyr.DyrId;
            k.StartDato = startDate;
            k.SlutDato = SlutDato;
            return Bc.InsertBooking(k);
        }

        public int HentAnsatId(string navn)
        {
            return Ac.HentAnsatId(navn);
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

        public DataSet Test2(int days)
        {
            return Jc.Test2(days);
        }

        public List<Kunde> HentAlleKunde()
        {
            return Kc.HentAlleKunde();
        }
        public string SletEjer(int id)
        {
            return Kc.SletKunde(id);
        }
        public string OpretDyr(int kundeId, string art, string race, int alder, char sex, string behandler)
        {
            return Dc.OpretDyr(kundeId, art, race, alder, sex, behandler);
        }

        public List<BookingTime> HentAlleFritider(Ansat ansat, DateTime datetime)
        {
            return Bc.HentAlleFritider(ansat, datetime);
        }

        public List<BookingTime> HentAlleHentMuligeSlutTider(Ansat ansat, BookingTime dateTime, DateTime date)
        {
            return Bc.HentAlleHentMuligeSlutTider(ansat, dateTime, date);
        }

        

        public List<Service> HentAlleService(Servicetype servicetype)
        {
            return ServiceC.HentAlleService(servicetype);
        }

        public List<Dyr> HentAlleDyr()
        {
            return Dc.HentAlleDyr();
        }

        public string SletAnsat(int id)
        {
            Ansat a = HentAnsat(id);
            return Ac.SletAnsat(a);
        }

        public List<Servicetype> HentAlleServiceType()
        {
            return ServiceC.HentAlleServiceType();
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

        public bool TilknytBehandler(int dyrId, string behandler)
        {
            try
            {
                Dc.TilknytBehandler(dyrId, behandler);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
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

        public List<Kunde> HentKundeByTlforNavn(string input)
        {
              return Kc.HentKundeByTlforNavn(input);
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


        public int HentKundeId(string tlf)
        {
            return Kc.HentKundeId(tlf);
        }

        public Ansat HentAnsat(int id)
        {
            return Ac.HentAnsat(id);
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

        public bool SletBooking(Booking b)
        {
            return Bc.SletBooking(b);
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

        public bool OpretbookingBur(string text, Dyr dyr, DateTime value1, DateTime value2, Bur dataBoundItem)
        {
            return Bc.OpretbookingBur(text, dyr, value1, value2, dataBoundItem);
        }

        public void BookingHentFriBur(DateTime start, DateTime slut)
        {

            Bur = BurC.BookingHentFriBur(start, slut);
        }



        public string HentAnsatNavn(int id)
        {
            return Ac.HentAnsatNavn(id);
        }
        public List<Ansat> HentAlleBehandler()
        {
            return Ac.HentAlleBehandler();
        }
        public List<Ansat> HentAlleAnsate()
        {
            return Ac.HentAlleAnsatte();
        }
        public List<Ansat> HentAnsatByNavn2(string navn)
        {
            return Ac.HentAnsatByNanv2(navn);
        }
        public DataSet Test()
        {
            return Jc.Test();
        }

        // Salg system Funktioner
        public string GemFaktura()
        {
            throw new NotImplementedException();
        }

        public List<Kategori> HentAlleKategorier()
        {
            return Pc.Hentkategorier();
        }

        public List<Booking> HentAlleBooking(Kunde k)
        {
            return Bc.HentAlleBooking(k);
        }
    }
}
