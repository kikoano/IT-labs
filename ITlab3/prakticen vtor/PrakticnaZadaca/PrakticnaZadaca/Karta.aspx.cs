using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrakticnaZadaca
{
    public partial class Karta : System.Web.UI.Page
    {
        private string[] meseci = { "Јануари", "Фебруари", "Март", "Април", "Мај", "Јуни", "Јули", "Август", "Септември", "Октомври", "Ноември", "Декември" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlPanela1.Visible = false;
                for (int i = 1; i <= 31; i++)
                {
                    ddlDen.Items.Add(new ListItem(Convert.ToString(i)));
                }
                ddlMesec.DataSource = meseci;
                ddlMesec.DataBind();
                DateTime time = DateTime.Parse("00:00");
                for (int i = 0; i < 1440; i++)
                {
                    ddlVreme.Items.Add(new ListItem(time.AddMinutes(i).ToString("HH:mm")));
                }
            }
        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                UpdatePanel1();
            }
        }
        private bool Validate()
        {
            if (txtIme.Text.Length > 0 && txtPrezime.Text.Length > 0 && lstSredstvo.SelectedIndex > -1 && rblZona.SelectedIndex > -1 && rblKlasa.SelectedIndex > -1)
                return true;
            else return false;
        }
        private void UpdatePanel1()
        {
            lblPatnik.Text = txtIme.Text + " " + txtPrezime.Text;
            lblSredstvo.Text = lstSredstvo.SelectedItem.Text;
            lblOd.Text = ddlOd.SelectedItem.Text;
            lblDo.Text = ddlDo.SelectedItem.Text;
            lblVreme.Text = ddlDen.SelectedItem.Text + "." + (int)(meseci.ToList().IndexOf(ddlMesec.SelectedItem.Text) + 1) + "." + ddlGodina.SelectedItem.Text + " во " + ddlVreme.SelectedItem.Text + " часот";
            lblZona.Text = rblZona.SelectedItem.Text;
            lblKlasa.Text = rblKlasa.SelectedItem.Text;
            lblPosluga.Text = "";
            foreach (ListItem l in cblPosluga.Items)
            {
                if (l.Selected)
                    lblPosluga.Text += l.Text + " ";
            }
            if (lstSredstvo.SelectedItem.Text == "Авион")
                imgSlika.ImageUrl = "Sliki/airplane.jpg";
            else if (lstSredstvo.SelectedItem.Text == "Воз")
                imgSlika.ImageUrl = "Sliki/train.jpg";
            pnlPanela1.Visible = true;
        }

        protected void UpdateImePrezime(object sender, EventArgs e)
        {
            lblPatnik.Text = txtIme.Text + " " + txtPrezime.Text;
        }

        protected void UpdateOd(object sender, EventArgs e)
        {
            lblOd.Text = ddlOd.SelectedItem.Text;
        }

        protected void UpdateDo(object sender, EventArgs e)
        {
            lblDo.Text = ddlDo.SelectedItem.Text;
        }

        protected void UpdateDMY(object sender, EventArgs e)
        {
            lblVreme.Text = ddlDen.SelectedItem.Text + "." + (int)(meseci.ToList().IndexOf(ddlMesec.SelectedItem.Text) + 1) + "." + ddlGodina.SelectedItem.Text + " во " + ddlVreme.SelectedItem.Text + " часот";
        }

        protected void UpdateZone(object sender, EventArgs e)
        {
            lblZona.Text = rblZona.SelectedItem.Text;
        }

        protected void UpdateKlasa(object sender, EventArgs e)
        {
            lblKlasa.Text = rblKlasa.SelectedItem.Text;
        }

        protected void UpdatePosluga(object sender, EventArgs e)
        {
            lblPosluga.Text = "";
            foreach (ListItem l in cblPosluga.Items)
            {
                if (l.Selected)
                    lblPosluga.Text += l.Text + " ";
            }
        }

        protected void UpdateSredstvo(object sender, EventArgs e)
        {
            lblSredstvo.Text = lstSredstvo.SelectedItem.Text;
            if (lstSredstvo.SelectedItem.Text == "Авион")
                imgSlika.ImageUrl = "Sliki/airplane.jpg";
            else if (lstSredstvo.SelectedItem.Text == "Воз")
                imgSlika.ImageUrl = "Sliki/train.jpg";
        }
    }
}