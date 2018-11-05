using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_17_Podcast.BLL
{
    public class UpdateListView : PodcastForm
    {
        public PodcastForm mainForm { get; set; }

        public static void laddaForm()
        {
            PodcastForm form = new UpdateListView();
            form.UpdatePodcastListview();
            form.Dispose();
        }
        public UpdateListView()
        {
        }

        public new void UpdatePodcastListview()
        {
            PodcastForm form = new UpdateListView();
            ListView lvPodcasts = mainForm.GetLvPodcast();

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
        //public PodcastForm Form
        //{
        //    get { return form; }
        //}


    }
}

