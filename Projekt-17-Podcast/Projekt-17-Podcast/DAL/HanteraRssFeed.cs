using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;

namespace Projekt_17_Podcast.DAL
{
    public class HanteraRssFeed
    { 
        public static void hamtaRssInfo(string url)
        {
            //string url = "https://cdn.radioplay.se/data/rss/490.xml";

            using (XmlReader reader = XmlReader.Create(url))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                var mainTitle = feed.Title.Text;
                int i = 0;

                Console.WriteLine(mainTitle);

                foreach (SyndicationItem item in feed.Items)
                {
                    string title = item.Title.Text;
                    string summary = (((TextSyndicationContent)item.Summary).Text);
                    i++;
                    Console.WriteLine(title + " " + summary);
                }
                Console.WriteLine(i);
            }
        }
    }
}
