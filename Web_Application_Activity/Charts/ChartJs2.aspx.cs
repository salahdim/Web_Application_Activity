using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace Web_Application_Activity.Charts
{
    public partial class ChartJs2 : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        String queryStr;
        String queryStr1;
        String client;
        String fournisseur;
        public String January;
        public String February;
        public String March;
        public String April;
        public String May;
        public String June;
        public String July;
        public String August;
        public String September;
        public String October;
        public String November;
        public String December;
        public String Januar;
        public String Februar;
        public String Marc;
        public String Apri;
        public String Ma;
        public String Jun;
        public String Jul;
        public String Augus;
        public String Septembe;
        public String Octobe;
        public String Novembe;
        public String Decembe;
        public String Credit;
        public String Debit;
        public String Solde;
        public String CreditF;
        public String DebitF;
        public String SoldeF;
        public Int32 Credit1;
        public Int32 Debit1;
        public Int32 Solde1;
        public Int32 CreditF1;
        public Int32 DebitF1;
        public Int32 SoldeF1;
        public Int32 STB;
        public Int32 BIATD;
        public Int32 BIATE;
        String role;
        String name;
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelAnn1.Text = (String)(Session["Ann1"]);
            LabelAnn2.Text = (String)(Session["Ann2"]);
            LabelBarClient.Text = (String)(Session["AnnBarClient"]);
            LabelBarFournisseur.Text = (String)(Session["AnnBarFournisseur"]);
            LabelPieClient.Text = (String)(Session["AnnPieClient"]);
            LabelPieFournisseur.Text = (String)(Session["AnnPieFournisseur"]);
            if (Session["Ann1"] == null && Session["Ann2"] == null)
            {
                Session["Ann1"] = "2015";
                Session["Ann2"] = "2016";
            }
            if (Session["AnnBarClient"] == null)
            {
                Session["AnnBarClient"] = "GEMATEX";
            }
            if (Session["AnnBarFournisseur"] == null)
            {
                Session["AnnBarFournisseur"] = "PERSOVET";
            }
            if (Session["AnnPieClient"] == null)
            {
                Session["AnnPieClient"] = "GEMATEX";
            }
            if (Session["AnnPieFournisseur"] == null)
            {
                Session["AnnPieFournisseur"] = "PERSOVET";
            }
            name = (String)(Session["uname"]);
            if (name == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Login/LoginPage.aspx", false);
            }
            role = (String)(Session["role"]);
            if (role == "user")
            {
                Response.BufferOutput = true;
                Response.Redirect("~/ForgetLog/Lockscreen.aspx", false);
            }
            DoSQLQueryArea();
            DoSQLQueryBarClient();
            DoSQLQueryBarFournisseur();
            DoSQLQueryPieClient();
            DoSQLQueryPieFournisseur();
            DoSQLQueryPieBanque();
            BindGridBarClient();
            BindGridBarFournisseur();
            BindGridPieClient();
            BindGridPieFournisseur();

        }


        protected void UpdateArea(object sender, EventArgs e)
        {
            Session["Ann1"] = TextAnn1.Text;
            Session["Ann2"] = TextAnn2.Text;
            LabelAnn1.Text = (String)(Session["Ann1"]);
            LabelAnn2.Text = (String)(Session["Ann2"]);
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs2.aspx", false);

        }


        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("~/Login/LoginPage.aspx", false);


        }


        private void DoSQLQueryBarClient()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);



                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.detail WHERE detail.t1='" + Session["AnnBarClient"] + "' AND detail.titre='Solde clients'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {

                    client = reader.GetString(reader.GetOrdinal("t1"));
                    Debit = reader.GetString(reader.GetOrdinal("t2"));
                    Credit = reader.GetString(reader.GetOrdinal("t3"));
                    Solde = reader.GetString(reader.GetOrdinal("t4"));


                }



                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        private void BindGridBarClient()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM detail WHERE detail.titre='Solde clients'"))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridViewbarClient.DataSource = cmd.ExecuteReader();
                    GridViewbarClient.DataBind();
                    con.Close();
                }
            }
        }

        private void BindGridBarFournisseur()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM detail WHERE detail.titre='Solde fournisseurs'"))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridViewbarFournisseur.DataSource = cmd.ExecuteReader();
                    GridViewbarFournisseur.DataBind();
                    con.Close();
                }
            }
        }

        private void BindGridPieClient()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM detail WHERE detail.titre='Solde clients'"))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridViewpieClient.DataSource = cmd.ExecuteReader();
                    GridViewpieClient.DataBind();
                    con.Close();
                }
            }
        }
        private void BindGridPieFournisseur()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM detail WHERE detail.titre='Solde fournisseurs'"))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridViewpieFournisseur.DataSource = cmd.ExecuteReader();
                    GridViewpieFournisseur.DataBind();
                    con.Close();
                }
            }
        }


        private void DoSQLQueryBarFournisseur()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);



                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.detail WHERE detail.t1='" + Session["AnnBarFournisseur"] + "' AND detail.titre='Solde fournisseurs'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {

                    fournisseur = reader.GetString(reader.GetOrdinal("t1"));
                    DebitF = reader.GetString(reader.GetOrdinal("t2"));
                    CreditF = reader.GetString(reader.GetOrdinal("t3"));
                    SoldeF = reader.GetString(reader.GetOrdinal("t4"));


                }


                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        protected void UpdateBarClient(object sender, EventArgs e)
        {
            Session["AnnBarClient"] = TextBarClient.Text;
            LabelBarClient.Text = (String)(Session["AnnBarClient"]);
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs2.aspx", false);

        }
        protected void UpdateBarFournisseur(object sender, EventArgs e)
        {
            Session["AnnBarFournisseur"] = TextBarFournisseur.Text;
            LabelBarFournisseur.Text = (String)(Session["AnnBarFournisseur"]);
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs2.aspx", false);

        }

        private void DoSQLQueryArea()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                
                    //   LabelChiffre1.Text = "Les chiffres d'affaire";
                    LabelChiffre2.Text = "chiffre d'affaire";
                    LabelChiffre3.Text = "Les chiffres d'affaire";
                    conn.Open();
                    queryStr = "";

                    queryStr = "SELECT * FROM database.detail WHERE detail.t13='" + Session["Ann1"] + "' AND detail.titre='CA' ";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {
                        January = reader.GetString(reader.GetOrdinal("t1"));
                        February = reader.GetString(reader.GetOrdinal("t2"));
                        March = reader.GetString(reader.GetOrdinal("t3"));
                        April = reader.GetString(reader.GetOrdinal("t4"));
                        May = reader.GetString(reader.GetOrdinal("t5"));
                        June = reader.GetString(reader.GetOrdinal("t6"));
                        July = reader.GetString(reader.GetOrdinal("t7"));
                        August = reader.GetString(reader.GetOrdinal("t8"));
                        September = reader.GetString(reader.GetOrdinal("t9"));
                        October = reader.GetString(reader.GetOrdinal("t10"));
                        November = reader.GetString(reader.GetOrdinal("t11"));
                        December = reader.GetString(reader.GetOrdinal("t12"));

                    }



                    reader.Close();

                    queryStr1 = "";
                    queryStr1 = "SELECT * FROM database.detail WHERE detail.t13='" + Session["Ann2"] + "' AND detail.titre='CA'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {
                        Januar = reader.GetString(reader.GetOrdinal("t1"));
                        Februar = reader.GetString(reader.GetOrdinal("t2"));
                        Marc = reader.GetString(reader.GetOrdinal("t3"));
                        Apri = reader.GetString(reader.GetOrdinal("t4"));
                        Ma = reader.GetString(reader.GetOrdinal("t5"));
                        Jun = reader.GetString(reader.GetOrdinal("t6"));
                        Jul = reader.GetString(reader.GetOrdinal("t7"));
                        Augus = reader.GetString(reader.GetOrdinal("t8"));
                        Septembe = reader.GetString(reader.GetOrdinal("t9"));
                        Octobe = reader.GetString(reader.GetOrdinal("t10"));
                        Novembe = reader.GetString(reader.GetOrdinal("t11"));
                        Decembe = reader.GetString(reader.GetOrdinal("t12"));

                    }



                    reader.Close();
                    conn.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void DoSQLQueryPieClient()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                
                  

                    conn.Open();
                    queryStr = "";
                    queryStr = "SELECT * FROM database.detail WHERE detail.t1='" + Session["AnnPieClient"] + "' AND detail.titre='Solde clients'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {

                        client = reader.GetString(reader.GetOrdinal("t1"));
                        Debit1 = reader.GetInt32(reader.GetOrdinal("t2"));
                        Credit1 = reader.GetInt32(reader.GetOrdinal("t3"));
                        Solde1 = reader.GetInt32(reader.GetOrdinal("t4"));


                    }



                    reader.Close();
                    conn.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void DoSQLQueryPieFournisseur()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);



                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.detail WHERE detail.t1='" + Session["AnnPieFournisseur"] + "' AND detail.titre='Solde fournisseurs'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {

                    fournisseur = reader.GetString(reader.GetOrdinal("t1"));
                    DebitF1 = reader.GetInt32(reader.GetOrdinal("t2"));
                    CreditF1 = reader.GetInt32(reader.GetOrdinal("t3"));
                    SoldeF1 = reader.GetInt32(reader.GetOrdinal("t4"));


                }



                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void DoSQLQueryPieBanque()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);



                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.detail WHERE detail.titre='Solde banque'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {

                    BIATD = reader.GetInt32(reader.GetOrdinal("t1"));
                    BIATE = reader.GetInt32(reader.GetOrdinal("t2"));
                    STB = reader.GetInt32(reader.GetOrdinal("t3"));


                }



                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        protected void UpdatePieClient(object sender, EventArgs e)
        {
            Session["AnnPieClient"] = TextPieClient.Text;
            TextPieClient.Text = (String)(Session["AnnPieClient"]);
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs2.aspx", false);

        }
        protected void UpdatePieFournisseur(object sender, EventArgs e)
        {
            Session["AnnPieFournisseur"] = TextPieFournisseur.Text;
            TextPieFournisseur.Text = (String)(Session["AnnPieFournisseur"]);
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs2.aspx", false);

        }

    }
}