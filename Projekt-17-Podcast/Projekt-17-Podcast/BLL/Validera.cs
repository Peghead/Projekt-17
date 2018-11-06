using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Projekt_17_Podcast.BLL
{
    class Validera
    {

        public static bool KollaRSS(string url)
        {
            try { 
                SyndicationFeed feed = SyndicationFeed.Load(XmlReader.Create(url));
                Console.WriteLine("Länken är giltig");
                return true;

            } catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Länken är ej giltig");
                return false;
            }
        }

        public static bool KollaKategori(string kategori)
        {
            var lista = KategoriLista.hamtaLista();
            foreach(var kat in lista)
            {
                if(kat.KategoriTitel.Equals(kategori))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool kollaOmUrlRedanFinns(string url)
        {
            List<Podcast> lista = PodcastLista.hamtaLista();
            foreach (var pod in lista.Where(p => p.Url == url))
            {
                System.Windows.Forms.MessageBox.Show("Denna podcasten finns redan");
                return false;
            }
            return true;
        }
    }
}
