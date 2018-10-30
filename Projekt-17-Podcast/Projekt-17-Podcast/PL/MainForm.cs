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
            new AvsnittsLista();

            DAL.HanteraXML.SkapaListaPodcast();
            DAL.HanteraXML.SkapaListaAvsnitt();

            UpdatePodcastListview();

        }


        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void btnNyPodcast_Click(object sender, EventArgs e)
        {
            var url = tbUrl.Text;   
            int updFreq = Convert.ToInt32(cbUpdFreq.Text.Split(' ')[0]);
            var kategori = cbKategori.Text;

            BLL.LaggTillPodcast.LaggTillNyPodcast(url, updFreq, kategori);
            DAL.HanteraXML.SparaListaPodcast();
            DAL.HanteraXML.SparaListaAvsnitt();

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
                    
                    pod.podcastTitel,
                    pod.kategori,
                    pod.antalAvsnitt.ToString(),
                    pod.uppdateringsFrekvens.ToString() + " minuter"
                    
                    
                });
                
                lvPodcasts.Items.Add(list);
            }
        }

        private void UpdateAvsnittListview(string podcastTitel)
        {
            List<Avsnitt> lista = AvsnittsLista.hamtaLista().Where(titel => titel.podcastTitel == podcastTitel).ToList();
            lvAvsnitt.Items.Clear();
            foreach (var avsnitt in lista)
            {
                
                var list = new ListViewItem(new[]
                {
                    podcastTitel,
                    avsnitt.avsnittTitel
                });

                lvAvsnitt.Items.Add(list);
            }
        }

        private void lvPodcasts_ItemActivate(object sender, EventArgs e)
        {
            var index = this.lvPodcasts.SelectedIndices[0];

            string firstValue = this.lvPodcasts.Items[index].SubItems[0].Text;

            Console.WriteLine(firstValue);
            UpdateAvsnittListview(firstValue);

        }
    }
}
