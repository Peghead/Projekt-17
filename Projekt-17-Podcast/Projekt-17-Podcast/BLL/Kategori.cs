namespace Projekt_17_Podcast.BLL
{
    public class Kategori
    {
        private string kategoriTitel { get; set; }

        public Kategori(string kategori)
        {
            kategoriTitel = kategori;
        }

        public Kategori()
        {

        }

        public string KategoriTitel
        {
            get { return kategoriTitel; }
            set { kategoriTitel = value; }
        }
    }
}
