using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Web_Application_Activity
{
    public partial class HomePage : System.Web.UI.Page
    {
        String queryStr;
        String name;
        String userName;
        String userRole;

       



        protected void Page_Load(object sender, EventArgs e)
        {
            name = (String)(Session["uname"]);
            if (name == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Login/LoginPage.aspx", false);
            }

            userName = (String)(Session["utname"]);
           Label14.Text = userName;

            userRole = (String)(Session["urole"]);


            if (!Page.IsPostBack)
            {
                DoSQLImage();
                Countuser();
                CountTb();
                CountAmis();
                CountNbEmail();
            }

        }




        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("~/Login/LoginPage.aspx", false);


        }







       




        private void  Countuser()
        {
           
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT COUNT(*) FROM database.tbl_user";
                int count = -1;
                MySqlCommand cmd = new MySqlCommand(queryStr, conn);
                count = int.Parse(cmd.ExecuteScalar() + "");
                count1.Text = count.ToString();

                
                conn.Close();
                
            
           
        }

        private void CountAmis()
        {

            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            queryStr = "";
            queryStr = "SELECT COUNT(*) FROM database.amis WHERE (amis.iduser='" + Session["Id"] + "' OR amis.idami='" + Session["Id"] + "') AND amis.accepte='true' ";
            int countt = -1;
            MySqlCommand cmd = new MySqlCommand(queryStr, conn);
            countt = int.Parse(cmd.ExecuteScalar() + "");
            LabelNbAmis.Text = countt.ToString();


            conn.Close();



        }
        private void CountNbEmail()
        {

            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            queryStr = "";
            queryStr = "SELECT COUNT(*) FROM database.email WHERE email.emailTo='" + Session["uemail"] + "' AND email.estLu='non lu' ";
            int countt = -1;
            MySqlCommand cmd = new MySqlCommand(queryStr, conn);
            countt = int.Parse(cmd.ExecuteScalar() + "");
            LabelnbMail.Text = countt.ToString();
            conn.Close();

        }


        private void CountTb()
        {

            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            queryStr = "";
            queryStr = "SELECT COUNT(*) FROM database.detail WHERE detail.codeuser='" + Session["urole"] + "' ";
            int countt = -1;
            MySqlCommand cmd = new MySqlCommand(queryStr, conn);
            countt = int.Parse(cmd.ExecuteScalar() + "");
            count2.Text = countt.ToString();


            conn.Close();



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
        protected void SendEmail1(object sender, EventArgs e)
        {
            MailMessage mMailMessage = new MailMessage((String)(Session["uemail"]), emailTxtTo.Text);
            mMailMessage.Subject = subjectTxt.Text;
            mMailMessage.Body = TextMessagee.Text;

           


            SmtpClient mSmtpClient = new SmtpClient("smtp.gmail.com", 587);
            mSmtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = (String)(Session["uemail"]),

                Password = (String)(Session["upass"])


            };

            mSmtpClient.EnableSsl = true;
            mSmtpClient.Send(mMailMessage);
        }



    }
}