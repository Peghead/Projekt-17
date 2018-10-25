using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------
using System.Xml;
using System.ServiceModel.Syndication;
//--------------

namespace Projekt_17_Podcast
{
    public partial class Podcastlista : Form
    {
        public Podcastlista()
        {
            InitializeComponent();
        }

        private void Podcastlista_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            test();
        }

        //-----------------------------
        public void test()
        {
            string url = "https://cdn.radioplay.se/data/rss/490.xml";

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
        //--------------------------------

    }
}
