using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using AnimalHouseDB;
using AnimalHouse_Entites;
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

        public string OpretKunde(string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, string email)
        {


            return Kc.OpretKunde(fnavn, lnavn, adresse, postnummer, tlf, kundetype, by, email);
        }

        public string OpretDyr(int kundeId, string art, string race, int alder, char sex)
        {
            return Dc.OpretDyr(kundeId, art, race, alder, sex);
        }

        public List<Dyr> HentAlleDyr()
        {
            return Dc.HentAlleDyr();
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

    }
}
