using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITlab5
{
    public partial class Odjava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblOdjava.Text = Session["korisnik"].ToString() + ", штотулку се одјави од сесијата со број:<br>" + Request.QueryString["id"];
        }
    }
}