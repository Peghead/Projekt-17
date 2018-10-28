using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_17_Podcast.BLL;
using Projekt_17_Podcast.DAL;

namespace Projekt_17_Podcast
{
    public partial class PodcastForm : Form
    {


        public PodcastForm()
        {
            InitializeComponent();
        }

        private void PodcastForm_Load(object sender, EventArgs e)
        {
            new PodcastLista();

            DAL.HanteraXML.SkapaLista();

            UpdatePodcastListview();


        }

        //----------------TEST--------------
        private void button6_Click(object sender, EventArgs e)
        {
            getList();
        }

        public void getList()
        {
            List<Podcast> calledList = PodcastLista.hamtaLista();
            foreach (var p in calledList)
            {
               var test = p.avsnittsTitel;
                Console.WriteLine(test);
            }
        }
        //----------------TEST----------------

        private void btnNyPodcast_Click(object sender, EventArgs e)
        {
            var url = tbUrl.Text;
            var updFreq = cbUpdFreq.Text.Split(' ')[0];
            var kategori = cbKategori.Text;

            BLL.HanteraXML.LaggTillNyPodcast(url, updFreq, kategori);
            DAL.HanteraXML.SparaLista();

            UpdatePodcastListview();
        }

        private void UpdatePodcastListview()
        {
            List<Podcast> lista = PodcastLista.hamtaLista();
            lvPodcasts.Items.Clear();
            foreach(var pod in lista)
            {
                var list = new ListViewItem(new[]
                {
                    pod.antalAvsnitt.ToString(),
                    pod.podcastTitel,
                    pod.avsnittsTitel,
                    pod.beskrivning
                    
                });
                
                lvPodcasts.Items.Add(list);
            }
        }

    }
}
