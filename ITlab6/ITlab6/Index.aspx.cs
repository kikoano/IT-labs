using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITlab6
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPoraka.Text = "";
            if (!IsPostBack)
                updateList();
        }
        private void updateList()
        {
            lstCustomers.Items.Clear();
            string query = "SELECT CustomerID, CompanyName FROM Customers ORDER BY CompanyName";
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstCustomers.Items.Add(new ListItem(reader["CompanyName"].ToString(), reader["CustomerID"].ToString()));
                }
                reader.Close();

            }
            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }
            finally
            {
                con.Close();
            }
        }

        protected void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Customers WHERE CustomerID='"+lstCustomers.SelectedValue+"'";
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtID.Text = reader["CustomerID"].ToString();
                    txtCompany.Text = reader["CompanyName"].ToString();
                    txtContact.Text = reader["ContactName"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    txtCity.Text = reader["City"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    reader.Close();
                }

            }
            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtCompany.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            lstCustomers.SelectedIndex = -1;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Customers SET CustomerID=@CustomerID, CompanyName=@CompanyName, ContactName=@ContactName, Address=@Address, City=@City, Phone=@Phone WHERE CustomerID=@CustomerID";
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CustomerID", txtID.Text);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompany.Text);
            cmd.Parameters.AddWithValue("@ContactName", txtContact.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }
            finally
            {
                con.Close();
            }
            updateList();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Customers(CustomerID,CompanyName,ContactName,Address,City,Phone) VALUES(@CustomerID,@CompanyName,@ContactName,@Address,@City,@Phone)";
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CustomerID", txtID.Text);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompany.Text);
            cmd.Parameters.AddWithValue("@ContactName", txtContact.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }
            finally
            {
                con.Close();
            }
            updateList();
        }
    }
}