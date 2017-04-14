using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prvdel
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                lblTime.Text = DateTime.Now.ToString();

        }

        protected void btnTime_Click(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToString();
        }
    }
}