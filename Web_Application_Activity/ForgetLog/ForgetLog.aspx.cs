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

namespace Web_Application_Activity.ForgetLog
{
    public partial class ForgetLog : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        String queryStr;
        String pwd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void ForgetUser(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                pwd = null;
                queryStr = "SELECT password FROM database.tbl_user WHERE tbl_user.email='" + emailTxt.Text + "'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {
                   
                 
                    pwd = reader.GetString(reader.GetOrdinal("password"));
                    

                }
                reader.Close();
                conn.Close();
                if (pwd != null)
                {

                   

                    
                    MailMessage mMailMessage = new MailMessage("salah.dimassi.developer@gmail.com", emailTxt.Text);
                    mMailMessage.Subject = "Envoi de mot de passe";
                    mMailMessage.Body = "Votre Mot De Passe est :'"+ pwd + "'";




                    SmtpClient mSmtpClient = new SmtpClient("smtp.gmail.com", 587);
                    mSmtpClient.Credentials = new System.Net.NetworkCredential()
                    {
                        UserName = "salah.dimassi.developer@gmail.com",

                        Password = pwd


                    };

                    mSmtpClient.EnableSsl = true;
                    mSmtpClient.Send(mMailMessage);

                }

              

                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}