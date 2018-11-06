using System;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using Projekt_17_Podcast.BLL;

namespace Projekt_17_Podcast.DAL
{
    public class HanteraRssFeed
    {
        public static async Task<int> hamtaAvsnittRss(string url)
        {
            using (XmlReader reader = XmlReader.Create(url))
            {
                int i = 0;
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                foreach (SyndicationItem item in feed.Items)
                {
                    i++;
                }
                return i;
            }
        }

        public static void hamtaRssInfo(string url, int freq, string kategori)
        {
            using (XmlReader reader = XmlReader.Create(url))
            {
                try { 
                    SyndicationFeed feed = SyndicationFeed.Load(reader);
                    var mainTitle = feed.Title.Text;
                    int i = 0;

                    foreach (SyndicationItem item in feed.Items)
                    {
                        string title = item.Title.Text;
                        string summary = (((TextSyndicationContent)item.Summary).Text);
                        Avsnitt avsnitt = new Avsnitt(mainTitle, title, summary);
                        AvsnittsLista.laggTill(avsnitt);
                        i++;
                    }
                    Podcast podcast = new Podcast(mainTitle, freq, kategori, i, url);
                    PodcastLista.laggTill(podcast);
                    FrekvensTimer.Start(mainTitle, url, freq, kategori);
                } catch (Exception) {
                    System.Windows.Forms.MessageBox.Show("Denna RSS-feed gick ej att läsa");
                }
            }
        }
    }
}
