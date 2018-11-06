using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Projekt_17_Podcast.BLL;

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

            Gateway.SkapaListor();

            UpdatePodcastListview();
            UpdatetbKategori();
            UpdatecbKategori();
        }

        public Action GetForm()
        {
            return UpdatePodcastListview;
        }

        public ListView GetLvPodcast()
        {
            return lvPodcasts;
        }


        private void btnNyPodcast_Click(object sender, EventArgs e)
        {
            var url = tbUrl.Text;
            if (Validera.kollaOmUrlRedanFinns(url) && kollaUrl() && kollaUppdateringsfrekvens() && kollaKategori()) { 
            int updFreq = Convert.ToInt32(cbUpdFreq.Text.Split(' ')[0]);
            var kategori = cbKategori.Text;

            BLL.Gateway.LaggTillNyPodcast(url, updFreq, kategori);
            UpdatePodcastListview();
            }
        }

        public void UpdatePodcastListview()
        {
            List<Podcast> lista = PodcastLista.hamtaLista();
            lvPodcasts.Items.Clear();

            foreach (var pod in lista)
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

        public void UpdatePodcastListviewKategori(string kategori)
        {
            List<Podcast> lista = PodcastLista.hamtaLista();
            lvPodcasts.Items.Clear();

            foreach (var pod in lista.Where(p => p.Kategori == kategori))
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

            if(string.IsNullOrEmpty(gammalKategori))
            {
                System.Windows.Forms.MessageBox.Show("För att redigera en kategori måste kategorin som ska ändras vara markerad");
                return;
            }

            foreach(var kat in KategoriLista.hamtaLista().Where(kat => kat.KategoriTitel.Equals(gammalKategori)))
            {
                kat.KategoriTitel = sparaKategori;
            }
            UpdatecbKategori();
            UpdatetbKategori();
        }

        public void SparaPodcast(string pTitel)
        {
            foreach(var pod in PodcastLista.hamtaLista().Where(p => p.PodcastTitel.Equals(pTitel)))
            {
                tbUrl.Text = pod.Url;
                cbUpdFreq.SelectedIndex = cbUpdFreq.Items.IndexOf(pod.UppdateringsFrekvens + " minuter");
                cbKategori.SelectedIndex = cbKategori.Items.IndexOf(pod.Kategori);

            }
        }

        public void UppdateraPodcast(string pTitel)
        {
            string url = tbUrl.Text;
            int freq = Convert.ToInt32(cbUpdFreq.Text.Split(' ')[0]);
            string kat = cbKategori.Text;

            PodcastLista.TabortPodcast(pTitel);
            AvsnittsLista.TabortAvsnitt(pTitel);
            Gateway.LaggTillNyPodcast(url, freq, kat);

            UpdatePodcastListview();
            lvAvsnitt.Items.Clear();
        }

        private void lvPodcasts_ItemActivate(object sender, EventArgs e)
        {
            var index = this.lvPodcasts.SelectedIndices[0];
            btnSparaPodcast.Enabled = true;
            btnTabortPodcast.Enabled = true;
            string podcastTitel = this.lvPodcasts.Items[index].SubItems[0].Text;
            SparaPodcast(podcastTitel);

            UpdateAvsnittListview(podcastTitel);

        }

        private void lvAvsnitt_ItemActivate(object sender, EventArgs e)
        {
            var index = this.lvAvsnitt.SelectedIndices[0];
            string avsnittsTitel = this.lvAvsnitt.Items[index].SubItems[0].Text;
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
        }

        private void lbKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kategori = lbKategorier.GetItemText(lbKategorier.SelectedItem);
            tbKategori.Text = kategori;
            UpdatePodcastListviewKategori(kategori);

        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            var sparaKategori = tbKategori.Text;
            SparaKategori(sparaKategori);
        }

        private void btnTabortKategori_Click(object sender, EventArgs e)
        {
            try
            {
                var kategori = lbKategorier.GetItemText(lbKategorier.SelectedItem);
                int i;
                List<Kategori> lista = KategoriLista.hamtaLista();
                i = lista.FindIndex(a => a.KategoriTitel.Equals(kategori));
                lista.RemoveAt(i);
                UpdatecbKategori();
                UpdatetbKategori();
            } catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("För att ta bort en kategori måste kategorin som ska tas bort vara markerad");
            }
        }

        private void PodcastForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Gateway.SparaListor();
        }

        private void btnTabortPodcast_Click(object sender, EventArgs e)
        {
            var titel = "";
            try
            {
                titel = lvPodcasts.SelectedItems[0].Text;
                PodcastLista.TabortPodcast(titel);
                AvsnittsLista.TabortAvsnitt(titel);
                UpdatePodcastListview();
            } catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("För att ta bort en podcast måste podcasten som ska tas bort vara markerad");
            }
        }

        private void btnSparaPodcast_Click(object sender, EventArgs e)
        {
            string podcastTitel = "";
            try
            {
                var index = lvPodcasts.SelectedIndices[0];
                podcastTitel = lvPodcasts.Items[index].SubItems[0].Text;
                UppdateraPodcast(podcastTitel); 
            } catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("För att redigera en podcast måste podcasten som ska ändras vara markerad");
            }
        }

        private void lbKategorier_Leave(object sender, EventArgs e)
        {
            UpdatePodcastListview();
        }

        private bool kollaUrl()
        {
            string url = tbUrl.Text;
            if(!string.IsNullOrEmpty(url))
            {
                return true;
            }
            System.Windows.Forms.MessageBox.Show("Url-fältet får ej vara tomt");
            return false;
        }

        private bool kollaUppdateringsfrekvens()
        {
            string freq = cbUpdFreq.Text;
            if (!string.IsNullOrEmpty(freq))
            {
                return true;
            }
            System.Windows.Forms.MessageBox.Show("Var vänlig välj en uppdateringsfrekvens");
            return false;
        }

        private bool kollaKategori()
        {
            string kategori = cbKategori.Text;
            if (!string.IsNullOrEmpty(kategori))
            {
                return true;
            }
            System.Windows.Forms.MessageBox.Show("Var vänlig välj en kategori");
            return false;
        }
    }
}
