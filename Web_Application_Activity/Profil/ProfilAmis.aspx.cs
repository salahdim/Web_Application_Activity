using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
namespace Web_Application_Activity.Profil
{
    public partial class ProfilAmis : System.Web.UI.Page
    {

        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        String estActif;
        String queryStr;
        String queryStr1;
        String name;
        String nameAmi;
        String userName;
        String detail;
        String userNom;
        String firstName;
        String lastName;
        String email;
        String education;
        String localisation;
        String age;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (((String)Session["role"])!="admin") {
                    ButtonDesactiver.Visible = false;
                }
                name = (String)(Session["uname"]);
                if (name == null)
                {
                    Response.BufferOutput = true;
                    Response.Redirect("~/Login/LoginPage.aspx", false);
                }
                DoSQLImage();
                ProfilAmisNew();
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
                

                DoSQLQuery();

            }
        }


        private void BindGridskills()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("select * from skills where iduser='" + Session["IdAmis"] + "'"))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    con.Close();
                }
            }
        }
        private void ProfilAmisNew()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                nameAmi = null;
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.amis WHERE amis.idami='" + Session["IdAmis"] + "' AND amis.iduser='" + Session["Id"] + "' AND amis.accepte='true'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {

                    nameAmi = reader.GetString(reader.GetOrdinal("id"));

                }



                reader.Close();
                queryStr1 = "";
                queryStr1 = "SELECT * FROM database.amis WHERE amis.idami='" + Session["IdAmis"] + "' AND amis.iduser='" + Session["Id"] + "' AND amis.accepte='true'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
                reader = cmd.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {

                    nameAmi = reader.GetString(reader.GetOrdinal("id"));

                }


               

                reader.Close();
                if (nameAmi != null)
                {
                    ButtonAmis.Visible = false;
                }
                conn.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        protected void DesactiverCompte(object sender, EventArgs e)
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
            queryStr = "";
            queryStr = "update database.tbl_user set estActif='false' where id='" + Session["IdAmis"] + "';";
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.BufferOutput = true;
            Response.Redirect("~/Profil/ProfilAmis.aspx", false);
        }


        protected void ActiverCompte(object sender, EventArgs e)
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
            queryStr = "";
            queryStr = "update database.tbl_user set estActif='true' where id='" + Session["IdAmis"] + "';";
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.BufferOutput = true;
            Response.Redirect("~/Profil/ProfilAmis.aspx", false);
        }


        protected void UpdateNbrAmis(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
               
                    queryStr = "";
                    queryStr = "INSERT INTO database.amis (iduser,idami,accepte)VALUES('" + Session["Id"] + "','" + Session["IdAmis"] + "','false')";
                    MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                    cmd1.ExecuteNonQuery();

                    Response.BufferOutput = true;
                    Response.Redirect("~/Profil/ProfilAmis.aspx", false);
                

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private void DoSQLImage()
        {
            try
            {
                Image1.ImageUrl = "~/ShowImage.ashx?id=" + Session["IdAmis"];
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
                queryStr = "SELECT * FROM database.tbl_user WHERE tbl_user.id='" + Session["IdAmis"] + "'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                name = "";
                while (reader.HasRows && reader.Read())
                {
                    userName = reader.GetString(reader.GetOrdinal("lastname")) + " " +
                        reader.GetString(reader.GetOrdinal("firstname"));
                    userNom = reader.GetString(reader.GetOrdinal("username"));
                    firstName = reader.GetString(reader.GetOrdinal("firstname"));
                    lastName = reader.GetString(reader.GetOrdinal("lastname"));
                    email = reader.GetString(reader.GetOrdinal("email"));
                    age = reader.GetString(reader.GetOrdinal("age"));
                    education = reader.GetString(reader.GetOrdinal("education"));
                    localisation = reader.GetString(reader.GetOrdinal("localisation"));
                    detail = reader.GetString(reader.GetOrdinal("detail"));
                    estActif = reader.GetString(reader.GetOrdinal("estActif"));

                }

                if (reader.HasRows)
                {
                    Label14.Text = userName;
                    Label1.Text = userName;

                    LabelUname.Text = userNom;

                    LabelFirst.Text = firstName;

                    LabelLast.Text = lastName;

                    LabelEmail.Text = email;

                    LabelAge.Text = age;
                    LabelEducation.Text = education;
                    LabelLocation.Text = localisation;
                    LabelDetail.Text = detail;
                    if (estActif=="false") {
                        ButtonDesactiver.Visible = false;
                        ButtonActiver.Visible = true;
                    }
                    else
                    {
                        ButtonActiver.Visible = false;
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


        protected void BindGrid()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Sorties' "))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "'  AND activite.nature='Sports'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "'  AND activite.nature='Arts ou artisanat'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Travail, réparation, rénovation'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Jeux'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Lire et écrire'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Vêtements'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Rendre service'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Alimentation'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Sujets de conversations'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Activités mentales'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='gouter à un plaisir simple'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Spiritualité'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Etre avec autres'"))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.activite WHERE activite.iduser='" + (String)(Session["IdAmis"]) + "' AND activite.nature='Développer de nouvelles habiletés'"))
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