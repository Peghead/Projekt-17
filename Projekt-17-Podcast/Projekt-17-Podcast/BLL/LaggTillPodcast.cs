using Projekt_17_Podcast.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_17_Podcast.BLL
{
    class LaggTillPodcast
    {
        public static void LaggTillNyPodcast(string url, int freq, string kategori)
        {
            if (Validera.KollaRSS(url))
            {
                HanteraRssFeed.hamtaRssInfo(url, freq, kategori);
            }
        }
    }
}
