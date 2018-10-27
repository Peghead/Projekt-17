using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
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
                Console.WriteLine("Länken va ej giltig");
                return false;
            }
        }
    }
}
