using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITlab7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loadSuppliers();
            }

        }
        protected void loadSuppliers()
        {
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            string sqlString = "SELECT * FROM Suppliers";
            SqlCommand komanda = new SqlCommand(sqlString, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataSet ds = new DataSet();
            try
            {
                konekcija.Open();
                adapter.Fill(ds, "Dobavuvachi");
                gvSuppliers.DataSource = ds;
                gvSuppliers.DataBind();
                ViewState["dataset"] = ds;

            }
            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }
            finally
            {
                konekcija.Close();
            }

        }


        protected void gvSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPoraka.Text = gvSuppliers.SelectedRow.Cells[1].Text;
            loadDetails();
        }

        protected void gvSuppliers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            DataSet ds = (DataSet)ViewState["dataset"];
            gvSuppliers.EditIndex = -1;
            gvSuppliers.DataSource = ds;
            gvSuppliers.DataBind();
        }

        protected void gvSuppliers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DataSet ds = (DataSet)ViewState["dataset"];
            gvSuppliers.EditIndex = e.NewEditIndex;
            gvSuppliers.DataSource = ds;
            gvSuppliers.DataBind();
        }

        protected void gvSuppliers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            string sqlString = "UPDATE Suppliers SET CompanyName=@CompanyName, ContactName=@ContactName, City=@City, Phone=@Phone WHERE SupplierID=@SupplierID";
            SqlCommand komanda = new SqlCommand(sqlString, konekcija);
            TextBox tb = (TextBox)gvSuppliers.Rows[e.RowIndex].Cells[2].Controls[0];
            komanda.Parameters.AddWithValue("@ContactName", tb.Text);

            tb = (TextBox)gvSuppliers.Rows[e.RowIndex].Cells[3].Controls[0];
            komanda.Parameters.AddWithValue("@Phone", tb.Text);

            tb = (TextBox)gvSuppliers.Rows[e.RowIndex].Cells[4].Controls[0];
            komanda.Parameters.AddWithValue("@City", tb.Text);

            LinkButton lb = (LinkButton)gvSuppliers.Rows[e.RowIndex].Cells[0].Controls[0];
            komanda.Parameters.AddWithValue("@SupplierID", lb.Text);
            komanda.Parameters.AddWithValue("@CompanyName", gvSuppliers.Rows[e.RowIndex].Cells[1].Text);
            int efekt = 0;
            try
            {
                konekcija.Open();
                efekt = komanda.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }
            finally
            {
                konekcija.Close();
                gvSuppliers.EditIndex = -1;
            }
            if (efekt != 0)
            {
                loadSuppliers();
            }



        }

        protected void gvSuppliers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSuppliers.PageIndex = e.NewPageIndex;
            gvSuppliers.SelectedIndex = -1;
            DataSet ds = (DataSet)ViewState["dataset"];
            gvSuppliers.DataSource = ds;
            gvSuppliers.DataBind();

        }
        protected void loadDetails()
        {
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            string sqlString = "SELECT ProductName,UnitsInStock,UnitPrice FROM Products WHERE SupplierID=@SupplierID ";
            SqlCommand komanda = new SqlCommand(sqlString, konekcija);
            komanda.Parameters.AddWithValue("@SupplierID", gvSuppliers.DataKeys[gvSuppliers.SelectedIndex].Value);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataSet ds = new DataSet();
            try
            {
                konekcija.Open();
                adapter.Fill(ds, "Produkti");
                gvProducts.Visible = true;
                gvProducts.DataSource = ds;
                gvProducts.DataBind();
            }
            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }
            finally
            {
                konekcija.Close();
            }
        }
    }
}