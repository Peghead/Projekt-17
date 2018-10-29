using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_17_Podcast.BLL
{
    public class Avsnitt
    {
        public string podcastTitel;
        public string avsnittTitel;
        public string beskrivning;

        public Avsnitt(string ptitel, string atitel, string beskrivning)
        {
            podcastTitel = ptitel;
            avsnittTitel = atitel;
            this.beskrivning = beskrivning;
        }
        public Avsnitt()
        {

        }
    }
}
