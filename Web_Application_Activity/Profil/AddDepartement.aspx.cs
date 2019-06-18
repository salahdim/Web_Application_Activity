using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity.Profil
{
    public partial class AddDepartement : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;

        String queryStr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)(Session["uname"]) == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Login/LoginPage.aspx", false);
            }
            if ((String)(Session["role"]) != "admin")
            {
                Response.BufferOutput = true;
                Response.Redirect("~/ForgetLog/Lockscreen.aspx", false);
            }

        }

        protected void AddDep(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.departement (libelle,description)VALUES('" + TextLibelle.Text + "', '" + TextDescription.Text + "' )";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }
    }
}