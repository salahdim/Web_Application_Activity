using System;
using System.Collections.Generic;
using System.Drawing;
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
    public partial class Profil1 : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        String valeur;
        String queryStr;
        String name;
        String userName;
        String detail;
        String userNom;
        String firstName;
        String lastName;
        String email;
        String education;
        String localisation;
        String age;
        String role;
        String userRole;

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
                BindGridCollegue();
                BindGrid();
                BindGrid1();
                BindGrid2();
                BindGrid3();
                BindGrid5();
                BindGrid6();
                BindGrid7();
                BindGrid8();
                BindGrid9();
                BindGrid10();
                BindGrid11();
                BindGrid12();
                BindGrid13();
                BindGrid14();
                BindGrid4();
                BindGridskills();
                userName = (String)(Session["utname"]);
                Label14.Text = userName;
                if (((String)Session["role"]) == "admin")
                {
                    LabelContent.Text = "Voulez-vous vraiment Voir Autre Mode ?";
                }
                else
                {
                    LabelContent.Text = "Vous n'avez pas la permission de voir autre mode";
                    ButtonListe.Visible = false;
                    ButtonAdd.Visible = false;
                    ButtonAddDep.Visible = false;
                }

                 
                    userName = (String)(Session["utname"]);
                    Label14.Text = userName;
                    userNom = (String)(Session["nom"]);
                    LabelUname.Text = userNom;

                    firstName = (String)(Session["ufirst"]);
                    LabelFirst.Text = firstName;

                    lastName = (String)(Session["ulast"]);
                    LabelLast.Text = lastName;
                    email = (String)(Session["uemail"]);
                    LabelEmail.Text = email;

                    age = (String)(Session["uage"]);
                    LabelAge.Text = age;

                
                    DoSQLQuery();
                    BindDemande();
                BindAmis();
            }
        }
        protected void AddSortie(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Sorties', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                cmd.ExecuteNonQuery();

                Response.BufferOutput = true;
                Response.Redirect("~/Profil/Profil.aspx", false);

                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

            }




        }

        protected void AddSports(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Sports', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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

        protected void AddUser(object sender, EventArgs e) {
            Response.BufferOutput = true;
            Response.Redirect("~/Profil/AddProfil.aspx", false);
        }
        protected void AddDep(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("~/Profil/AddDepartement.aspx", false);
        }

        protected void ListeUser(object sender, EventArgs e) {
            Response.BufferOutput = true;
            Response.Redirect("~/Profil/ListeUser.aspx", false);
        }


        protected void BindDemande()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.tbl_user WHERE tbl_user.id IN (SELECT iduser FROM database.amis WHERE amis.idami='" + (String)(Session["Id"]) + "' AND amis.accepte='false' )"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                MyDemandeAmis.DataSource = dt;
                                MyDemandeAmis.DataBind();


                            }
                        }
                    }

                }
            }


        }

        protected void BindAmis()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.tbl_user WHERE tbl_user.id IN (SELECT iduser FROM database.amis WHERE (amis.idami='" + (String)(Session["Id"]) + "' OR amis.iduser='" + Session["Id"] + "') AND amis.accepte='true' )"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                DataGridAmis.DataSource = dt;
                                DataGridAmis.DataBind();


                            }
                        }
                    }

                }
            }


        }

        protected void AddArts(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Arts ou artisanat', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddTravail(object sender, EventArgs e)
        {

            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Travail, réparation, rénovation', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddJeux(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Jeux', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddLire(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Lire et écrire', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddVetements(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Vêtements', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddRendreService(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Rendre service', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddAlimentation(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Alimentation', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddSujets(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Sujets de conversations', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddActivitesMentales(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Activités mentales', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddGouter(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('gouter à un plaisir simple', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddSpiritualite(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Spiritualité', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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
        protected void AddEtreAvecAutres(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Etre avec autres', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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

        protected void AddDevelopper(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.activite (nature,content,iduser,codeuser)VALUES('Développer de nouvelles habiletés', '" + ContentData.Value + "' ,'" + Session["Id"] + "','" + Session["urole"] + "')";

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


        private void BindGridCollegue()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.tbl_user WHERE tbl_user.id !='" + (String)(Session["Id"]) + "'  "))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                DataGridCollegue.DataSource = dt;
                                DataGridCollegue.DataBind();


                            }
                        }
                    }

                }
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


        private void DoSQLImage()
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


        private void DoSQLQuery()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.tbl_user WHERE tbl_user.id='" + Session["Id"] + "'";
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
                    role = reader.GetString(reader.GetOrdinal("role"));
                    detail = reader.GetString(reader.GetOrdinal("detail"));                    
                    education = reader.GetString(reader.GetOrdinal("education"));
                    localisation = reader.GetString(reader.GetOrdinal("localisation"));

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
                    Label14.Text = userName;
                    Label1.Text = userName;
                    userNom = (String)(Session["nom"]);
                    LabelUname.Text = userNom;
                    LabelFirst.Text = firstName;

                    LabelLast.Text = lastName;

                    LabelEmail.Text = email;

                    LabelAge.Text = age;
                    LabelEducation.Text = education;
                    LabelLocation.Text = localisation;
                    LabelDetail.Text = detail;
                   
                }
                else
                {
                }
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }



        protected void maGrille_ItemCommand(object sender, DataGridCommandEventArgs e)
        {
            Session["Indexactivity"] = e.Item.Cells[0].Text;
            Session["Contentactivity"] = e.Item.Cells[1].Text;
           
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "DELETE FROM database.activite WHERE id='" + Session["Indexactivity"] + "' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Response.BufferOutput = true;
            Response.Redirect("~/Profil/Profil.aspx", false);
        }

        protected void DoSQLUpdateSecteur(object sender, EventArgs e)
        {
            try
            {
                if (((String)Session["role"])=="admin")
                {
                    LabelContent.Text = "Voulez-vous vraiment Voir Autre Mode ?";

                    if (((String)Session["urole"])=="0")
                    {
                        valeur = "1";
                        Session["dep"] = "Departement technique";
                    }
                    if (((String)Session["urole"]) == "1")
                    {
                        valeur = "2";
                        Session["dep"] = "Departement financier";

                    }
                    if (((String)Session["urole"]) == "2")
                    {
                        valeur = "3";
                        Session["dep"] = "Departement commercial";

                    }
                    if (((String)Session["urole"]) == "3")
                    {
                        valeur = "0";
                        Session["dep"] = "Departement administrateur";

                    }


                    String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "update database.tbl_user set codeuser='"+ valeur + "' where id='" + Session["Id"] + "';";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                    Response.BufferOutput = true;
                    Response.Redirect("~/Profil/Profil.aspx", false);
                }
                else
                {
                    LabelContent.Text = "Vous n'avez pas la permission de voir autre mode";
                    Response.BufferOutput = true;
                    Response.Redirect("~/Profil/Profil.aspx", false);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        protected void maGrille_ItemDemande(object sender, DataGridCommandEventArgs e)
        {
            Session["IndexDemande"] = e.Item.Cells[0].Text;

            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "update database.amis set accepte='true' where amis.idami='" + Session["Id"] + "' AND amis.iduser='" + (String)(Session["IndexDemande"]) + "';";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Response.BufferOutput = true;
            Response.Redirect("~/Profil/Profil.aspx", false);
        }


        protected void maGrille_ItemCommandAmis(object sender, DataGridCommandEventArgs e)
        {
            Session["IdAmis"]= e.Item.Cells[0].Text;
            Response.BufferOutput = true;
            Response.Redirect("~/Profil/ProfilAmis.aspx", false);
        }

        protected void BindGrid()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Sorties' "))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                MyDataGrid.DataSource = dt;
                                MyDataGrid.DataBind();
                                
                                
                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid1()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "'  AND activite.nature='Sports'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                               
                                DataGrid1.DataSource = dt;
                                DataGrid1.DataBind();
                               

                            }
                        }
                    }

                }
            }


        }

        protected void BindGrid2()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "'  AND activite.nature='Arts ou artisanat'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);

                                DataGrid2.DataSource = dt;
                                DataGrid2.DataBind();


                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid3()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Travail, réparation, rénovation'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                               
                                DataGrid3.DataSource = dt;
                                DataGrid3.DataBind();
                               

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid4()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Jeux'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                               
                                DataGrid4.DataSource = dt;
                                DataGrid4.DataBind();
                               

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid5()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Lire et écrire'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                
                                DataGrid5.DataSource = dt;
                                DataGrid5.DataBind();
                               

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid6()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Vêtements'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                               
                                DataGrid6.DataSource = dt;
                                DataGrid6.DataBind();
                               

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid7()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Rendre service'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                
                                DataGrid7.DataSource = dt;
                                DataGrid7.DataBind();
                                

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid8()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Alimentation'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                               
                                DataGrid8.DataSource = dt;
                                DataGrid8.DataBind();
                               

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid9()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Sujets de conversations'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                               
                                DataGrid9.DataSource = dt;
                                DataGrid9.DataBind();
                               

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid10()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Activités mentales'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                               
                                DataGrid10.DataSource = dt;
                                DataGrid10.DataBind();
                                

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid11()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='gouter à un plaisir simple'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                
                                DataGrid11.DataSource = dt;
                                DataGrid11.DataBind();
                               

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid12()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Spiritualité'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                
                                DataGrid12.DataSource = dt;
                                DataGrid12.DataBind();
                               

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid13()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Etre avec autres'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                               
                                DataGrid13.DataSource = dt;
                                DataGrid13.DataBind();
                                

                            }
                        }
                    }

                }
            }


        }


        protected void BindGrid14()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["Id"]) + "' AND activite.nature='Développer de nouvelles habiletés'"))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                
                                DataGrid14.DataSource = dt;
                                DataGrid14.DataBind();

                            }
                        }
                    }

                }
            }


        }





    }
}
