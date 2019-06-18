using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity.Notebook
{
    public partial class Notebook : System.Web.UI.MasterPage
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        String queryStr;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void DoSQLQueryAddNote()
        {
            try
            {
              
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();

                queryStr = "";
                Session["edate"] = System.DateTime.Now.ToString();

                queryStr = "INSERT INTO database.note (name,description,date)VALUES('New Note','', '" + (String)(Session["edate"]) + "')";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                cmd.ExecuteNonQuery();



                conn.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public void DoSQLQueryNote()
        {
            try
            {
               
               note note = new note();
                List<note> notes = new List<note>();
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "SELECT * FROM database.note  ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {
                    //  email = reader.GetString(reader.GetOrdinal("email"));
                    note.id = reader.GetInt32(reader.GetOrdinal("id"));
                    note.name = reader.GetString(reader.GetOrdinal("name"));
                    note.description = reader.GetString(reader.GetOrdinal("description"));
                    note.date = reader.GetString(reader.GetOrdinal("date"));
                    notes.Add(note);

                }

                if (reader.HasRows)
                {
                    //  Session["uname"] = name;

                    //  LabelUname.Text = userNom;
                    Labeldate.Text = note.date;
                    Labeldate1.Text = note.date;
                    Labeldescription.Text = note.description;
                    Labelname.Text = note.name;
                }

                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


    }
}