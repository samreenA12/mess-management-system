using System;
using System.Data.SqlClient;
using System.Configuration;

namespace GEASSMessManagement1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Login_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM Students WHERE Username=@u AND Password=@p";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u", txtUser.Text);
                cmd.Parameters.AddWithValue("@p", txtPass.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Session["user"] = txtUser.Text;
                    Response.Cookies["user"].Value = txtUser.Text;

                    Response.Redirect("Menu.aspx");
                }
                else
                {
                    lblMsg.Text = "Invalid Login";
                }
            }
        }
    }
}