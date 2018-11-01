using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_17_Podcast.BLL
{
    public class PodcastLista
    {
        public static List<Podcast> podcastLista { get; set; }

        public PodcastLista()
        {
            podcastLista = new List<Podcast>();
        }

        public static void laggTill(Podcast pod)
        {
            podcastLista.Add(pod);
        }

        public static List<Podcast> hamtaLista()
        {
            return podcastLista;
        }

        public static void TabortPodcast(string pTitel)
        {
            podcastLista.RemoveAll(pod => pod.podcastTitel.Equals(pTitel));
        }


    }
}
