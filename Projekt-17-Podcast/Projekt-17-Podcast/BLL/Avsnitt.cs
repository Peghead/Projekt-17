using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_17_Podcast.BLL
{
    public class Avsnitt : AvsnittsInfo
    {
        private string podcastTitel;
        private string avsnittTitel;
        private string beskrivning;

        public Avsnitt(string podcastTitel, string avsnittTitel, string beskrivning) : base(podcastTitel, avsnittTitel, beskrivning)
        {
            this.podcastTitel = podcastTitel;
            this.avsnittTitel = avsnittTitel;
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

        public override string hamtaInfo()
        {
            string nl = "\r\n";
            return avsnittTitel + nl + beskrivning;
        }
    }
}