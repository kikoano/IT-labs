using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_WebService
{
    public class Cilindar
    {
        public double Visina { get; set; }
        public double Radius { get; set; }
        public override string ToString()
        {
            return "Висина " + Visina + " Радиус " + Radius;
        }
    }
}