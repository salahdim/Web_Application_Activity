using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;
namespace Web_Application_Activity.Profil
{
    public partial class ListeUser : System.Web.UI.Page
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
            DoSQLImage();
            BindGrid();
            Label1.Text = (String)(Session["utname"]);
        }

        private void DoSQLImage()
        {
            try
            {
                Image2.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        protected void SendEmailConfirm()
        {
            MailMessage mMailMessage = new MailMessage((String)(Session["uemail"]), (String)(Session["IndexEmail"]));
            mMailMessage.Subject = "Besiness Report";
            mMailMessage.Body = "Vous etez supprimer de la base de donnée de notre application Business Report ";




            SmtpClient mSmtpClient = new SmtpClient("smtp.gmail.com", 587);
            mSmtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = (String)(Session["uemail"]),

                Password = (String)(Session["upass"])


            };

            mSmtpClient.EnableSsl = true;
            mSmtpClient.Send(mMailMessage);
        }

        protected void BindGrid()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.tbl_user WHERE tbl_user.id !='" + (String)(Session["Id"]) + "'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                MyListUser.DataSource = dt;
                                MyListUser.DataBind();


                            }
                        }
                    }

                }
            }


        }


        protected void maGrille_ItemCommand(object sender, DataGridCommandEventArgs e)
        {
            Session["IndexUsers"] = e.Item.Cells[0].Text;
            Session["IndexEmail"] = e.Item.Cells[5].Text;
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "DELETE FROM database.tbl_user WHERE id='" + Session["IndexUsers"] + "' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Response.BufferOutput = true;
            Response.Redirect("~/Profil/ListeUser.aspx", false);
            SendEmailConfirm();
        }


    }
}