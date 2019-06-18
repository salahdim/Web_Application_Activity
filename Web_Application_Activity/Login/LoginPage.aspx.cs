using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity
{
    public partial class LoginPage : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        String queryStr;
        String name;
        String userRole;
        String role;
        String userName;
        String userNom;
        String firstName;
        String pass;
        String detail;
        String lastName;
        String userId;
        String email;
        String age;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitAuthMethod(object sender, EventArgs e)
        {
           
            
                DoSQLQuery();

        }

        private void DoSQLQuery()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.tbl_user WHERE tbl_user.email='" + emailTextBox.Text + "' AND tbl_user.password='" + passwordTextBox.Text + "' AND tbl_user.estActif='true'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                name = "";
                userRole = "";
                while (reader.HasRows && reader.Read())
                {
                    name = reader.GetString(reader.GetOrdinal("username")) + " " +
                        reader.GetString(reader.GetOrdinal("password"));
                    userRole = reader.GetString(reader.GetOrdinal("codeuser"));
                    userName = reader.GetString(reader.GetOrdinal("lastname")) + " " +
                        reader.GetString(reader.GetOrdinal("firstname"));
                    userNom = reader.GetString(reader.GetOrdinal("username"));
                    firstName= reader.GetString(reader.GetOrdinal("firstname"));
                    lastName = reader.GetString(reader.GetOrdinal("lastname"));
                    email = reader.GetString(reader.GetOrdinal("email"));
                    age = reader.GetString(reader.GetOrdinal("age"));
                    userId = reader.GetString(reader.GetOrdinal("id"));
                    pass = reader.GetString(reader.GetOrdinal("password"));
                    role = reader.GetString(reader.GetOrdinal("role"));
                    detail = reader.GetString(reader.GetOrdinal("detail"));

                }

                if (reader.HasRows)
                {
                    Session["uname"] = name;
                    Session["urole"] = userRole;
                    Session["utname"] = userName;
                    Session["nom"] = userNom;
                    Session["role"] = role;
                    Session["detail"] = detail;
                    Session["ufirst"] = firstName;
                    Session["ulast"] = lastName;
                    Session["uemail"] = email;
                    Session["uage"] = age;
                    Session["Id"] = userId;
                    Session["upass"] = pass;
                    Response.BufferOutput = true;
                    Response.Redirect("~/Home/HomePage.aspx", false);
                }
                else
                {
                    errorLabel.Text = "Invalid user";
                }
                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                errorLabel.Text = e.ToString();
            }
        }


    }
}