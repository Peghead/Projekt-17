using System.Collections.Generic;

namespace Projekt_17_Podcast.BLL
{
    public class AvsnittsLista
    {
        public static List<Avsnitt> avsnittsLista { get; set; }

        public AvsnittsLista()
        {
            avsnittsLista = new List<Avsnitt>();
        }

        public static void laggTill(Avsnitt avsnitt)
        {
            avsnittsLista.Add(avsnitt);
        }

        public static List<Avsnitt> hamtaLista()
        {
            return avsnittsLista;
        }

        public static void TabortAvsnitt(string pTitel)
        {
            avsnittsLista.RemoveAll(avs => avs.PodcastTitel.Equals(pTitel));
        }
    }
}
