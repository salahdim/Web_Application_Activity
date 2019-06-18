using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity.Charts
{
    public partial class ChartJs1 : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        String queryStr;
        public String Qteof;
        public String Coupe;
        public String Exped;
        public String Montage;
        public String Controle;
        public String Finition;
        public String Qtelivree;
        public String Qte2CH;
        public String Taux;
        String role;
        public String Qtexp;
        public String Qtedemand;
        public String CLIENT;
        public String MODELE;
        public String DatexpD;
        public String DatexpR;
        public String FactN;
        String name;

        protected void Page_Load(object sender, EventArgs e)
        {
       
           
            if ((String)(Session["urole"]) == "2")
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Charts/ChartJs.aspx", false);

            }
            if (Session["OfInterne"] == null)
            {
                Session["OfInterne"] = "fun15311";
            }

            if (Session["OfInterne1"] == null)
            {
                Session["OfInterne1"] = "FUN15331";
            }
            if (Session["TauxChoix"] == null)
            {
                Session["TauxChoix"] = "SPOT";
            }

            name = (String)(Session["uname"]);
                if (name == null)
                {
                    Response.BufferOutput = true;
                    Response.Redirect("~/Login/LoginPage.aspx", false);
                }
                role = (String)(Session["role"]);
                if (role == "user comptable")
                {
                    Response.BufferOutput = true;
                    Response.Redirect("~/ForgetLog/Lockscreen.aspx", false);
                }
                if (role == "user production")
                {
                    Response.BufferOutput = true;
                    Response.Redirect("~/ForgetLog/Lockscreen.aspx", false);
                }
                DoSQLQueryPie1();
                DoSQLQueryPie2();
                BindGridExpedies();
                BindGridSuiviProd();
                DoSQLQueryPie3();
                BindGridTauxChoix();
        }
        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["OfInterne"] = null;
            Session["OfInterne1"] = null;
            Session["TauxChoix"] = null;

            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("~/Login/LoginPage.aspx", false);


        }


        
        private void DoSQLQueryPie1()
                {
                    try
                    {
                        String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                        if ((String)(Session["urole"]) == "1")
                        {

                  
                             conn.Open();
                            queryStr = "";
                            queryStr = "SELECT * FROM database.detail WHERE detail.t1='"+ Session["OfInterne"] + "' AND detail.titre='Suivi Prod'";
                            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                            reader = cmd.ExecuteReader();

                            while (reader.HasRows && reader.Read())
                            {

                        Qteof = reader.GetString(reader.GetOrdinal("t2"));
                        Coupe = reader.GetString(reader.GetOrdinal("t3"));
                        Montage = reader.GetString(reader.GetOrdinal("t4"));
                        Controle = reader.GetString(reader.GetOrdinal("t5"));
                        Finition = reader.GetString(reader.GetOrdinal("t6"));
                        Exped = reader.GetString(reader.GetOrdinal("t7"));

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


        protected void UpdatePie(object sender, EventArgs e)
        {
            Session["OfInterne1"] = TextOfInterne.Text;
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs1.aspx", false);

        }
        protected void UpdatePie1(object sender, EventArgs e)
        {
            Session["OfInterne"] = TextOfInterne2.Text;
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs1.aspx", false);

        }
        protected void UpdatePie2(object sender, EventArgs e)
        {
            Session["TauxChoix"] = TextAtelier.Text;
            Response.BufferOutput = true;
            Response.Redirect("~/Charts/ChartJs1.aspx", false);

        }


        private void BindGridExpedies()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM detail WHERE detail.titre='OF Expedies'"))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    con.Close();
                }
            }
        }

        private void BindGridTauxChoix()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM detail WHERE detail.titre='Taux 2ieme Choix'"))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridView3.DataSource = cmd.ExecuteReader();
                    GridView3.DataBind();
                    con.Close();
                }
            }
        }


        private void BindGridSuiviProd()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM detail WHERE detail.titre='Suivi Prod'"))
                {
                    cmd.Connection = con;
                    con.Open();
                    GridView2.DataSource = cmd.ExecuteReader();
                    GridView2.DataBind();
                    con.Close();
                }
            }
        }



        private void DoSQLQueryPie2()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                if ((String)(Session["urole"]) == "1")
                {


                    conn.Open();
                    queryStr = "";
                    queryStr = "SELECT * FROM database.detail WHERE detail.t1='"+ Session["OfInterne1"] + "' AND detail.titre='OF Expedies'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {

                        CLIENT = reader.GetString(reader.GetOrdinal("t2"));
                        MODELE = reader.GetString(reader.GetOrdinal("t3"));
                        Qtedemand = reader.GetString(reader.GetOrdinal("t4"));
                        DatexpD = reader.GetString(reader.GetOrdinal("t5"));
                        DatexpR = reader.GetString(reader.GetOrdinal("t6"));
                        Qtexp = reader.GetString(reader.GetOrdinal("t7"));
                        FactN = reader.GetString(reader.GetOrdinal("t8"));

                    }
                    if (reader.HasRows)
                    {
                        LabelClient.Text = CLIENT;
                        LabelModele.Text = MODELE;
                        LabelDateExpD.Text = DatexpD;
                        LabelDateExpR.Text = DatexpR;
                        LabelFacture.Text = FactN;
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

        private void DoSQLQueryPie3()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                if ((String)(Session["urole"]) == "1")
                {


                    conn.Open();
                    queryStr = "";
                    queryStr = "SELECT * FROM database.detail WHERE detail.t1='" + Session["TauxChoix"] + "' AND detail.titre='Taux 2ieme Choix'";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.HasRows && reader.Read())
                    {

                        Qtelivree = reader.GetString(reader.GetOrdinal("t2"));
                        Qte2CH = reader.GetString(reader.GetOrdinal("t3"));
                        Taux = reader.GetString(reader.GetOrdinal("t4"));
                        

                    }
                    if (reader.HasRows)
                    {
                        LabelAtelier.Text = (String)Session["TauxChoix"];
                        LabelTaux.Text = Taux;
                       
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