using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfObrazy3p1
{
    public class Obraz
    {
        public string UrlObrazka { get; set; }
        public int LicznikPobran { get; set; }

        public Obraz(string urlObrazka)
        {
            UrlObrazka = urlObrazka;
            LicznikPobran = 0;
        }
    }
}
