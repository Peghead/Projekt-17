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
            DAL.HanteraXML.SkapaListaKategori();

            UpdatePodcastListview();
            UpdatetbKategori();
            UpdatecbKategori();

        }


        private void btnNyPodcast_Click(object sender, EventArgs e)
        {
            var url = tbUrl.Text;   
            int updFreq = Convert.ToInt32(cbUpdFreq.Text.Split(' ')[0]);
            var kategori = cbKategori.Text;

            BLL.LaggTillPodcast.LaggTillNyPodcast(url, updFreq, kategori);
            //DAL.HanteraXML.SparaListaPodcast();
            //DAL.HanteraXML.SparaListaAvsnitt();

            UpdatePodcastListview();
        }

        public void UpdatePodcastListview()
        {
            List<Podcast> lista = PodcastLista.hamtaLista();
            lvPodcasts.Items.Clear();
            foreach(var pod in lista)
            {
                var list = new ListViewItem(new[]
                {
                    pod.PodcastTitel,
                    pod.Kategori,
                    pod.AntalAvsnitt.ToString(),
                    pod.UppdateringsFrekvens.ToString() + " minuter"
                });
                lvPodcasts.Items.Add(list);
            }
        }

        private void UpdateAvsnittListview(string podcastTitel)
        {
            List<Avsnitt> lista = AvsnittsLista.hamtaLista().Where(titel => titel.PodcastTitel == podcastTitel).ToList();
            lvAvsnitt.Items.Clear();
            foreach (var avsnitt in lista)
            {
                var list = new ListViewItem(new[]
                {
                    avsnitt.AvsnittTitel
                });
                lvAvsnitt.Items.Add(list);
            }
        }

        private void UpdatertbBeskrivning(string avsnitt)
        {
            List<Avsnitt> lista = AvsnittsLista.hamtaLista().Where(titel => titel.AvsnittTitel == avsnitt).ToList();
            
            foreach (var avs in lista)
            {
                rtbBeskrivning.Text = avs.hamtaInfo();
            }
        }

        public void UpdatetbKategori()
        {
            lbKategorier.Items.Clear();
            foreach(var kat in KategoriLista.hamtaLista())
            {
                lbKategorier.Items.Add(kat.KategoriTitel);
            }
        }

        public void UpdatecbKategori()
        {
            cbKategori.Items.Clear();
            foreach (var kat in KategoriLista.hamtaLista())
            {
                cbKategori.Items.Add(kat.KategoriTitel);
            }
        }

        public void SparaKategori(string sparaKategori)
        {
            string gammalKategori = lbKategorier.GetItemText(lbKategorier.SelectedItem);

            foreach(var kat in KategoriLista.hamtaLista().Where(kat => kat.KategoriTitel.Equals(gammalKategori)))
            {
                kat.KategoriTitel = sparaKategori;
            }
            UpdatecbKategori();
            UpdatetbKategori();
            //DAL.HanteraXML.SparaListaKategori();
        }

        private void lvPodcasts_ItemActivate(object sender, EventArgs e)
        {
            var index = this.lvPodcasts.SelectedIndices[0];

            string avsnittsTitel = this.lvPodcasts.Items[index].SubItems[0].Text;

            UpdateAvsnittListview(avsnittsTitel);

        }

        private void lvAvsnitt_ItemActivate(object sender, EventArgs e)
        {
            var index = this.lvAvsnitt.SelectedIndices[0];

            string avsnittsTitel = this.lvAvsnitt.Items[index].SubItems[0].Text;

            Console.WriteLine(avsnittsTitel);
            UpdatertbBeskrivning(avsnittsTitel);
        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            var tbKategoriText = tbKategori.Text;
            if(string.IsNullOrEmpty(tbKategoriText)) { 
                System.Windows.Forms.MessageBox.Show("Textfältet får ej vara tomt");
                return;
            }
            if (!Validera.KollaKategori(tbKategoriText))
            {
                System.Windows.Forms.MessageBox.Show(tbKategoriText + 
                    " finns redan");
                return;
            }
            
            Kategori kategori = new Kategori(tbKategoriText);
            KategoriLista.laggTill(kategori);
            UpdatecbKategori();
            UpdatetbKategori();
            //DAL.HanteraXML.SparaListaKategori();
        }

        private void lbKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbKategori.Text = lbKategorier.GetItemText(lbKategorier.SelectedItem);
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            var sparaKategori = tbKategori.Text;

            SparaKategori(sparaKategori);
            //HanteraXML.SparaListaKategori();
        }

        private void btnTabortKategori_Click(object sender, EventArgs e)
        {
            var kategori = lbKategorier.GetItemText(lbKategorier.SelectedItem);
            int i;
            List<Kategori> lista = KategoriLista.hamtaLista();
            i = lista.FindIndex(a => a.KategoriTitel.Equals(kategori));
            lista.RemoveAt(i);
            UpdatecbKategori();
            UpdatetbKategori();
            //HanteraXML.SparaListaKategori();
        }

        private void PodcastForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            HanteraXML.SparaListaKategori();
            HanteraXML.SparaListaAvsnitt();
            HanteraXML.SparaListaPodcast();
        }

        private void btnTabortPodcast_Click(object sender, EventArgs e)
        {
            var titel = lvPodcasts.SelectedItems[0].Text;
            PodcastLista.TabortPodcast(titel);
            AvsnittsLista.TabortAvsnitt(titel);
            UpdatePodcastListview();

        }
    }
}
