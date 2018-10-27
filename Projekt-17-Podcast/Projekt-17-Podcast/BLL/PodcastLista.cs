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

            //Console.WriteLine Fungerar om egenskapen är public...
            //Console.WriteLine(pod.avsnittsTitel);
        }

    }
}
