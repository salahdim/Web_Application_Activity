using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
namespace Web_Application_Activity.Tableau_De_Bord
{
    public partial class Z09 : System.Web.UI.Page
    {
        String name;
        String userName;
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        String queryStr;
        String z01;
        String z02;
        String z03;
        String z04;
        String z05;
        String z06;
        String z07;
        String z08;
        public String z09;
        public String secteur;
        String ucode;
        String z10;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = (String)(Session["uname"]);
            if (name == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Login/LoginPage.aspx", false);
            }
            ucode = (String)(Session["urole"]);
            if (ucode == "1")
            {
                secteur = "Departement Technique";
            }
            if (ucode == "2")
            {
                secteur = "Departement Financier";
            }
            if (ucode == "3")
            {
                secteur = "Departement Commercial";
            }
            userName = (String)(Session["utname"]);
            Label14.Text = userName;

            if (!Page.IsPostBack)
            {
                DoSQLImage();
                DoSQLQueryy();

                BindData();

            }
        }

        protected void BindData()
        {

            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.titre WHERE titre.codeuser='" + Session["urole"] + "' AND titre.numzone='C51' UNION SELECT * FROM database.detail WHERE detail.codeuser='" + Session["urole"] + "' AND detail.numzone='C51' "))
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


        private void DoSQLQueryy()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.tb WHERE tb.codeuser='" + Session["urole"] + "'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                z01 = "";
                z02 = "";
                z03 = "";
                z04 = "";
                z05 = "";
                z06 = "";
                z07 = "";
                z08 = "";
                z09 = "";
                z10 = "";
                while (reader.HasRows && reader.Read())
                {
                    z01 = reader.GetString(reader.GetOrdinal("z01"));
                    z02 = reader.GetString(reader.GetOrdinal("z02"));
                    z03 = reader.GetString(reader.GetOrdinal("z03"));
                    z04 = reader.GetString(reader.GetOrdinal("z04"));
                    z05 = reader.GetString(reader.GetOrdinal("z05"));
                    z06 = reader.GetString(reader.GetOrdinal("z06"));
                    z07 = reader.GetString(reader.GetOrdinal("z07"));
                    z08 = reader.GetString(reader.GetOrdinal("z08"));
                    z09 = reader.GetString(reader.GetOrdinal("z09"));
                    z10 = reader.GetString(reader.GetOrdinal("z10"));

                }
                if (reader.HasRows)
                {
                    LabelT1.Text = z01;
                    LabelT2.Text = z02;
                    LabelT3.Text = z03;
                    LabelT4.Text = z04;
                    LabelT5.Text = z05;
                    LabelT6.Text = z06;
                    LabelT7.Text = z07;
                    LabelT8.Text = z08;
                    LabelT9.Text = z09;
                    LabelT10.Text = z10;
                    LabelZ09.Text = z09;


                }

                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);

            }
        }


        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("~/Login/LoginPage.aspx", false);


        }


        protected void Grid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            DataGrid9.CurrentPageIndex = e.NewPageIndex;
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.titre WHERE titre.codeuser=" + Session["urole"] + " AND titre.numzone='C51' UNION SELECT * FROM database.detail WHERE detail.codeuser=" + Session["urole"] + " AND detail.numzone='C51' "))
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

        private void DoSQLImage()
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