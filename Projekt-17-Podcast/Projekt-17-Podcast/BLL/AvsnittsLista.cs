﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            //Console.WriteLine Fungerar om egenskapen är public...
            //Console.WriteLine(pod.avsnittsTitel);
        }

        public static List<Avsnitt> hamtaLista()
        {
            return avsnittsLista;
        }
    }
}
