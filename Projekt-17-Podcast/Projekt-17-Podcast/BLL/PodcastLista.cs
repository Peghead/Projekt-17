using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_17_Podcast.BLL
{
    public class PodcastLista
    {
        public List<Podcast> Podcasts { get; set; }

        public PodcastLista()
        {
            Podcasts = new List<Podcast>();
        }
    }
}
