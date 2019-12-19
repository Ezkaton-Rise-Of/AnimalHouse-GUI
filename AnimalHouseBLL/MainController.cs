// Radwan + Holger + Kenneth
using AnimalHouse_Entities;
using AnimalHouseBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System_Entities;
using AnimalHouseDB;
using System.Data;


namespace AnimalHouseBLL
{
    public class MainController
    {
        // Lock object
        private static readonly object Instancelock = new object();
        // singelton instance
        private static MainController _instance = null;

        public List<Dyr> D = new List<Dyr>();
        public List<Kunde> K = new List<Kunde>();
        public List<Lager> L = new List<Lager>();
        public List<Booking> B = new List<Booking>();
        public List<Bur> Bur = new List<Bur>();
        public List<Service> S = new List<Service>();
        public List<Kategori> kategorier = new List<Kategori>();
        public List<Produkt> produkter = new List<Produkt>();

        KundeController Kc;
        DyrController Dc;
        AnsatController Ac;
        BookingController Bc;
        LagerController Lc;
        JournalController Jc;
        BurController BurC;
        ServiceController ServiceC;
        ProductController Pc;
        SalgController Sc;
        EmailController MailController;
        private MainController()
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
            Sc = new SalgController();
            MailController = new EmailController();
        }
        public static MainController GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (_instance == null)
                    {
                        _instance = new MainController();
                    }
                    return _instance;
                }
            }
        }
        // Create new customer - radwan
        public string OpretKunde(string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, string email)
        {
            return Kc.OpretKunde(fnavn, lnavn, adresse, postnummer, tlf, kundetype, by, email);
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

        // return ansat ID by there name - radwan
        public int HentAnsatId(string navn)
        {
            return Ac.HentAnsatId(navn);
        }
        // return a customer object by there tlf proberity - radwan
        public Kunde HentKundByTlf(string tlf)
        {
            return Kc.HentKundetByTlf(tlf);
        }
        // return city name by it's post nummber -radwan
        public string HentBynavn(string postnr)
        {
            return Kc.HentByNavn(postnr);
        }

        // add new ansat to database- radwan
        public string OpretAnsat(string navn, string Stelling, string tlf)
        {
            Ansat a = new Ansat(navn, Stelling, tlf);
            return Ac.OpretAnsat(a);
        }

        // return a data set includes information on customers emails and there pits and the last time they been to to the klinik- radwan
        public DataSet MailSendelse2(int days)
        {
            return Jc.MailSendelse2(days);
        }

        // return a list of all the customers in the system _ radwan
        public List<Kunde> HentAlleKunde()
        {
            return Kc.HentAlleKunde();
        }
        // remove a customer and all there pets from the system - radwan
        public string SletEjer(int id)
        {
            return Kc.SletKunde(id);
        }
        public string OpretDyr(int kundeId, string art, string race, int alder, char sex, string behandler)
        {
            return Dc.OpretDyr(kundeId, art, race, alder, sex, behandler);
        }

        public List<BookingTime> HentAlleFritider(Ansat ansat, DateTime datetime, Servicetype servicetype)
        {
            return Bc.HentAlleFritider(ansat, datetime, servicetype);
        }

        public List<BookingTime> HentAlleHentMuligeSlutTider(Ansat ansat, BookingTime dateTime, DateTime date, Servicetype servicetype)
        {
            return Bc.HentAlleHentMuligeSlutTider(ansat, dateTime, date, servicetype);
        }



        public List<Service> HentAlleService(Servicetype servicetype)
        {
            return ServiceC.HentAlleService(servicetype);
        }

        public List<Dyr> HentAlleDyr()
        {
            return Dc.HentAlleDyr();
        }
        // remove an emplyee from the system and updates information of all the pets that are relaited to the employee - radwan
        public string SletAnsat(int id)
        {
            Ansat a = HentAnsat(id);
            return Ac.SletAnsat(a);
        }

        public List<Servicetype> HentAlleServiceType()
        {
            return ServiceC.HentAlleServiceType();
        }
        // return an object of Ansat based on it's Navn property - radwan
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
        // assign  dyrlæge/ veteransygeplejske to a pet - radwan
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
        // updates customer information - radwan
        public string UpdateKunde(int id, string fnavn, string lnavn, string adress, string postnummer, string tlf, string kundetype, string by, string email)
        {
            return Kc.UpdateKunde(id, fnavn, lnavn, adress, postnummer, tlf, kundetype, by, email);
        }

        public double HentLager(string text1, string text2, string text3)
        {
            throw new NotImplementedException();
        }
        // update an emplyees information - radwan
        public string UpdateAnsat(int id, string navn, string stelling, string tlf)
        {
            return Ac.UpdateAnsat(id, navn, stelling, tlf);
        }
        // return a customer based on there telefon nummber - radwan
        public void HentKundeByTlf(string tlf)
        {
            K.Add(Kc.HentKundetByTlf(tlf));
        }
        // return a list of customers based on there telefon nummber - radwan
        public List<Kunde> HentKundeByTlforNavn(string input)
        {
            return Kc.HentKundeByTlforNavn(input);
        }



        //Lager 
        public Lager SøgId(int id)
        {
            return Lc.SøgId(id);
        }

        public List<Lager> HentLager()
        {
            return Lc.HentLager();
        }

        public string TilføjLager(double pris, int antal, int produktid)
        {
            Lager L = new Lager(pris, antal, produktid);
            return Lc.TilføjLager(L);
        }

        // returns the ID of a customer based on there name or telefon nummber - radwan
        public int HentKundeId(string navnEllerTlf)
        {
            return Kc.HentKundeId(navnEllerTlf);
        }
        
        // return an emplyee object based on it's id property - radwan
        public Ansat HentAnsat(int id)
        {
            return Ac.HentAnsat(id);
        }

        //Journal Funktioner
        // creats a journal record - radwan
        public string Opretjournal(int ansatid, int dyrid, string beskrivelse)
        {
            return Jc.OpretJournal(ansatid, dyrid, beskrivelse);
        }
        // remove a journal record - radwan
        public string SletJournal(int id)
        {
            return Jc.SletJournal(id);
        }

        public bool SletBooking(Booking b)
        {
            return Bc.SletBooking(b);
        }
        // returns a list of all the journal records in the database - radwan
        public List<Journal> HentAlleJournale()
        {
            return Jc.HentAlleJournale();
        }
        // return all the journal records of a pet based on it's ID - radwan
        public List<Journal> HentAlleDyrJournale(int dyrid)
        {
            return Jc.HentAlleDyrJournale(dyrid);
        }
        // return a list of all journal records of an employee based on there id - radwan
        public List<Journal> HentAlleAnsateJournale(int ansatId)
        {
            return Jc.HentAlleAnsatJournal(ansatId);
        }
        // return a record of journal based on it's id - radwan
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
        // return the name of an employee based on there id - radwan
        public string HentAnsatNavn(int id)
        {
            return Ac.HentAnsatNavn(id);
        }
        // return a list of all dyrlæge / veternsygeplejske - radwan
        public List<Ansat> HentAlleBehandler()
        {
            return Ac.HentAlleBehandler();
        }
        // return a list of all the emploies in the database - radwan
        public List<Ansat> HentAlleAnsate()
        {
            return Ac.HentAlleAnsatte();
        }
        // return a list of employees based on the name property - radwan
        public List<Ansat> HentAnsatByNavn2(string navn)
        {
            return Ac.HentAnsatByNanv2(navn);
        }
        // reurn a data set includes information about customer name, email , pet id, and the date of the last time they were in the klinik - radwan
        public DataSet MailSendelse()
        {
            return Jc.MailSendelse();
        }

        // Salg system Funktioner
        // save receipt informatin - radwan
        public string GemFaktura(int kundeId, string total, string rabat, string produkter)
        {
            Faktura f = new Faktura(kundeId, total, rabat, produkter);
            return Sc.GemFaktura(f);
        }
        // return a list of all products catagories in the database - radwan
        public List<Kategori> HentAlleKategorier()
        {
            kategorier = Pc.Hentkategorier();
            return Pc.Hentkategorier();
        }
        // return a list of all products in the database - radwan + holger
        public List<Produkt> HentAlleProdukter()
        {
            produkter = Pc.HentAlleProdukter();
            return Pc.HentAlleProdukter();
        }
        // return a list of all receipt of a customer based on there id - radwan
        public List<Faktura> HentKundesFaktura(int kundeId)
        {
            return Sc.HentKundesFaktura(kundeId);
        }
        // return a list of all the receipts in the database - radwan
        public List<Faktura> HentAlleFaktura()
        {
            return Sc.HentAlleFaktura();
        }

        // return a list of products based on it's catagory - radwan+ holger
        public List<Produkt> HentAlleProduktByKategori(Kategori k)
        {
            return Pc.HentAlleProduktByKategori(k);
        }
        // return a product based on it's id property - holger
        public Produkt HentProdukt(int id)
        {
            return Pc.HentProdukt(id);
        }

        public List<Booking> HentAlleBooking(Kunde k)
        {
            return Bc.HentAlleBooking(k);
        }

        public List<Kunde> HentKunderDerManglerMail(int visit, int mail)
        {
            List<Kunde> kundeList = new List<Kunde>();
            List<Dyr> dyrListe = MailController.HentDyrDerManglerMail(visit, mail);
            for (int i = 0; i < dyrListe.Count; i++)
            {
                kundeList.Add(Kc.SøgeKundeById(dyrListe[i].KundeId));
            }

            return kundeList;
        }

        // return a customer object based on it's id property - radwan
        public Kunde HentKundeById(int id)
        {
            return Kc.SøgeKundeById(id);
        }

    }
}
