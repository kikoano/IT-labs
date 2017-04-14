using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prvdel
{
    public partial class Logiranje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProveri_Click(object sender, EventArgs e)
        {
            if (txtLozinka.Text == "интернет технологии")
            {
                txtPoraka.ReadOnly = false;
                SetFocus(txtPoraka);
            }
            else
                Response.Write("Грешка во лозинката!");
        }

        protected void txtPoraka_TextChanged(object sender, EventArgs e)
        {
            btnPrvaStrana.Enabled = true;
        }

        protected void btnPrvaStrana_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}