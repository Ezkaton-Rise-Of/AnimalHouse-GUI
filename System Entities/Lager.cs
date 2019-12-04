using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Lager
    {
        public List<Lager> LagerList;
        public decimal voresPris;
        public int antal;
        public Produkt produkt;

        public Lager()
        {
        }

        public Lager(List<Lager> lagerList, decimal voresPris, int antal, Produkt produkt)
        {
            this.LagerList = lagerList;
            this.voresPris = voresPris;
            this.antal = antal;
            this.produkt = produkt;
        }


        //    public int ID { get; set; }
        //    public string VareNummer { get; set; }
        //    public string VareNavn { get; set; }
        //    public int MinAntal { get; set; }
        //    public int Antal { get; set; }
        //    public decimal Pris { get; set; }
        //    public decimal EksMoms { get; set; }

        //    public Lager() { }
        //    public Lager(int id, string varenummer, string varenavn, int mantal, int antal, decimal prisdkk, decimal eksmoms)
        //    {
        //        ID = id;
        //        VareNummer = varenummer;
        //        VareNavn = varenavn;
        //        MinAntal = mantal;
        //        Antal = antal;
        //        Pris = prisdkk;
        //        EksMoms = eksmoms;
        //    }

        //    public Lager(string varenummer, string varenavn, int mantal, int antal, decimal pris, decimal eksmoms)
        //    {
        //        VareNummer = varenummer;
        //        VareNavn = varenavn;
        //        MinAntal = mantal;
        //        Antal = antal;
        //        Pris = pris;
        //        EksMoms = eksmoms;
        //    }
    }
}
