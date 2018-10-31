using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_17_Podcast.BLL
{
    public class Kategori
    {
        public string kategoriTitel { get; set; }

        public Kategori(string kategori)
        {
            kategoriTitel = kategori;
        }
        public Kategori()
        {

        }

        public string getKategori()
        {
            return kategoriTitel;
        }
        public void setTitel(string titel)
        {
            kategoriTitel = titel;
        }

    }
}
