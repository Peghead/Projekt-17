namespace Projekt_17_Podcast.BLL
{
    public class Podcast : ITitel
    {
        private string url { get; set; }
        private string podcastTitel { get; set; }
        private int uppdateringsFrekvens { get; set; }
        private string kategori { get; set; }
        private int antalAvsnitt { get; set; }

        public Podcast(string pTitel, int uFreq, string kategori, int antalavsnitt, string url)
        {
            podcastTitel = pTitel;
            uppdateringsFrekvens = uFreq;
            this.kategori = kategori;
            this.antalAvsnitt = antalavsnitt;
            this.url = url;
            
        }
        public Podcast()
        {

        }

        public string PodcastTitel
        {
            get { return podcastTitel; }
            set { podcastTitel = value; }
        }

        public int UppdateringsFrekvens
        {
            get { return uppdateringsFrekvens; }
            set { uppdateringsFrekvens = value; }
        }

        public string Kategori
        {
            get { return kategori; }
            set { kategori = value; }
        }

        public int AntalAvsnitt
        {
            get { return antalAvsnitt; }
            set { antalAvsnitt = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

    }
}
