using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Web_Application_Activity.Profil
{
    public partial class AddProfil : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;

        String queryStr;
        String value;
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
            BindGridDepartement();
        }
        protected void SendEmailConfirm()
        {
            MailMessage mMailMessage = new MailMessage((String)(Session["uemail"]), TextEmail.Text);
            mMailMessage.Subject = "Besiness Report";
            mMailMessage.Body = "Nous sommes heureux de vous informer que tu es devenu un nouveau utilisateur de notre application. Avec votre email est "+TextEmail.Text+" et votre mot de passe est "+TextPassword.Text+ ". Merci de vous connecter et compléter les informations manquantes sur votre profile ";




            SmtpClient mSmtpClient = new SmtpClient("smtp.gmail.com", 587);
            mSmtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = (String)(Session["uemail"]),

                Password = (String)(Session["upass"])


            };

            mSmtpClient.EnableSsl = true;
            mSmtpClient.Send(mMailMessage);
        }

        private void BindGridDepartement()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("select * from departement "))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridDepartement.DataSource = cmd.ExecuteReader();
                    GridDepartement.DataBind();
                    con.Close();
                }
            }
        }

        protected void AddUser(object sender, EventArgs e)
        {
            try
            {
                string filename = Path.GetFileName(UploadImage.PostedFile.FileName);
                string contentType = UploadImage.PostedFile.ContentType;
                Stream fs = UploadImage.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);
                byte[] bytes = br.ReadBytes((Int32)fs.Length);
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                if(RadioResponsable.Checked == true)
                {
                    value = "responsable";
                }
                else if (RadioUser.Checked==true) {
                    value = "user";
                }
                queryStr = "INSERT INTO database.tbl_user (username,firstname,lastname,password,cin,sexe,detail,email,telephone,codePostale,age,image,education,localisation,codeuser,role,estActif)VALUES('" + TextUsername.Text+"', '" +TextPrenom.Text+ "' ,'" +TextNom.Text+ "','" +TextPassword.Text+ "','"+TextCIN.Text+"','"+TextSexe.Text+"','"+TextDetail.Text+"', '"+TextEmail.Text+ "','"+TextTelephone.Text+"','"+TextPostal.Text+"','"+TextAge.Text+ "',@Content,'"+TextEducation.Text+"', '"+TextLocalisation.Text+ "' ,'"+TextCodeUser.Text+ "','"+value+ "','true')";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@Content", bytes);

                cmd.ExecuteNonQuery();

                Response.BufferOutput = true;
                Response.Redirect("~/Profil/ListeUser.aspx", false);

                conn.Close();
                SendEmailConfirm();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

        }
    }
}