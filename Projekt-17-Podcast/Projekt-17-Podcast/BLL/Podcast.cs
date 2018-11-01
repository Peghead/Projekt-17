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
        public string url { get; set; }
        public string podcastTitel { get; set; }
        public int uppdateringsFrekvens { get; set; }
        public string kategori { get; set; }
        public int antalAvsnitt { get; set; }

        public Podcast(string pTitel, int uFreq, string kategori, int antalavsnitt, string url)
        {
            podcastTitel = pTitel;
            uppdateringsFrekvens = uFreq;
            int uFreqMinuter = uFreq * 60000; 
            this.kategori = kategori;
            this.antalAvsnitt = antalavsnitt;
            this.url = url;

            FrekvensTimer.Start(pTitel, url, uFreqMinuter, kategori);
        }
        public Podcast()
        {

        }


    }
}
