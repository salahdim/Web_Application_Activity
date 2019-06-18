using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace Web_Application_Activity.Mail
{
   
    public partial class ReadMailRec : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        String queryStr;
        String mailFrom;
        String contentMail;
        String subjectMail;
        String dateMail;
        String name;
        String userName;
        String contentType;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                name = (String)(Session["uname"]);
                if (name == null)
                {
                    Response.BufferOutput = true;
                    Response.Redirect("~/Login/LoginPage.aspx", false);
                }
                DoSQLImage();
                DoSQLImage1();
                DoSQLQuery();
                BindGrid4();
                userName = (String)(Session["utname"]);
                Label14.Text = userName;
            }

        }

        private void DoSQLImage1()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.email WHERE email.id='" + Session["Indexrec"] + "'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {


                    contentType = reader.GetString(reader.GetOrdinal("contenttype"));
                }

                if (reader.HasRows)
                {

                    if (contentType != "application/pdf")
                    {
                        Image2.ImageUrl = "~/ShowMail.ashx?id=" + Session["Indexrec"];

                    }
                    else
                    {
                        Image2.ImageUrl = "http://www.dogsleds.ca/images/non-disponible.png";
                    }
                }

                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        protected void DoSQLQueryDelete(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "DELETE FROM database.email WHERE email.id='" + Session["Indexrec"] + "'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Response.BufferOutput = true;
            Response.Redirect("~/Mail/Inbox.aspx", false);

        }

        protected void View(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            string embed = "<object data=\"{0}{1}\" type=\"application/pdf\" width=\"500px\" height=\"600px\">";
            embed += "If you are unable to view file, you can download from <a href = \"{0}{1}&download=1\">here</a>";
            embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
            embed += "</object>";
            ltEmbed.Text = string.Format(embed, ResolveUrl("~/FileCS.ashx?Id="), id);
        }

        private void BindGrid4()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("select * from email where id='"+ Session["Indexrec"] + "' AND contenttype LIKE 'application/%'"))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    con.Close();
                }
            }
        }



        private void DoSQLQuery()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.email WHERE email.id='" + Session["Indexrec"] + "' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {

                    mailFrom = reader.GetString(reader.GetOrdinal("emailFrom"));
                    contentMail = reader.GetString(reader.GetOrdinal("content"));
                    subjectMail = reader.GetString(reader.GetOrdinal("subject"));
                    dateMail = reader.GetString(reader.GetOrdinal("date"));
                }

                if (reader.HasRows)
                {
                    // Session["uname"] = name;

                    //  userName = (String)(Session["utname"]);
                    //    Label14.Text = userName;
                    LabelMail.Text = mailFrom;
                    LabelSubject.Text = subjectMail;
                    LabelContent.Text = contentMail;
                    LabelDate.Text = dateMail;
                }

                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private void DoSQLImage()
        {
            try
            {

                Image1.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}