﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;
using AnimalHouseBLL;

namespace AnimalHouseBLL
{
    public class MainController
    {

        public List<Dyr> D = new List<Dyr>();
        public List<Kunde> K = new List<Kunde>();

        KundeController Kc;
        DyrController Dc;
        AnsatController Ac;
        BookingController Bc;
        public MainController()
        {
            Kc = new KundeController();
            Dc = new DyrController();
            Ac = new AnsatController();
            Bc = new BookingController();
        }

        public string OpretKunde(string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, string email)
        {

            Kunde k = new Kunde(fnavn, lnavn, adresse, postnummer, tlf, kundetype, by, email);
            return Kc.OpretKunde(k);
        }

        public string Opretbooking(string notat, DateTime startDato, DateTime slutDato, int serviceId, int dyrId, int ansatId)
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

        public object HentAnsatByNavn(string v)
        {
            return Ac.HentAnsatByName(v);
        }

        public Kunde HentKundByTlf(string tlf)
        {
            return Kc.HenKundetByTlf(tlf);
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

        public void HentAlleKundesDyr(int kundeId)
        {
            try
            {
                D = Dc.HentAlleKundesDyr(kundeId);
            }
            catch (Exception et)
            {

                throw et;
            }
           
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
             K.Add(Kc.HenKundetByTlf(tlf));
        }

        public List<Kunde> HentKundeByTlforNavn(string input)
        {
            return Kc.HentKundeByTlforNavn(input);
        }
    }
}
