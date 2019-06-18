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
    public partial class ChartJs : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        String queryStr;
        String queryStr1;
        String role;
        public String Banque1;
        public String Banque2;
        public String Cheque;
        public String Caisse;

        public String Liquidites;
        public String stocks;
        public String Fonds;
        public String meubles;
        public String immeubles;
        public String Total;

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
        public String t1;
        public String t2;
        public String t3;
        public String t4;
        public String t5;
        public String t6;
        public String t7;
        public String t8;
        public String t9;
        public String t10;
        public String t11;
        public String t12;
        public String tt1;
        public String tt2;
        public String tt3;
        public String tt4;
        public String tt5;
        public String tt6;
        public String tt7;
        public String tt8;
        public String tt9;
        public String tt10;
        public String tt11;
        public String tt12;
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
        public String a1;
        public String a2;
        public String a3;
        public String a4;
        public String a5;
        public String January1;
        public String February1;
        public String March1;
        public String April1;
        public String May1;
        public String June1;
        public String July1;
        public String August1;
        public String September1;
        public String October1;
        public String November1;
        public String December1;
        public String Januar1;
        public String Februar1;
        public String Marc1;
        public String Apri1;
        public String Ma1;
        public String Jun1;
        public String Jul1;
        public String Augus1;
        public String Septembe1;
        public String Octobe1;
        public String Novembe1;
        public String Decembe1;
        public String January2;
        public String February2;
        public String March2;
        public String April2;
        public String May2;
        public String June2;
        public String July2;
        public String August2;
        public String September2;
        public String October2;
        public String November2;
        public String December2;
        public String Januar2;
        public String Februar2;
        public String Marc2;
        public String Apri2;
        public String Ma2;
        public String Jun2;
        public String Jul2;
        public String Augus2;
        public String Septembe2;
        public String Octobe2;
        public String Novembe2;
        public String Decembe2;
        String name;

        protected void Page_Load(object sender, EventArgs e)
        {
            LabelAnn1.Text = (String)(Session["Ann1"]);
            LabelAnn2.Text = (String)(Session["Ann2"]);
            LabelAnn3.Text = (String)(Session["Ann3"]);
            LabelAnn4.Text = (String)(Session["Ann4"]);
            LabelAnn5.Text = (String)(Session["Ann5"]);
            LabelAnn6.Text = (String)(Session["Ann6"]);
            if ((String)(Session["urole"]) == "2") { 
                LabelAnn7.Text = (String)(Session["Ann7"]);
            }
            if ((String)(Session["urole"]) == "1")
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Charts/Chartjs1.aspx", false);

            }
            if ((String)(Session["urole"]) == "3")
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Charts/Chartjs2.aspx", false);

            }
            if (Session["Ann1"]==null && Session["Ann2"]==null) { 
            Session["Ann1"] = "2015";
            Session["Ann2"] = "2016";
                

            }
            if (Session["Ann7"] == null)
            {
                Session["Ann7"] = "2015";


            }
            
            if (Session["Ann3"] == null )
            {
                Session["Ann3"] = "2015";


            }
            if (Session["Ann5"] == null)
            {
                Session["Ann5"] = "2015";


            }
            if (Session["Ann6"] == null)
            {
                Session["Ann6"] = "2015";


            }
            if (Session["Ann4"] == null)
            {
                Session["Ann4"] = "2015";


            }
            name = (String)(Session["uname"]);
            if (name == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Login/LoginPage.aspx", false);
            }
            role = (String)(Session["role"]);
            if (role== "user") {
                Response.BufferOutput = true;
                Response.Redirect("~/ForgetLog/Lockscreen.aspx", false);
            }
           
            DoSQLQueryBar2();
            DoSQLQueryLine();
             DoSQLQueryArea();
            DoSQLQueryBar();
            DoSQLQueryPie1();
            DoSQLQueryPie2();

        }

        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("~/Login/LoginPage.aspx", false);


        }
       
        private void DoSQLQueryBar()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                if ((String)(Session["urole"]) == "2" )
                {
                    LabelChiffre8.Text = "Chiffre d'affaire";
                    LabelChiffre9.Text = "Les Chiffres d'affaire";
                    LabelPiece1.Text = "Nembre des piéces";
                    LabelPiece2.Text = "Nembre des piéces";
                    conn.Open();
                    queryStr = "";
                    queryStr = "SELECT * FROM database.detail WHERE detail.t13='" + Session["Ann3"] + "' AND detail.titre='CA'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {

                        January1 = reader.GetString(reader.GetOrdinal("t1"));
                        February1 = reader.GetString(reader.GetOrdinal("t2"));
                        March1 = reader.GetString(reader.GetOrdinal("t3"));
                        April1 = reader.GetString(reader.GetOrdinal("t4"));
                        May1 = reader.GetString(reader.GetOrdinal("t5"));
                        June1 = reader.GetString(reader.GetOrdinal("t6"));
                        July1 = reader.GetString(reader.GetOrdinal("t7"));
                        August1 = reader.GetString(reader.GetOrdinal("t8"));
                        September1 = reader.GetString(reader.GetOrdinal("t9"));
                        October1 = reader.GetString(reader.GetOrdinal("t10"));
                        November1 = reader.GetString(reader.GetOrdinal("t11"));
                        December1 = reader.GetString(reader.GetOrdinal("t12"));

                    }



                    reader.Close();

                    queryStr1 = "";
                    queryStr1 = "SELECT * FROM database.detail WHERE detail.t13='" + Session["Ann3"] + "' AND detail.titre='piece'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {
                        Januar1 = reader.GetString(reader.GetOrdinal("t1"));
                        Februar1 = reader.GetString(reader.GetOrdinal("t2"));
                        Marc1 = reader.GetString(reader.GetOrdinal("t3"));
                        Apri1 = reader.GetString(reader.GetOrdinal("t4"));
                        Ma1 = reader.GetString(reader.GetOrdinal("t5"));
                        Jun1 = reader.GetString(reader.GetOrdinal("t6"));
                        Jul1 = reader.GetString(reader.GetOrdinal("t7"));
                        Augus1 = reader.GetString(reader.GetOrdinal("t8"));
                        Septembe1 = reader.GetString(reader.GetOrdinal("t9"));
                        Octobe1 = reader.GetString(reader.GetOrdinal("t10"));
                        Novembe1 = reader.GetString(reader.GetOrdinal("t11"));
                        Decembe1 = reader.GetString(reader.GetOrdinal("t12"));

                    }
                    if (reader.HasRows)
                    {

                    }


                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        private void DoSQLQueryPie1()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                if ((String)(Session["urole"]) == "2")
                {
                    LabelTresorerie1.Text = "Tresorerie";
                    LabelTresorerie2.Text = "Tresorerie";

                    conn.Open();
                    queryStr = "";
                    queryStr = "SELECT * FROM database.detail WHERE detail.t13='" + Session["Ann6"] + "' AND detail.titre='Tresorerie'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {

                        Banque1 = reader.GetString(reader.GetOrdinal("t1"));
                        Banque2 = reader.GetString(reader.GetOrdinal("t2"));
                        Cheque = reader.GetString(reader.GetOrdinal("t3"));
                        Caisse = reader.GetString(reader.GetOrdinal("t4"));


                    }



                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void DoSQLQueryPie2()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                if ((String)(Session["urole"]) == "2" )
                {
                    LabelActif1.Text = "Total Actif";
                    LabelActif2.Text = "Total Actif";
                    a1 = "Liquidites";
                    a2 = "Creances et stocks";
                    a3 = "Fonds places";
                    a4 = "Immobilisations meubles";
                    a5 = "Immobilisations immeubles";

                    conn.Open();
                    queryStr = "";
                    queryStr = "SELECT * FROM database.detail WHERE detail.t13='" + Session["Ann7"] + "' AND detail.titre='Total Actifs'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {

                        Liquidites = reader.GetString(reader.GetOrdinal("t1"));
                        stocks = reader.GetString(reader.GetOrdinal("t2"));
                        Fonds = reader.GetString(reader.GetOrdinal("t3"));
                        meubles = reader.GetString(reader.GetOrdinal("t4"));
                        immeubles = reader.GetString(reader.GetOrdinal("t5"));
                        Total = reader.GetString(reader.GetOrdinal("t6"));
                    }
                    if (reader.HasRows)
                    {

                        LabelTotal.Text = Total;
                    }

                        reader.Close();
                    conn.Close();
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void DoSQLQueryLine()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                if ((String)(Session["urole"]) == "2")
                {
                    LabelChiffre6.Text = "chiffre d'affaire";
                    LabelChiffre7.Text = "Les chiffres d'affaire";
                    LabelMasse1.Text = "Masse Salaire";
                    LabelMasse2.Text = "Masse Salaire";

                    conn.Open();
                    queryStr = "";

                    queryStr = "SELECT * FROM database.detail WHERE detail.t13='" + Session["Ann5"] + "' AND detail.titre='CA'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {
                        t1 = reader.GetString(reader.GetOrdinal("t1"));
                        t2 = reader.GetString(reader.GetOrdinal("t2"));
                        t3 = reader.GetString(reader.GetOrdinal("t3"));
                        t4 = reader.GetString(reader.GetOrdinal("t4"));
                        t5 = reader.GetString(reader.GetOrdinal("t5"));
                        t6 = reader.GetString(reader.GetOrdinal("t6"));
                        t7 = reader.GetString(reader.GetOrdinal("t7"));
                        t8 = reader.GetString(reader.GetOrdinal("t8"));
                        t9 = reader.GetString(reader.GetOrdinal("t9"));
                        t10 = reader.GetString(reader.GetOrdinal("t10"));
                        t11 = reader.GetString(reader.GetOrdinal("t11"));
                        t12 = reader.GetString(reader.GetOrdinal("t12"));

                    }



                    reader.Close();

                    queryStr1 = "";
                    queryStr1 = "SELECT * FROM database.detail WHERE detail.t13='" + Session["Ann5"] + "' AND detail.titre='Masse Salaire'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {
                        tt1 = reader.GetString(reader.GetOrdinal("t1"));
                        tt2 = reader.GetString(reader.GetOrdinal("t2"));
                        tt3 = reader.GetString(reader.GetOrdinal("t3"));
                        tt4 = reader.GetString(reader.GetOrdinal("t4"));
                        tt5 = reader.GetString(reader.GetOrdinal("t5"));
                        tt6 = reader.GetString(reader.GetOrdinal("t6"));
                        tt7 = reader.GetString(reader.GetOrdinal("t7"));
                        tt8 = reader.GetString(reader.GetOrdinal("t8"));
                        tt9 = reader.GetString(reader.GetOrdinal("t9"));
                        tt10 = reader.GetString(reader.GetOrdinal("t10"));
                        tt11 = reader.GetString(reader.GetOrdinal("t11"));
                        tt12 = reader.GetString(reader.GetOrdinal("t12"));

                    }



                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void DoSQLQueryBar2()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                if ((String)(Session["urole"]) == "2")
                {
                    LabelChiffre4.Text = "chiffre d'affaire";
                    LabelChiffre5.Text = "Les chiffres d'affaires";
                    LabelAchat1.Text = "Achat";
                    LabelAchat2.Text = "Achat";
                    conn.Open();
                    queryStr = "";
                    queryStr = "SELECT * FROM database.detail WHERE detail.t13='" + Session["Ann4"] + "' AND detail.titre='CA'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {

                        January2 = reader.GetString(reader.GetOrdinal("t1"));
                        February2 = reader.GetString(reader.GetOrdinal("t2"));
                        March2 = reader.GetString(reader.GetOrdinal("t3"));
                        April2 = reader.GetString(reader.GetOrdinal("t4"));
                        May2 = reader.GetString(reader.GetOrdinal("t5"));
                        June2 = reader.GetString(reader.GetOrdinal("t6"));
                        July2 = reader.GetString(reader.GetOrdinal("t7"));
                        August2 = reader.GetString(reader.GetOrdinal("t8"));
                        September2 = reader.GetString(reader.GetOrdinal("t9"));
                        October2 = reader.GetString(reader.GetOrdinal("t10"));
                        November2 = reader.GetString(reader.GetOrdinal("t11"));
                        December2 = reader.GetString(reader.GetOrdinal("t12"));

                    }



                    reader.Close();

                    queryStr1 = "";
                    queryStr1 = "SELECT * FROM database.detail WHERE detail.t13='" + Session["Ann4"] + "' AND detail.titre='Achat'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {
                        Januar2 = reader.GetString(reader.GetOrdinal("t1"));
                        Februar2 = reader.GetString(reader.GetOrdinal("t2"));
                        Marc2 = reader.GetString(reader.GetOrdinal("t3"));
                        Apri2 = reader.GetString(reader.GetOrdinal("t4"));
                        Ma2 = reader.GetString(reader.GetOrdinal("t5"));
                        Jun2 = reader.GetString(reader.GetOrdinal("t6"));
                        Jul2 = reader.GetString(reader.GetOrdinal("t7"));
                        Augus2 = reader.GetString(reader.GetOrdinal("t8"));
                        Septembe2 = reader.GetString(reader.GetOrdinal("t9"));
                        Octobe2 = reader.GetString(reader.GetOrdinal("t10"));
                        Novembe2 = reader.GetString(reader.GetOrdinal("t11"));
                        Decembe2 = reader.GetString(reader.GetOrdinal("t12"));

                    }
                    if (reader.HasRows)
                    {

                    }


                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        protected void UpdateArea(object sender, EventArgs e)
        {
            Session["Ann1"] = TextAnn1.Text;
            Session["Ann2"] = TextAnn2.Text;
            LabelAnn1.Text = (String)(Session["Ann1"]);
            LabelAnn2.Text = (String)(Session["Ann2"]);
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs.aspx", false);

        }

        protected void UpdateBar(object sender, EventArgs e)
        {
            Session["Ann3"] = TextAnn3.Text;
            LabelAnn3.Text = (String)(Session["Ann3"]);
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs.aspx", false);

        }
        protected void UpdateLine(object sender, EventArgs e)
        {
            Session["Ann5"] = TextAnneeLine.Text;
            LabelAnn5.Text = (String)(Session["Ann5"]);
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs.aspx", false);

        }
        protected void UpdateBar2(object sender, EventArgs e)
        {
            Session["Ann4"] = TextAnn4.Text;
            LabelAnn4.Text = (String)(Session["Ann4"]);
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs.aspx", false);

        }
        protected void UpdatePie1(object sender, EventArgs e)
        {
            Session["Ann6"] = TextAnn6.Text;
            LabelAnn6.Text = (String)(Session["Ann6"]);
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs.aspx", false);

        }
        protected void UpdatePie2(object sender, EventArgs e)
        {
            if ((String)(Session["urole"]) == "2") { 
                Session["Ann7"] = TextAnn7.Text;
            LabelAnn7.Text = (String)(Session["Ann7"]);
            }
            
                Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs.aspx", false);

        }


        private void DoSQLQueryArea()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                if ((String)(Session["urole"]) == "2" )
                {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



    }
}