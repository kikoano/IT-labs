using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prvdel
{
    public partial class NovaStranica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOdzemi_Click(object sender, EventArgs e)
        {
            int op1 = Convert.ToInt32(txtOperand1.Text); int op2 = Convert.ToInt32(txtOperand2.Text); lblRezultat.Text = Convert.ToString(op1 - op2);
        }

        protected void chbVidlivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVidlivo.Checked)
                pnlPanela1.Visible = true;
            else pnlPanela1.Visible = false;

        }
    }
}