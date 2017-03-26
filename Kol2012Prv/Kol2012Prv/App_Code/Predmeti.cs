using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kol2012Prv
{
    public class Predmeti
    {
        public Dictionary<string, int> PredmetiGlasa { get; set; }
        public Predmeti()
        {
            PredmetiGlasa = new Dictionary<string, int>();
            PredmetiGlasa.Add("Интернет Технологии", 0);
            PredmetiGlasa.Add("Интернет", 0);
            PredmetiGlasa.Add("Дигитална Електроника", 0);
        }
    }
}