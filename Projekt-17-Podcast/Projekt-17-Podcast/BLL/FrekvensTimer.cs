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

        public static void Start(string url, int freq, string kategori)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Elapsed += (sender, e) => OnTimedEvent(sender, e, url, freq, kategori);
            aTimer.Interval = freq;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e, string url, int freq, string kategori)
        {
            //Hämtar avsnitt i podcast som finns i listan
            List<Podcast> lista = PodcastLista.hamtaLista();
            int antalAvsnitt = 0;
            foreach (var pod in lista)
            {
                antalAvsnitt = pod.antalAvsnitt;
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
                LaggTillPodcast.LaggTillNyPodcast(url, freq, kategori);
                Console.WriteLine("Listan har uppdaterats.");
            }

        }



    }
}