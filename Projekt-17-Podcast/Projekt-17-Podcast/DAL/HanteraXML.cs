using Projekt_17_Podcast.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Projekt_17_Podcast.DAL
{
    public class HanteraXML
    {

        public static void SparaListaPodcast()
        {
            if (File.Exists("podcasts.txt"))
            {
                File.Delete("podcasts.txt");
            }
            using (Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\podcasts.txt"))
            { 
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Podcast>));
                xmlSer.Serialize(stream, PodcastLista.hamtaLista());
                stream.Close();
            }
        }
        
        public static void SparaListaAvsnitt()
        {
            if (File.Exists("avsnitt.txt"))
            {
                File.Delete("avsnitt.txt");
            }
            using (Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\avsnitt.txt"))
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Avsnitt>));
                xmlSer.Serialize(stream, AvsnittsLista.hamtaLista());
                stream.Close();
            }
        }

        public static void SparaListaKategori()
        {
            if (File.Exists("kategorier.txt"))
            {
                File.Delete("kategorier.txt");
            }
            using (Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\kategorier.txt"))
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Kategori>));
                xmlSer.Serialize(stream, KategoriLista.hamtaLista());
                stream.Close();
            }
        }

        public static void SkapaListaPodcast()
        {
            if(File.Exists("podcasts.txt")) {
                XDocument xdoc = XDocument.Load("podcasts.txt");
                xdoc.Descendants("Podcast").Select(p => new
                {
                    url = p.Element("Url").Value,
                    podcastTitel = p.Element("PodcastTitel").Value,
                    uppdateringsFrekvens = Convert.ToInt32(p.Element("UppdateringsFrekvens").Value),
                    kategori = p.Element("Kategori").Value,
                    antalAvsnitt = Convert.ToInt32(p.Element("AntalAvsnitt").Value)
                }).ToList().ForEach(p => 
                {
                    Podcast podcast = new Podcast(p.podcastTitel, p.uppdateringsFrekvens, p.kategori, p.antalAvsnitt, p.url);
                    PodcastLista.laggTill(podcast);
                    FrekvensTimer.Start(p.podcastTitel, p.url, p.uppdateringsFrekvens, p.kategori);
                });
            }
        }

        public static void SkapaListaAvsnitt()
        {
            if (File.Exists("avsnitt.txt"))
            {
                XDocument xdoc = XDocument.Load("avsnitt.txt");
                xdoc.Descendants("Avsnitt").Select(p => new
                {
                    podcastTitel = p.Element("PodcastTitel").Value,
                    avsnittTitel = p.Element("AvsnittTitel").Value,
                    beskrivning = p.Element("Beskrivning").Value,

                }).ToList().ForEach(p =>
                {
                    Avsnitt avsnitt = new Avsnitt(p.podcastTitel, p.avsnittTitel, p.beskrivning);
                    AvsnittsLista.laggTill(avsnitt);
                });
            }
        }

        public static void SkapaListaKategori()
        {
            if (File.Exists("kategorier.txt"))
            {
                XDocument xdoc = XDocument.Load("kategorier.txt");
                xdoc.Descendants("Kategori").Select(p => new
                {
                    kategoriTitel = p.Element("KategoriTitel").Value,

                }).ToList().ForEach(p =>
                {
                    Kategori kategori = new Kategori(p.kategoriTitel);
                    KategoriLista.laggTill(kategori);
                });
            }
        }
    }
}
