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
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnNyPodcast_Click(object sender, EventArgs e)
        {
            var url = tbUrl.Text;
            var updFreq = cbUpdFreq.Text.Split(' ')[0];
            var kategori = cbKategori.Text;

            HanteraXML.LaggTillNyPodcast(url, updFreq, kategori);
        }

    }
}
