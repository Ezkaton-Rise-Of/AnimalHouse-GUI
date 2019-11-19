using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;
namespace AnimalHouseBLL
{
    public class MainController
    {
        KundeController Kc;
        DyrController Dc;
        public MainController()
        {
            Kc = new KundeController();
            Dc = new DyrController();

        }

        public string OpretKunde(string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, DateTime oprettet, string email)
        {


            return Kc.OpretKunde(fnavn, lnavn, adresse, postnummer, tlf, kundetype, by, oprettet, email);
        }

        public string OpretDyr(int kundeId, string art, string race, int alder, char sex)
        {
            return Dc.OpretDyr(kundeId, art, race, alder, sex);
        }

        public string OpretKunde(string text1, string text2, string text3, string text4, string text5, string text6, string v, string text7, string text8)
        {
            throw new NotImplementedException();
        }
    }
}
