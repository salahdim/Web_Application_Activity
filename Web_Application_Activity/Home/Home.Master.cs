using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace Web_Application_Activity
{
    public partial class Home : System.Web.UI.MasterPage
    {
        String userName;
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        public Int32 t20;
        public Int32 t21;
        public Int32 t22;
        public Int32 t23;
        public Int32 t24;
        public Int32 t25;
        public Int32 t26;
        public Int32 t27;
        public Int32 t28;
        public Int32 t29;
        public Int32 t30;
        public Int32 t31;
        public Int32 t32;
        public Int32 t33;
        public Int32 t34;
        public Int32 t35;
        public Int32 t36;
        public Int32 t37;
        public Int32 t38;
        public Int32 t39;
        public Int32 t40;
        public Int32 t41;
        public Int32 t42;
        public Int32 t43;
        public Int32 t44;
        public Int32 t45;
        public Int32 t46;
        public Int32 t47;
        public Int32 t48;
        public Int32 t49;
        public Int32 t50;
        public String groupe1S;
        public String groupe2S;
        public String groupe3S;
        public String groupe4S;
        public String atelierS;
        public String groupe1M;
        public String groupe2M;
        public String groupe3M;
        public String groupe4M;
        public String atelierM;

        String queryStr;
        protected void Page_Load(object sender, EventArgs e)
        {
            AffichageAreaChart();
            BindGrid();
            BindDemande();
            AffichageBarChart();
            DoSQLImage();
            LabelDetail.Text = (String)(Session["detail"]);
            userName = (String)(Session["utname"]);
            NomLabel1.Text = userName;
            NomLabel2.Text = userName;
        }



        protected void AddItem(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "INSERT INTO database.to_do (content,date,iduser,codeuser)VALUES('" + TextBoxItem.Text + "' ,'"+TextBoxDate.Text+"','" + Session["Id"] + "','" + Session["urole"] + "')";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                cmd.ExecuteNonQuery();

                Response.BufferOutput = true;
                Response.Redirect("~/Home/HomePage.aspx", false);

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }




        }

        protected void BindDemande()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.tbl_user WHERE tbl_user.id IN (SELECT iduser FROM database.amis WHERE amis.idami='"+ (String)(Session["Id"]) + "' AND amis.accepte='false' )"))
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

        private void AffichageAreaChart()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);


                conn.Open();
                queryStr = "";

                queryStr = "SELECT * FROM database.moy_age WHERE moy_age.id='1' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    t20 = reader.GetInt32(reader.GetOrdinal("t20"));
                    t21 = reader.GetInt32(reader.GetOrdinal("t21"));
                    t22 = reader.GetInt32(reader.GetOrdinal("t22"));
                    t23 = reader.GetInt32(reader.GetOrdinal("t23"));
                    t24 = reader.GetInt32(reader.GetOrdinal("t24"));
                    t25 = reader.GetInt32(reader.GetOrdinal("t25"));
                    t26 = reader.GetInt32(reader.GetOrdinal("t26"));
                    t27 = reader.GetInt32(reader.GetOrdinal("t27"));
                    t28 = reader.GetInt32(reader.GetOrdinal("t28"));
                    t29 = reader.GetInt32(reader.GetOrdinal("t29"));
                    t30 = reader.GetInt32(reader.GetOrdinal("t30"));
                    t31 = reader.GetInt32(reader.GetOrdinal("t31"));
                    t32 = reader.GetInt32(reader.GetOrdinal("t32"));
                    t33 = reader.GetInt32(reader.GetOrdinal("t33"));
                    t34 = reader.GetInt32(reader.GetOrdinal("t34"));
                    t35 = reader.GetInt32(reader.GetOrdinal("t35"));
                    t36 = reader.GetInt32(reader.GetOrdinal("t36"));
                    t37 = reader.GetInt32(reader.GetOrdinal("t37"));
                    t38 = reader.GetInt32(reader.GetOrdinal("t38"));
                    t39 = reader.GetInt32(reader.GetOrdinal("t39"));
                    t40 = reader.GetInt32(reader.GetOrdinal("t40"));
                    t41 = reader.GetInt32(reader.GetOrdinal("t41"));
                    t42 = reader.GetInt32(reader.GetOrdinal("t42"));
                    t43 = reader.GetInt32(reader.GetOrdinal("t43"));
                    t44 = reader.GetInt32(reader.GetOrdinal("t44"));
                    t45 = reader.GetInt32(reader.GetOrdinal("t45"));
                    t46 = reader.GetInt32(reader.GetOrdinal("t46"));
                    t47 = reader.GetInt32(reader.GetOrdinal("t47"));
                    t48 = reader.GetInt32(reader.GetOrdinal("t48"));
                    t49 = reader.GetInt32(reader.GetOrdinal("t49"));
                    t50 = reader.GetInt32(reader.GetOrdinal("t50"));

                }



                reader.Close();
                conn.Close();

            }catch(Exception e)
            {
                Console.WriteLine(e);

            }
        }
        private void AffichageBarChart()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);


                conn.Open();
                queryStr = "";

                queryStr = "SELECT * FROM database.groupe_salaire WHERE groupe_salaire.id='1' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    groupe1S = reader.GetString(reader.GetOrdinal("salaire_groupe1"));
                    groupe2S = reader.GetString(reader.GetOrdinal("salaire_groupe2"));
                    groupe3S = reader.GetString(reader.GetOrdinal("salaire_groupe3"));
                    groupe4S = reader.GetString(reader.GetOrdinal("salaire_groupe4"));
                    atelierS = reader.GetString(reader.GetOrdinal("salaire_atelier_echantillon"));
                    groupe1M = reader.GetString(reader.GetOrdinal("min_produite_groupe1"));
                    groupe2M = reader.GetString(reader.GetOrdinal("min_produite_groupe2"));
                    groupe3M = reader.GetString(reader.GetOrdinal("min_produite_groupe3"));
                    groupe4M = reader.GetString(reader.GetOrdinal("min_produite_groupe4"));
                    atelierM = reader.GetString(reader.GetOrdinal("min_produite_atelier_echantillon"));
        
                    
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.to_do WHERE to_do.iduser='" + (String)(Session["Id"]) + "' "))
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

        protected void maGrille_ItemDemande(object sender, DataGridCommandEventArgs e)
        {
            Session["IndexDemande"] = e.Item.Cells[0].Text;

            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "update database.amis set accepte='true' where amis.idami='" + Session["Id"] + "' AND amis.iduser='"+ (String)(Session["IndexDemande"]) + "';";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Response.BufferOutput = true;
            Response.Redirect("~/Home/HomePage.aspx", false);
        }



        protected void maGrille_ItemCommand(object sender, DataGridCommandEventArgs e)
        {
            Session["IndexTodo"] = e.Item.Cells[0].Text;

            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "DELETE FROM database.to_do WHERE id='" + Session["IndexTodo"] + "' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Response.BufferOutput = true;
            Response.Redirect("~/Home/HomePage.aspx", false);
        }

        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("LoginPage.aspx", false);


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

    }
}