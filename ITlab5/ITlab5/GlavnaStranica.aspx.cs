using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITlab5
{
    public partial class GlavnaStranica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList korisnici = (ArrayList)Application["korisnici"];
            lblNajaveniKorisnici.Text = "";
            foreach (string k in korisnici)
            {
                lblNajaveniKorisnici.Text += k + "<br>";
            }
            if (!IsPostBack)
            {
                lblKorisnici.Text = korisnici.Count.ToString();
                lblKorisnik.Text = Session["korisnik"].ToString();
                string[] listaNaBoi = Enum.GetNames(typeof(System.Drawing.KnownColor));
                ddFont.DataSource = listaNaBoi;
                ddPozadina.DataSource = listaNaBoi;
                ddFont.DataBind();
                ddPozadina.DataBind();
                HttpCookie cookie = Request.Cookies[lblKorisnik.Text];
                if (cookie != null)
                {
                    pnlPanela1.BackColor = Color.FromName(cookie["pozadina"]);
                    lblPoraka.ForeColor = Color.FromName(cookie["font"]);
                    lblPoraka.Text = cookie["poslednaNajava"];
                }
                else
                {
                    lblPoraka.Text = lblKorisnik.Text + ", ова е твојата прва посета на страницата.<br>Избери боја на позадина и фонт,<br>а потоа кликни на зачивај за да се зачува<br>твојот избор на бои.";
                }
            }
        }

        protected void ddPozadina_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlPanela1.BackColor = Color.FromName(ddPozadina.SelectedItem.Text);
        }

        protected void ddFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPoraka.ForeColor = Color.FromName(ddFont.SelectedItem.Text);
        }

        protected void btnZacuvaj_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie(lblKorisnik.Text);
            cookie["pozadina"] = ddPozadina.SelectedItem.Text;
            cookie["font"] = ddFont.SelectedItem.Text;
            cookie["poslednaNajava"] = DateTime.Now.ToString();
            cookie.Expires = DateTime.Now.AddMinutes(5);
            Response.Cookies.Add(cookie);
            lblPoraka.Text = "Креирано е колаче";
        }

        protected void btnOdjava_Click(object sender, EventArgs e)
        {
            Application.Lock();
            ArrayList korisnici = (ArrayList)Application["korisnici"];
            korisnici.Remove(lblKorisnik.Text);
            Application["korisnici"] = korisnici;
            Application.UnLock();
            Session["korisnik"] = lblKorisnik.Text;
            Response.Redirect("~/Odjava.aspx?id=" + Session.SessionID);
        }
    }
}