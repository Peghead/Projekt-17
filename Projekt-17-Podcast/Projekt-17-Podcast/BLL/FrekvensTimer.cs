using Projekt_17_Podcast.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Projekt_17_Podcast.BLL
{
    public class FrekvensTimer
    {

        public static void Start(string pTitel, string url, int freq, string kategori)
        {
            int uFreqMinuter = freq * 10000;
            System.Timers.Timer aTimer = new System.Timers.Timer();
            //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Elapsed += (sender, e) => OnTimedEvent(sender, e, pTitel, url, uFreqMinuter, kategori);
            aTimer.Interval = uFreqMinuter;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e, string pTitel, string url, int freq, string kategori)
        {
            //Hämtar avsnitt i podcast som finns i listan
            List<Podcast> lista = PodcastLista.hamtaLista();
            int antalAvsnitt = 0;
            string podcastTitel = "";
            int i = 0;
            foreach (var pod in lista.Where(p => p.podcastTitel.Equals(pTitel)))
            {
                antalAvsnitt = pod.antalAvsnitt;
                podcastTitel = pod.podcastTitel;
                i++;
            }

            //Hämtar avsnitt i podcast URL
            int nyaAvsnitt = HanteraRssFeed.hamtaAvsnittRss(url);

            Console.WriteLine("Jämför listorna.");
            if (nyaAvsnitt == antalAvsnitt)
            {
                Console.WriteLine("Inga nya avsnitt tillgängliga.");
            }
            else
            {
                //Metod för att ta bort podcast sedan -->
                PodcastLista.TabortPodcast(podcastTitel);
                AvsnittsLista.TabortAvsnitt(podcastTitel);
                LaggTillPodcast.LaggTillNyPodcast(url, freq, kategori);
                Console.WriteLine("Listan har uppdaterats.");
            }

        }

        public static void OnStart()
        {
            int i = 0;
            foreach(var pod in PodcastLista.hamtaLista())
            {
                string pTitel = pod.podcastTitel;
                string url = pod.url;
                int freq = pod.uppdateringsFrekvens;
                string kategori = pod.kategori;
                Start(pTitel, url, freq, kategori);
                i++;
            }
        }

    }
}