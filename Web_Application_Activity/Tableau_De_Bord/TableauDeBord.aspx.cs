using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity
{
    public partial class TableauDeBord : System.Web.UI.Page
    {

        String name;
        String userName;
        String userRole;
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        String queryStr;
        String z01;
        String v01;
        String z02;
        String v02;
        String z03;
        String v03;
        String z04;
        String v04;
        String z05;
        String v05;
        String z06;
        String v06;
        String z07;
        String v07;
        String z08;
        String v08;
        String z09;
        String v09;
        String z10;
        String v10;
        String titre;
        String lastmaj;

        protected void Page_Load(object sender, EventArgs e)
        {
            name = (String)(Session["uname"]);
            if (name == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Login/LoginPage.aspx", false);
            }

            userName = (String)(Session["utname"]);
            Label14.Text = userName;

            userRole = (String)(Session["urole"]);
            if (!Page.IsPostBack)
            {
                DoSQLQueryy();
                DoSQLImage();
            }

            if ((String)(Session["role"]) == "user")
            {
                Response.BufferOutput = true;
                Response.Redirect("~/ForgetLog/Lockscreen.aspx", false);
            }
            
            if ((String)(Session["role"]) == "admin" && (String)(Session["urole"]) == "0")
            {
                Response.BufferOutput = true;
                Response.Redirect("~/ForgetLog/Lockscreen.aspx", false);
            }
        }
        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("~/Login/LoginPage.aspx", false);


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
                v01 = "";
                z02 = "";
                v02 = "";
                z03 = "";
                v03 = "";
                z04 = "";
                v04 = "";
                z05 = "";
                v05 = "";
                z06 = "";
                v06 = "";
                z07 = "";
                v07 = "";
                z08 = "";
                v08 = "";
                z09 = "";
                v09 = "";
                z10 = "";
                v10 = "";
                titre = "";
                lastmaj = "";
                while (reader.HasRows && reader.Read())
                {
                    z01 = reader.GetString(reader.GetOrdinal("z01"));
                    v01 = reader.GetString(reader.GetOrdinal("v01"));
                    z02 = reader.GetString(reader.GetOrdinal("z02"));
                    v02 = reader.GetString(reader.GetOrdinal("v02"));
                    z03 = reader.GetString(reader.GetOrdinal("z03"));
                    v03 = reader.GetString(reader.GetOrdinal("v03"));
                    z04 = reader.GetString(reader.GetOrdinal("z04"));
                    v04 = reader.GetString(reader.GetOrdinal("v04"));
                    z05 = reader.GetString(reader.GetOrdinal("z05"));
                    v05 = reader.GetString(reader.GetOrdinal("v05"));
                    z06 = reader.GetString(reader.GetOrdinal("z06"));
                    v06 = reader.GetString(reader.GetOrdinal("v06"));
                    z07 = reader.GetString(reader.GetOrdinal("z07"));
                    v07 = reader.GetString(reader.GetOrdinal("v07"));
                    z08 = reader.GetString(reader.GetOrdinal("z08"));
                    v08 = reader.GetString(reader.GetOrdinal("v08"));
                    z09 = reader.GetString(reader.GetOrdinal("z09"));
                    v09 = reader.GetString(reader.GetOrdinal("v09"));
                    z10 = reader.GetString(reader.GetOrdinal("z10"));
                    v10 = reader.GetString(reader.GetOrdinal("v10"));
                    titre = reader.GetString(reader.GetOrdinal("titre"));
                    lastmaj = reader.GetString(reader.GetOrdinal("lastmaj"));

                }
                if (reader.HasRows)
                {
                    Label1.Text = lastmaj;
                    Label2.Text = titre;
                    Label3.Text = z01;
                    Label4.Text = z02;
                    Label5.Text = z03;
                    Label6.Text = z04;
                    Label7.Text = z05;
                    Label8.Text = z06;
                    Label9.Text = z07;
                    Label10.Text = z08;
                    Label11.Text = z09;
                    Label12.Text = z10;
                    Label15.Text = v01;
                    Label16.Text = v02;
                    Label17.Text = v03;
                    Label18.Text = v04;
                    Label19.Text = v05;
                    Label20.Text = v06;
                    Label21.Text = v07;
                    Label22.Text = v08;
                    Label23.Text = v09;
                    Label24.Text = v10;

                }

                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);

            }
        }



        private void DoSQLImage()
        {
            try
            {
                Image1.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];
                ImageDate.ImageUrl = "~/ShowImgTb.ashx?codeuser="+ Session["urole"] +"&numzone=DATE";
                ImageC11.ImageUrl = "~/ShowImgTb.ashx?codeuser=" + Session["urole"] + "&numzone=C11";
                ImageC12.ImageUrl = "~/ShowImgTb.ashx?codeuser=" + Session["urole"] + "&numzone=C12";
                ImageC21.ImageUrl = "~/ShowImgTb.ashx?codeuser=" + Session["urole"] + "&numzone=C21";
                ImageC22.ImageUrl = "~/ShowImgTb.ashx?codeuser=" + Session["urole"] + "&numzone=C22";
                ImageC31.ImageUrl = "~/ShowImgTb.ashx?codeuser=" + Session["urole"] + "&numzone=C31";
                ImageC32.ImageUrl = "~/ShowImgTb.ashx?codeuser=" + Session["urole"] + "&numzone=C32";
                ImageC41.ImageUrl = "~/ShowImgTb.ashx?codeuser=" + Session["urole"] + "&numzone=C41";
                ImageC42.ImageUrl = "~/ShowImgTb.ashx?codeuser=" + Session["urole"] + "&numzone=C42";
                ImageC51.ImageUrl = "~/ShowImgTb.ashx?codeuser=" + Session["urole"] + "&numzone=C51";
                ImageC52.ImageUrl = "~/ShowImgTb.ashx?codeuser=" + Session["urole"] + "&numzone=C52";


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}