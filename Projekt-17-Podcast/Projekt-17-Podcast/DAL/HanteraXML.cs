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

        public static void SparaLista()
        {
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\podcasts.txt");
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Podcast>));
            xmlSer.Serialize(stream, PodcastLista.hamtaLista());
            stream.Close();
        }

        public static void SkapaLista()
        {
            if(File.Exists("podcasts.txt")) { 
                XDocument xdoc = XDocument.Load("podcasts.txt");
                xdoc.Descendants("Podcast").Select(p => new
                {
                    podcastTitel = p.Element("podcastTitel").Value,
                    avsnittsTitel = p.Element("avsnittsTitel").Value,
                    beskrivning = p.Element("beskrivning").Value,
                    antalAvsnitt = Convert.ToInt32(p.Element("antalAvsnitt").Value)

                }).ToList().ForEach(p =>
                {
                    Podcast podcast = new Podcast(p.podcastTitel, p.avsnittsTitel, p.beskrivning, p.antalAvsnitt);
                    PodcastLista.laggTill(podcast);
                });
            }
        }
    }
}
