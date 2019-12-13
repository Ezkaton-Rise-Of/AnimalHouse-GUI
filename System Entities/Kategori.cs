using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouse_Entities
{
    public class Kategori
    {
        public Kategori()
        {
        }

        public Kategori(int kategoriId, string kategoriNavn)
        {
            KategoriId = kategoriId;
            KategoriNavn = kategoriNavn;
        }

        public int KategoriId { get; set; }
        public string KategoriNavn { get; set; }

    }
}
