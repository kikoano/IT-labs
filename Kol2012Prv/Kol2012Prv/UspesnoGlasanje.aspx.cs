using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kol2012Prv
{
    public partial class UspesnoGlasanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPoraka.Text=Session["Ime"]+", Ви благпдариме за учествптп вп акцијата за избпр на најинтересен предмет на ФИНКИ.Вашипт избпр беше "+Session["Predmet"]+". Резултатите пд гласаоетп ќе ги дпбиете пп електрпнска ппшта, на "+Session["Email"]+".";
        }
    }
}