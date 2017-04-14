using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITlab4
{
    public partial class Registracija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNext1_Click(object sender, EventArgs e)
        {
            mvRegistracija.ActiveViewIndex++;
        }

        protected void btnNext2_Click(object sender, EventArgs e)
        {
            if (calendar.SelectedDate.Date != DateTime.MinValue.Date)
            {
                errorCalendar.Text = "";
                mvRegistracija.ActiveViewIndex++;
            }
            else
            {
                errorCalendar.Text = "Внеси Датум";
            }
        }

        protected void btnBack2_Click(object sender, EventArgs e)
        {
            mvRegistracija.ActiveViewIndex--;
        }

        protected void btnBack3_Click(object sender, EventArgs e)
        {
            mvRegistracija.ActiveViewIndex--;
        }

        protected void btnNext3_Click(object sender, EventArgs e)
        {
            mvRegistracija.ActiveViewIndex++;
            if(int.Parse(txtGodiniVrsenje.Text)>=5)
            lblCreate.Text = "Креиран е корисникот " + txtId.Text + "@finki.ukim.mk";
            else
                lblCreate.Text = "Не е креиран корисникот заради имајќи помалку од 5 години на вршење на своето занимање!";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            mvRegistracija.ActiveViewIndex = 0;
        }

        protected void Changed(object sender, EventArgs e)
        {
            errorCalendar.Text = "";
        }
    }
}