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
            new KategoriLista();

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
                    avsnitt.avsnittTitel
                });

                lvAvsnitt.Items.Add(list);
            }
        }

        private void UpdatertbBeskrivning(string avsnitt)
        {
            List<Avsnitt> lista = AvsnittsLista.hamtaLista().Where(titel => titel.avsnittTitel == avsnitt).ToList();
            
            foreach (var avs in lista)
            {
                var titel = avs.avsnittTitel;
                var beskrivning = avs.beskrivning;
                string nl = "\r\n";
                rtbBeskrivning.Text = titel + nl + beskrivning;
            }
        }

        public void UpdatetbKategori(List<Kategori> lista)
        {
            lbKategorier.Items.Clear();
            foreach(var kat in lista)
            {
                lbKategorier.Items.Add(kat.kategoriTitel);
            }
        }

        public void UpdatecbKategori(List<Kategori> lista)
        {
            cbKategori.Items.Clear();
            foreach (var kat in lista)
            {
                cbKategori.Items.Add(kat.kategoriTitel);
            }
        }

        private void lvPodcasts_ItemActivate(object sender, EventArgs e)
        {
            var index = this.lvPodcasts.SelectedIndices[0];

            string firstValue = this.lvPodcasts.Items[index].SubItems[0].Text;

            UpdateAvsnittListview(firstValue);

        }

        private void lvAvsnitt_ItemActivate(object sender, EventArgs e)
        {
            var index = this.lvAvsnitt.SelectedIndices[0];

            string firstValue = this.lvAvsnitt.Items[index].SubItems[0].Text;

            Console.WriteLine(firstValue);
            UpdatertbBeskrivning(firstValue);
        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
                if(!string.IsNullOrEmpty(tbKategori.Text)) { 
                var tbKategoriText = tbKategori.Text;
                Kategori kategori = new Kategori(tbKategoriText);
                KategoriLista.laggTill(kategori);
                UpdatecbKategori(KategoriLista.hamtaLista());
                UpdatetbKategori(KategoriLista.hamtaLista());
            }
        }


    }
}
