using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace i21_zad2
{
    public class AnimalRecord
    {
        public string Gatunek { get; set; }
        public string RodzajSzkoły { get; set; }
        public string Szkoła { get; set; }
        public string Klasa { get; set; }
        public int IlośćMiłośników { get; set; }

        public AnimalRecord() { }

        public AnimalRecord(string gatunek, string rodzajSzkoły, string szkoła, string klasa, int ilośćMiłośników)
        {
            Gatunek = gatunek;
            RodzajSzkoły = rodzajSzkoły;
            Szkoła = szkoła;
            Klasa = klasa;
            IlośćMiłośników = ilośćMiłośników;
        }
    }
}
