using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kol2012Prv
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNajava_Click(object sender, EventArgs e)
        {
            if(Request.Cookies[txtIme.Text] == null)
                firstTime();
            else
                lblNajaven.Text = txtIme.Text + "веќе учествувавте вп гласаоетп. Секпј кприсник има правп да гласа самп еднаш. Ви благпдариме!";
        }
        private void firstTime()
        {
            Session["Ime"] = txtIme.Text;
            Session["Email"] = txtEmail.Text;
            Response.Redirect("Glasaj.aspx");
        }
    }
}