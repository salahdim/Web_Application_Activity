using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
namespace Web_Application_Activity.Calendar
{
    public partial class Calendar : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlCommand cmd2;
        MySql.Data.MySqlClient.MySqlCommand cmd3;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        String queryStr1;
        String queryStr3;
        String queryStr;
        String name;
        Int32 value=0;
        public String namec;
        public Int32 monthstart;
        public Int32 yearstart;
        public Int32 daystart;
        public Int32 yearend;
        public Int32 monthend;
        public Int32 dayend;
        public Int32 hstart;
        public Int32 hend;
        public Int32 minstart;
        public Int32 minend;
        public String namec1;
        public Int32 monthstart1;
        public Int32 yearstart1;
        public Int32 daystart1;
        public Int32 yearend1;
        public Int32 monthend1;
        public Int32 dayend1;
        public Int32 hstart1;
        public Int32 hend1;
        public Int32 minstart1;
        public Int32 minend1;
        public String namec2;
        public Int32 monthstart2;
        public Int32 yearstart2;
        public Int32 daystart2;
        public Int32 yearend2;
        public Int32 monthend2;
        public Int32 dayend2;
        public Int32 hstart2;
        public Int32 hend2;
        public Int32 minstart2;
        public Int32 minend2;
        public String namec3;
        public Int32 monthstart3;
        public Int32 yearstart3;
        public Int32 daystart3;
        public Int32 yearend3;
        public Int32 monthend3;
        public Int32 dayend3;
        public Int32 hstart3;
        public Int32 hend3;
        public Int32 minstart3;
        public Int32 minend3;
        public String namec4;
        public Int32 monthstart4;
        public Int32 yearstart4;
        public Int32 daystart4;
        public Int32 yearend4;
        public Int32 monthend4;
        public Int32 dayend4;
        public Int32 hstart4;
        public Int32 hend4;
        public Int32 minstart4;
        public Int32 minend4;
  
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
                DoSQLAffiche();
                DoSQLAffiche1();
                DoSQLAffiche2();
                DoSQLAffiche3();
                DoSQLAffiche4();
                DoSQLImage();
                Label1.Text = ((String)Session["nom"]);
            }
        }

        private void DoSQLAffiche()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.event WHERE event.iduser='" + Session["Id"] + "' AND event.idex='1'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
              
                while (reader.HasRows && reader.Read())
                {
                    namec= reader.GetString(reader.GetOrdinal("name"));
            monthstart = reader.GetInt32(reader.GetOrdinal("monthstart"));
             yearstart = reader.GetInt32(reader.GetOrdinal("yearstart"));
            daystart = reader.GetInt32(reader.GetOrdinal("daystart"));
            yearend = reader.GetInt32(reader.GetOrdinal("yearend"));
          monthend = reader.GetInt32(reader.GetOrdinal("monthend"));
          dayend = reader.GetInt32(reader.GetOrdinal("dayend"));
          hstart = reader.GetInt32(reader.GetOrdinal("hstart"));
          hend = reader.GetInt32(reader.GetOrdinal("hend"));
          minstart = reader.GetInt32(reader.GetOrdinal("minstart"));
        minend = reader.GetInt32(reader.GetOrdinal("minend"));

                }
                Labelnamec.Text = namec;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            reader.Close();
            conn.Close();
        }

        private void DoSQLAffiche4()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.event WHERE event.iduser='" + Session["Id"] + "' AND event.idex='5'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    namec4 = reader.GetString(reader.GetOrdinal("name"));
                    monthstart4 = reader.GetInt32(reader.GetOrdinal("monthstart"));
                    yearstart4 = reader.GetInt32(reader.GetOrdinal("yearstart"));
                    daystart4 = reader.GetInt32(reader.GetOrdinal("daystart"));
                    yearend4 = reader.GetInt32(reader.GetOrdinal("yearend"));
                    monthend4 = reader.GetInt32(reader.GetOrdinal("monthend"));
                    dayend4 = reader.GetInt32(reader.GetOrdinal("dayend"));
                    hstart4 = reader.GetInt32(reader.GetOrdinal("hstart"));
                    hend4 = reader.GetInt32(reader.GetOrdinal("hend"));
                    minstart4 = reader.GetInt32(reader.GetOrdinal("minstart"));
                    minend4 = reader.GetInt32(reader.GetOrdinal("minend"));

                }
                Labelnamec4.Text = namec4;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            reader.Close();
            conn.Close();
        }
        private void DoSQLAffiche3()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.event WHERE event.iduser='" + Session["Id"] + "' AND event.idex='4'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    namec3 = reader.GetString(reader.GetOrdinal("name"));
                    monthstart3 = reader.GetInt32(reader.GetOrdinal("monthstart"));
                    yearstart3 = reader.GetInt32(reader.GetOrdinal("yearstart"));
                    daystart3 = reader.GetInt32(reader.GetOrdinal("daystart"));
                    yearend3 = reader.GetInt32(reader.GetOrdinal("yearend"));
                    monthend3 = reader.GetInt32(reader.GetOrdinal("monthend"));
                    dayend3 = reader.GetInt32(reader.GetOrdinal("dayend"));
                    hstart3 = reader.GetInt32(reader.GetOrdinal("hstart"));
                    hend3 = reader.GetInt32(reader.GetOrdinal("hend"));
                    minstart3 = reader.GetInt32(reader.GetOrdinal("minstart"));
                    minend3 = reader.GetInt32(reader.GetOrdinal("minend"));

                }
                Labelnamec3.Text = namec3;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            reader.Close();
            conn.Close();
        }
        private void DoSQLAffiche2()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.event WHERE event.iduser='" + Session["Id"] + "' AND event.idex='3'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    namec2 = reader.GetString(reader.GetOrdinal("name"));
                    monthstart2 = reader.GetInt32(reader.GetOrdinal("monthstart"));
                    yearstart2 = reader.GetInt32(reader.GetOrdinal("yearstart"));
                    daystart2 = reader.GetInt32(reader.GetOrdinal("daystart"));
                    yearend2 = reader.GetInt32(reader.GetOrdinal("yearend"));
                    monthend2 = reader.GetInt32(reader.GetOrdinal("monthend"));
                    dayend2 = reader.GetInt32(reader.GetOrdinal("dayend"));
                    hstart2 = reader.GetInt32(reader.GetOrdinal("hstart"));
                    hend2 = reader.GetInt32(reader.GetOrdinal("hend"));
                    minstart2 = reader.GetInt32(reader.GetOrdinal("minstart"));
                    minend2 = reader.GetInt32(reader.GetOrdinal("minend"));

                }
                Labelnamec2.Text = namec2;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            reader.Close();
            conn.Close();
        }
        private void DoSQLAffiche1()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.event WHERE event.iduser='" + Session["Id"] + "' AND event.idex='2'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    namec1 = reader.GetString(reader.GetOrdinal("name"));
                    monthstart1 = reader.GetInt32(reader.GetOrdinal("monthstart"));
                    yearstart1 = reader.GetInt32(reader.GetOrdinal("yearstart"));
                    daystart1 = reader.GetInt32(reader.GetOrdinal("daystart"));
                    yearend1 = reader.GetInt32(reader.GetOrdinal("yearend"));
                    monthend1 = reader.GetInt32(reader.GetOrdinal("monthend"));
                    dayend1 = reader.GetInt32(reader.GetOrdinal("dayend"));
                    hstart1 = reader.GetInt32(reader.GetOrdinal("hstart"));
                    hend1 = reader.GetInt32(reader.GetOrdinal("hend"));
                    minstart1 = reader.GetInt32(reader.GetOrdinal("minstart"));
                    minend1 = reader.GetInt32(reader.GetOrdinal("minend"));

                }
                Labelnamec1.Text = namec1;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            reader.Close();
            conn.Close();
        }


        public void DoSQLImage()
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
/*
        private void UpdateSql(int i)
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
              queryStr = "";
               queryStr = "update database.event set name='" + TextEvent.Text + "',monthstart'" + TextMstart.Text + "',yearstart'" + TextYstart.Text + "',daystart'" + TextDaystart.Text + "',yearend'" + TextYF.Text + "',monthend'" + TextMF.Text + "',dayend'" + TextDayF.Text + "',hstart'" + TextHD.Text + "',hend'" + TextHF.Text + "',minstart'" + TextMinD.Text + "',minend'" + TextMinF.Text + "' where iduser='" + Session["Id"] + "' AND idex='"+i+"';";
               cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
               cmd.ExecuteNonQuery();
            queryStr = "";
            queryStr = "DELETE FROM database.event WHERE idex='" +i+ "' ";
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
            cmd.ExecuteNonQuery();

            queryStr1 = ""; 
            queryStr1 = "INSERT INTO database.event (name,monthstart,yearstart,daystart,yearend,monthend,dayend,hstart,hend,minstart,minend,iduser,idex)VALUES('" + TextEvent.Text + "','" + TextMstart.Text + "','" + TextYstart.Text + "','" + TextDaystart.Text + "','" + TextYF.Text + "','" + TextMF.Text + "','" + TextDayF.Text + "','" + TextHD.Text + "','" + TextHF.Text + "','" + TextMinD.Text + "','" + TextMinF.Text + "','" + Session["Id"] + "','" + i + "')";

            cmd2 = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);

            cmd2.ExecuteNonQuery();
            conn.Close();

        }
       */
       /*
        protected void DoSQLQueryEvent(object sender, EventArgs e)
        {
            try
            {

                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr1 = "";
                queryStr1 = "SELECT COUNT(*) FROM database.event WHERE event.iduser='" + Session["Id"] + "' ";
                int count = -1;
                MySqlCommand cmd1 = new MySqlCommand(queryStr1, conn);
                count = int.Parse(cmd1.ExecuteScalar() + "");
                queryStr3 = "";
                queryStr3 = "SELECT value FROM database.estdel WHERE estdel.iduser='" + Session["Id"] + "'";
                cmd3 = new MySql.Data.MySqlClient.MySqlCommand(queryStr3, conn);
                reader = cmd3.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {

                    value = reader.GetInt32(reader.GetOrdinal("value"));

                }
                reader.Close();

                if (count < 4)
                {

               
                queryStr = "";
                    int i = count + 1;
                queryStr = "INSERT INTO database.event (name,monthstart,yearstart,daystart,yearend,monthend,dayend,hstart,hend,minstart,minend,iduser,idex)VALUES('" + TextEvent.Text + "','" + TextMstart.Text + "','" + TextYstart.Text + "','" + TextDaystart.Text + "','" + TextYF.Text + "','" + TextMF.Text + "','" + TextDayF.Text + "','" + TextHD.Text + "','" + TextHF.Text + "','" + TextMinD.Text + "','" + TextMinF.Text + "','" + Session["Id"] + "','"+i+"')";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                cmd.ExecuteNonQuery();

                }
                else if(count==5)
                {
                    if (value == 0)
                    {
                        
                        queryStr1 = "";
                        queryStr1 = "update database.estdel set value='1' where iduser='" + Session["Id"] + "';";
                        cmd2 = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
                        cmd2.ExecuteNonQuery();

                      //  UpdateSql(1);
                    }
                    else
                    {
                        int j = value + 1;

                        queryStr1 = "";
                        queryStr1 = "update database.estdel set value='"+j+"' where iduser='" + Session["Id"] + "';";
                        cmd2 = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
                        cmd2.ExecuteNonQuery();

                        UpdateSql(j);
                    }
                    if(value == 4)
                    {
                        queryStr1 = "";
                        queryStr1 = "update database.estdel set value='0' where iduser='" + Session["Id"] + "';";
                        cmd2 = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
                        cmd2.ExecuteNonQuery();
                    }
                }

                conn.Close();
            Response.BufferOutput = true;
            Response.Redirect("~/Calendar/Calendar.aspx", false);

        }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
*/

        protected void DoSQLEvent()
        {
            try
            {

                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();

                queryStr = "";


                queryStr = "SELECT * FROM database.event WHERE   ";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                cmd.ExecuteNonQuery();



                conn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}