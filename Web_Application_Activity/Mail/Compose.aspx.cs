using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
namespace Web_Application_Activity.Mail
{
    public partial class Compose : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;

        String queryStr;
        String name;

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

            }
            DoSQLImage5();

        }
        protected void SendRefrech(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("~/Mail/Compose.aspx", false);
        }


        protected void SendEmail(object sender, EventArgs e)
        {
            MailMessage mMailMessage = new MailMessage((String)(Session["uemail"]), TextTo.Text);
            mMailMessage.Subject = TextSubject.Text;
            mMailMessage.Body = TextContent.Text;

            string fileName = "";
            if (Textattachment.PostedFile != null)
            {
                HttpPostedFile attchment = Textattachment.PostedFile;
                int FileLength = attchment.ContentLength;
                if (FileLength > 0)
                {
                    fileName = Path.GetFileName(Textattachment.PostedFile.FileName);
                    Textattachment.PostedFile.SaveAs(Path.Combine(Server.MapPath("~/AttachemntMail"),fileName));
                    Attachment attachment = new Attachment(Path.Combine(Server.MapPath("~/AttachemntMail"), fileName));
                    mMailMessage.Attachments.Add(attachment);
                }
            }


            SmtpClient mSmtpClient = new SmtpClient("smtp.gmail.com", 587);
            mSmtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = (String)(Session["uemail"]),

                Password = (String)(Session["upass"])

                
            };
           
            mSmtpClient.EnableSsl = true;
            mSmtpClient.Send(mMailMessage);
            DoSQLQueryEmail();
        }



        private void DoSQLQueryEmail()
        {
            try
            {
                string filename = Path.GetFileName(Textattachment.PostedFile.FileName);
                string contentType = Textattachment.PostedFile.ContentType;
                Stream fs = Textattachment.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);
                byte[] bytes = br.ReadBytes((Int32)fs.Length);
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
               
                queryStr = "";
                Session["edate"] = System.DateTime.Now.ToString();

                queryStr = "INSERT INTO database.email (subject,content,date,attachement,filename,contenttype,emailFrom,emailTo,estLu,codeuser,iduser)VALUES('" + TextSubject.Text+"','"+TextContent.Text+"', '"+ (String)(Session["edate"]) + "', @Content , @Name , @ContentType , '" + (String)(Session["uemail"]) + "','"+TextTo.Text+"','non lu','" + (String)(Session["urole"]) + "','" + (String)(Session["Id"]) + "')";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@Content", bytes);
                cmd.Parameters.AddWithValue("@Name", filename);
                cmd.Parameters.AddWithValue("@ContentType", contentType);
                cmd.ExecuteNonQuery();

                

                conn.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



        private void DoSQLImage5()
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
