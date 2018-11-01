using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_17_Podcast.BLL
{
    public class Avsnitt : IListble
    {
        private string podcastTitel;
        private string avsnittTitel;
        private string beskrivning;

        public Avsnitt(string ptitel, string atitel, string beskrivning)
        {
            podcastTitel = ptitel;
            avsnittTitel = atitel;
            this.beskrivning = beskrivning;
        }
        public Avsnitt()
        {

        }

        public string PodcastTitel
        {
            get { return podcastTitel; }
            set { podcastTitel = value; }
        }
        public string AvsnittTitel
        {
            get { return avsnittTitel; }
            set { avsnittTitel = value; }
        }
        public string Beskrivning
        {
            get { return beskrivning; }
            set { beskrivning = value; }
        }
    }
}
