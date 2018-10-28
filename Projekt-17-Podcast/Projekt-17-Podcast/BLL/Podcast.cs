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
        public string avsnittsTitel { get; set; }
        public string beskrivning { get; set; }
        public int antalAvsnitt { get; set; }

        public Podcast(string pTitel, string aTitel, string beskrivning, int antalavsnitt)
        {
            podcastTitel = pTitel;
            avsnittsTitel = aTitel;
            this.beskrivning = beskrivning;
            this.antalAvsnitt = antalAvsnitt;

            //Console.WriteLine(aTitel);
        }
        public Podcast()
        {

        }


    }
}
