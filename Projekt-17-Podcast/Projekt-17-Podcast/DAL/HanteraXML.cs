using Projekt_17_Podcast.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Projekt_17_Podcast.DAL
{
    public class HanteraXML
    {

        public static void SparaListaPodcast()
        {
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\podcasts.txt");
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Podcast>));
            xmlSer.Serialize(stream, PodcastLista.hamtaLista());
            stream.Close();
        }

        public static void SparaListaAvsnitt()
        {
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\avsnitt.txt");
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Avsnitt>));
            xmlSer.Serialize(stream, AvsnittsLista.hamtaLista());
            stream.Close();
        }

        public static void SkapaListaPodcast()
        {
            if(File.Exists("podcasts.txt")) { 
                XDocument xdoc = XDocument.Load("podcasts.txt");
                xdoc.Descendants("Podcast").Select(p => new
                {
                    podcastTitel = p.Element("podcastTitel").Value,
                    uppdateringsFrekvens = Convert.ToInt32(p.Element("uppdateringsFrekvens").Value),
                    kategori = p.Element("kategori").Value,
                    antalAvsnitt = Convert.ToInt32(p.Element("antalAvsnitt").Value)

                }).ToList().ForEach(p =>
                {
                    Podcast podcast = new Podcast(p.podcastTitel, p.uppdateringsFrekvens, p.kategori, p.antalAvsnitt);
                    PodcastLista.laggTill(podcast);
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
                    podcastTitel = p.Element("podcastTitel").Value,
                    avsnittTitel = p.Element("avsnittTitel").Value,
                    beskrivning = p.Element("beskrivning").Value,

                }).ToList().ForEach(p =>
                {
                    Avsnitt avsnitt = new Avsnitt(p.podcastTitel, p.avsnittTitel, p.beskrivning);
                    AvsnittsLista.laggTill(avsnitt);
                });
            }
        }
    }
}
