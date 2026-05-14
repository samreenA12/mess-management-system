using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GEASSMessManagement1
{
    public partial class Menu : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lblWelcome.Text = "Welcome, " + Session["user"].ToString();
            }

            if (!IsPostBack)
            {
                LoadMenu();
            }
        }

        void LoadMenu()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MessMenu", connStr))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Filter_Click(object sender, EventArgs e)
        {
            ViewState["day"] = ddlDay.SelectedValue;

            string query = "SELECT * FROM MessMenu";

            if (ddlDay.SelectedValue != "All")
            {
                query += " WHERE Day=@day";
            }

            using (SqlDataAdapter da = new SqlDataAdapter(query, connStr))
            {
                if (ddlDay.SelectedValue != "All")
                {
                    da.SelectCommand.Parameters.AddWithValue("@day", ddlDay.SelectedValue);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
                }
        }
    }
}