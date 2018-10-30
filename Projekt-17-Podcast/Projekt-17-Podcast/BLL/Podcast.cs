using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_17_Podcast.BLL
{
    public class Podcast
    {
        
        public string podcastTitel { get; set; }
        public int uppdateringsFrekvens { get; set; }
        public string kategori { get; set; }
        public int antalAvsnitt { get; set; }

        public Podcast(string pTitel, int uFreq, string kategori, int antalavsnitt)
        {
            podcastTitel = pTitel;
            uppdateringsFrekvens = uFreq;
            this.kategori = kategori;
            this.antalAvsnitt = antalavsnitt;
        }
        public Podcast()
        {

        }


    }
}
