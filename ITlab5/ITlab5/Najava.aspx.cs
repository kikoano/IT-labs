using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITlab5
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                ViewState["obidi"] = 0;
            }
        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            if (txtLozinka.Text == "mp")
            {
                Application.Lock();
                ArrayList korisnici = (ArrayList)Application["korisnici"];
                korisnici.Add(txtKorisnik.Text);
                Application["korisnici"] = korisnici;
                Application.UnLock();
                Session["korisnik"]=txtKorisnik.Text;
                Response.Redirect("~/GlavnaStranica.aspx");
            }
            else
            {
                int obidi = (int)ViewState["obidi"]+1;
                if (obidi >= 3)
                {
                    lblObidi.Text = "Го надминавте бројот на обиди за најава!<br>Не ви е дозволено да се најавите.";
                    btnPodnesi.Enabled = false;
                }
                else
                {
                    lblObidi.Text = obidi.ToString();
                }
                ViewState["obidi"] = obidi;
            }
        }
    }
}