using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MP_WebClient
{
    public partial class Geometrija : System.Web.UI.Page
    {
        private IT_WebService.Geometrija geo = new IT_WebService.Geometrija();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnPlostina_Click(object sender, EventArgs e)
        {
            lblPlostina.Text = geo.Plostina(double.Parse(txtVisina.Text),double.Parse(txtRadius.Text)).ToString();
        }

        protected void btnVolumen_Click(object sender, EventArgs e)
        {
            lblVolumen.Text = geo.Volumen(double.Parse(txtVisina.Text), double.Parse(txtRadius.Text)).ToString();
        }

        protected void btnInstanci_Click(object sender, EventArgs e)
        {
            IT_WebService.Cilindar c1 = new IT_WebService.Cilindar() {Visina=20,Radius=10 };
            IT_WebService.Cilindar c2 = new IT_WebService.Cilindar() { Visina = double.Parse(txtVisina.Text), Radius = double.Parse(txtRadius.Text) };
            if (geo.SporediCilindri(c1, c2))
                lblRezultat.Text = c1.ToString();
            else
                lblRezultat.Text = c2.ToString();
        }
    }
}