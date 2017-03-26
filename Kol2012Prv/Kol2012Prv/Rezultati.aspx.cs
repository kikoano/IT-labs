using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kol2012Prv
{
    public partial class Rezultati : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["Predmeti"] != null)
            {
                Predmeti p = Application["Predmeti"] as Predmeti;
                List<string> predmeti = p.PredmetiGlasa.OrderByDescending(v => v.Value).Select(i => i.Key).ToList();
                List<int> poeni = p.PredmetiGlasa.Select(v => v.Value).OrderByDescending(v => v).ToList();
                lstPredmeti.DataSource=predmeti;
                lstPoeni.DataSource = poeni;
                lstPredmeti.DataBind();
                lstPoeni.DataBind();
            }
        }
    }
}