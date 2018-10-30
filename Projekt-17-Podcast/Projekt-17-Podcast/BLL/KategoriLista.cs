using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_17_Podcast.BLL
{
    public class KategoriLista
    {
        public static List<Kategori> kategoriLista { get; set; }

        public KategoriLista()
        {
            kategoriLista = new List<Kategori>();
        }

        public static void laggTill(Kategori kat)
        {
            kategoriLista.Add(kat);
        }

        public static List<Kategori> hamtaLista()
        {
            return kategoriLista;
        }
    }
}
