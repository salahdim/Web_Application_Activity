using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
namespace Web_Application_Activity.Profil
{
    public partial class ModifierProfile : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        String queryStr;
        String name;
        String education;
        String localisation;
        String userRole;
        String userName;
        String userNom;
        String firstName;
        String lastName;
        String userId;
        String email;
        String age;
        String codeUser;
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
                BindGridskills();
                DoSQLImage();
                DoSQLQuery1();
                userName = (String)(Session["utname"]);
                Label14.Text = userName;
                userNom = (String)(Session["nom"]);
                usernametxt.Text = userNom;

                firstName = (String)(Session["ufirst"]);
                firstnametxt.Text = firstName;

                lastName = (String)(Session["ulast"]);
                lastnametxt.Text = lastName;

                email = (String)(Session["uemail"]);
                emailtxt.Text = email;

                age = (String)(Session["uage"]);
                inputAge.Text = age;

                codeUser = (String)(Session["urole"]);

                if ((String)Session["nom"] == usernametxt.Text && (String)Session["ufirst"] == firstnametxt.Text && (String)Session["ulast"] == lastnametxt.Text && (String)Session["uemail"] == emailtxt.Text && (String)Session["uage"] == inputAge.Text)
                {
                    userName = (String)(Session["utname"]);
                    Label14.Text = userName;
                    userNom = (String)(Session["nom"]);
                    LabelUname.Text = userNom;
                    usernametxt.Text = userNom;

                    firstName = (String)(Session["ufirst"]);
                    LabelFirst.Text = firstName;
                    firstnametxt.Text = firstName;

                    lastName = (String)(Session["ulast"]);
                    LabelLast.Text = lastName;
                    lastnametxt.Text = lastName;

                    email = (String)(Session["uemail"]);
                    LabelEmail.Text = email;
                    emailtxt.Text = email;

                    age = (String)(Session["uage"]);
                    LabelAge.Text = age;
                    inputAge.Text = age;

                    codeUser = (String)(Session["urole"]);
                    //  inputCode.Text = codeUser;
                }
                else
                {
                    DoSQLQuery();
                }
            }
        }
        protected void submitUpdateMethod(object sender, EventArgs e)
        {


            DoSQLQueryProfil();




        }



        private void DoSQLQuery1()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.tbl_user WHERE tbl_user.id='" + Session["Id"] + "' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {

                    education = reader.GetString(reader.GetOrdinal("education"));
                    localisation = reader.GetString(reader.GetOrdinal("localisation"));

                }

                if (reader.HasRows)
                {
                    // Session["uname"] = name;

                    //  userName = (String)(Session["utname"]);
                    //    Label14.Text = userName;
                    LabelEducation.Text = education;
                    LabelLocation.Text = localisation;

                }

                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        private void BindGridskills()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("select * from skills where iduser='" + Session["Id"] + "'"))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    con.Close();
                }
            }
        }

        public void DoSQLQueryProfil()
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
                queryStr = "update database.tbl_user set username='" + usernametxt.Text + "',firstname='" + firstnametxt.Text + "',lastname='" + lastnametxt.Text + "',password='" + passwordtxt.Text + "',email='" + emailtxt.Text + "',age='" + inputAge.Text + "',image= @Content,education='"+educationtxt.Text+"',localisation='"+localisationtxt.Text+"' where id='" + Session["Id"] + "';";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@Content", bytes);

                cmd.ExecuteNonQuery();



                conn.Close();
                DoSQLQuery();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public void DoSQLImage()
        {
            try
            {
                Image1.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];
                Image2.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public bool testClick()
        {
            if (Session["IdProf"] == Session["Id"])
            {
                return true;
            }
            return false;
        }

        public void DoSQLQuery()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.tbl_user WHERE tbl_user.email='" + emailtxt.Text + "' AND tbl_user.password='" + passwordtxt.Text + "'";
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
                    firstName = reader.GetString(reader.GetOrdinal("firstname"));
                    lastName = reader.GetString(reader.GetOrdinal("lastname"));
                    email = reader.GetString(reader.GetOrdinal("email"));
                    age = reader.GetString(reader.GetOrdinal("age"));
                    userId = reader.GetString(reader.GetOrdinal("id"));
                   

                }

                if (reader.HasRows)
                {
                    Session["uname"] = name;
                    Session["urole"] = userRole;
                    Session["utname"] = userName;
                    Session["nom"] = userNom;
                    Session["ufirst"] = firstName;
                    Session["ulast"] = lastName;
                    Session["uemail"] = email;
                    Session["uage"] = age;
                    Session["IdProf"] = userId;
                    userName = (String)(Session["utname"]);
                    Label14.Text = userName;
                    userNom = (String)(Session["nom"]);
                    LabelUname.Text = userNom;
                    usernametxt.Text = userNom;

                    firstName = (String)(Session["ufirst"]);
                    LabelFirst.Text = firstName;
                    firstnametxt.Text = firstName;

                    lastName = (String)(Session["ulast"]);
                    LabelLast.Text = lastName;
                    lastnametxt.Text = lastName;

                    email = (String)(Session["uemail"]);
                    LabelEmail.Text = email;
                    emailtxt.Text = email;

                    age = (String)(Session["uage"]);
                    LabelAge.Text = age;
                    inputAge.Text = age;
                    Response.BufferOutput = true;
                    Response.Redirect("~/Profil/Profil.aspx", false);
                }

                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        protected void AddSkills(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.skills (name,iduser,codeuser)VALUES('" + SkillsTxt.Text + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                cmd.ExecuteNonQuery();

                Response.BufferOutput = true;
                Response.Redirect("~/Profil/Profil.aspx", false);

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

        }


    }
}