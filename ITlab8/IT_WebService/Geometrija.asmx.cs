using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace IT_WebService
{
    /// <summary>
    /// Summary description for Geometrija
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Geometrija : System.Web.Services.WebService
    {

        [WebMethod(Description = "Presmetuvaje plostina na cilindar.")]
        public double Plostina(double visina, double radius)
        {
            return 2 * Math.PI * radius * (radius + visina);
        }
        [WebMethod(Description = "Presmetuvaje volumen na cilindar.")]
        public double Volumen(double visina, double radius)
        {
            return Math.PI * radius * radius * visina;
        }
        [WebMethod(Description = "Sporeduvanje na dva cilindri spored volumen")]
        public bool SporediCilindri(Cilindar c1, Cilindar c2)
        {
            return Volumen(c1.Visina, c1.Radius) > Volumen(c2.Visina, c2.Radius);
        }

    }
}
