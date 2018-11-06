using Projekt_17_Podcast.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Projekt_17_Podcast.BLL
{
    public class FrekvensTimer
    {
        public static event EventHandler CatchPodcastUpdate;

        private static int MilliTillMinut(int freqMilli)
        {
            int freqMinut = freqMilli * 1000;
            return freqMinut;
        }

        public static void Start(string pTitel, string url, int freq, string kategori)
        {
            int uFreqMinuter = MilliTillMinut(freq);
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += (sender, e) => OnTimedEvent(sender, e, pTitel, freq, url, kategori);
            aTimer.Interval = uFreqMinuter;
            aTimer.Enabled = true;
        }

        private static async void OnTimedEvent(object source, ElapsedEventArgs e, string pTitel, int freq, string url, string kategori)
        {
            List<Podcast> lista = PodcastLista.hamtaLista();
            bool isHere = false;
            foreach (var pod in lista.Where(p => p.PodcastTitel == pTitel))
            {
                isHere = true;
            }
            if (isHere) { 
                int antalAvsnitt = 0;
                string podcastTitel = "";
                int i = 0;
                int nyFreq = 0;
                foreach (var pod in lista.Where(p => p.PodcastTitel.Equals(pTitel)))
                {
                    antalAvsnitt = pod.AntalAvsnitt;
                    podcastTitel = pod.PodcastTitel;
                    nyFreq = pod.UppdateringsFrekvens;
                    i++;
                }
                int nyaAvsnitt = await HanteraRssFeed.hamtaAvsnittRss(url);

                Console.WriteLine("Söker efter nya avsnitt.");
                if (nyaAvsnitt == antalAvsnitt)
                {
                    Console.WriteLine(pTitel + " har inga nya avsnitt tillgängliga.");
                }

                else
                {
                    PodcastLista.TabortPodcast(podcastTitel);
                    AvsnittsLista.TabortAvsnitt(podcastTitel);
                    Gateway.LaggTillNyPodcast(url, freq, kategori);
                    CatchPodcastUpdate(source, e);
                    Console.WriteLine("Nya avsnitt hittades, Podcasten har uppdaterats.");
                }
            }
        }
    }
}