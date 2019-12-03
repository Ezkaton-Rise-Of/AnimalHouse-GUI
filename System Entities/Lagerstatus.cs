using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class LagerStatus
    {
        public int StatusID { get; set; }
        public string VareNummer { get; set; }
        public string VareNavn { get; set; }
        public int MAntal { get; set; }
        public int Antal { get; set; }
        public decimal PrisDKK { get; set; }
        public decimal EksMoms { get; set; }

        public LagerStatus() { }
        public LagerStatus(int statusid, string varenummer, string varenavn, int mantal, int antal, decimal prisdkk, decimal eksmoms)
        {
            StatusID = statusid;
            VareNummer = varenummer;
            VareNavn = varenavn;
            MAntal = mantal;
            Antal = antal;
            PrisDKK = prisdkk;
            EksMoms = eksmoms;
        }

        public LagerStatus(string varenavn, int mantal, int antal, decimal prisdkk, decimal eksmoms)
        {
            VareNavn = varenavn;
            MAntal = mantal;
            Antal = antal;
            PrisDKK = prisdkk;
            EksMoms = eksmoms;
        }
    }
}
