using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
namespace Web_Application_Activity.Mail
{
    public partial class Inbox : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        String queryStr;
        String name;
        protected void Page_Load(Object sender, EventArgs e)
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

                BindGrid();

            }
        }



        protected void maGrille_ItemCommand1(object sender, DataGridCommandEventArgs e)
        {
            Session["Indexrec"] = e.Item.Cells[0].Text;
            try { 
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
            queryStr = "";
                String etat;
                etat = "lu";
            queryStr = "update database.email set estLu='"+ etat + "' where id='" + Session["Indexrec"] + "';";
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

            cmd.ExecuteNonQuery();



            conn.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex);

            }
            Response.BufferOutput = true;
            Response.Redirect("~/Mail/ReadMailRec", false);
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
        protected void PagerButtonClick(Object sender, EventArgs e)
        {
            // Used by external paging UI.
            String arg = ((LinkButton)sender).CommandArgument;

            switch (arg)
            {
                case ("next"):
                    if (MyDataGridRec.CurrentPageIndex < (MyDataGridRec.PageCount - 1))
                        MyDataGridRec.CurrentPageIndex++;
                    break;
                case ("prev"):
                    if (MyDataGridRec.CurrentPageIndex > 0)
                        MyDataGridRec.CurrentPageIndex--;
                    break;
                case ("last"):
                    MyDataGridRec.CurrentPageIndex = (MyDataGridRec.PageCount - 1);
                    break;
                default:

                    // Page number.
                    MyDataGridRec.CurrentPageIndex = Convert.ToInt32(arg);
                    break;
            }
            BindGrid();
        }


        protected void BindGrid()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.email WHERE email.emailTo='" + (String)(Session["uemail"]) + "' ORDER BY date DESC  "))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                MyDataGridRec.DataSource = dt;
                                MyDataGridRec.DataBind();
                            }
                        }
                    }

                }
            }


        }

    }
}