using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_17_Podcast.BLL
{
    public class Podcast
    {
        string podcastTitel { get; set; }
        string avsnittsTitel { get; set; }
        string beskrivning { get; set; }
        int antalAvsnitt { get; set; }

        public Podcast(string pTitel, string aTitel, string beskrivning, int antalavsnitt)
        {
            podcastTitel = pTitel;
            avsnittsTitel = aTitel;
            this.beskrivning = beskrivning;
            this.antalAvsnitt = antalAvsnitt;

            Console.WriteLine(aTitel);
        }
        
    }
}
