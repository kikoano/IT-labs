using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kol2012Prv
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SelectChanged(object sender, EventArgs e)
        {
            lstKrediti.SelectedIndex = lstPredmeti.SelectedIndex;
            lblProfesor.Text = "Прог. д-р " + lstPredmeti.Text;
        }

        protected void PredmetChange(object sender, EventArgs e)
        {
            lstPredmeti.SelectedIndex = lstKrediti.SelectedIndex;
            lblProfesor.Text = "Прог. д-р " + lstPredmeti.Text;
        }

        protected void btnGlasajte_Click(object sender, EventArgs e)
        {
            if (lstPredmeti.SelectedIndex > -1)
            {
                Session["Predmet"] = lstPredmeti.SelectedItem.Text;
                Application.Lock();
                if (Application["Predmeti"] == null)
                    Application["Predmeti"] = new Predmeti();
                (Application["Predmeti"] as Predmeti).PredmetiGlasa[Session["Predmet"].ToString()]++;
                Application.UnLock();

                HttpCookie cookie = new HttpCookie(Session["Ime"].ToString());
                cookie.Expires = DateTime.Now.AddYears(1);
                cookie.Value = "1";
                Response.Cookies.Add(cookie);

                Response.Redirect("UspesnoGlasanje.aspx");
            }
        }
    }
}