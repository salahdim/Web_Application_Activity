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
    public partial class Sent : System.Web.UI.Page
    {
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
        /*
                protected void PagerButton(Object sender, EventArgs e) {

                    Response.BufferOutput = true;
                    Response.Redirect("~/Mail/ReadMailSent.aspx", false);
                    Console.WriteLine(MyDataGrid.TabIndex);
                    Label1.Text = "You selected " +
                              MyDataGrid.SelectedItem.Cells[1].Text +
                              ".<br />" +
                              MyDataGrid.SelectedItem.Cells[1].Text +
                              " has an index number of " +
                              MyDataGrid.SelectedIndex.ToString() + ".";

                }
                */
      protected  void maGrille_ItemCommand(object sender, DataGridCommandEventArgs e)
        {
            lblMessage.Text = "Ligne a editer numero : " + e.Item.Cells[0].Text;
            Session["Indexsent"] = e.Item.Cells[0].Text;
            Response.BufferOutput = true;
            Response.Redirect("~/Mail/ReadMailSent", false);
        }
        /*
                protected void PagerButtonClick(Object sender, EventArgs e)
                {
                    // Used by external paging UI.
                    String arg = ((LinkButton)sender).CommandArgument;

                    switch (arg)
                    {
                        case ("next"):
                            if (MyDataGrid.CurrentPageIndex < (MyDataGrid.PageCount - 1))
                                MyDataGrid.CurrentPageIndex++;
                            break;
                        case ("prev"):
                            if (MyDataGrid.CurrentPageIndex > 0)
                                MyDataGrid.CurrentPageIndex--;
                            break;
                        case ("last"):
                            MyDataGrid.CurrentPageIndex = (MyDataGrid.PageCount - 1);
                            break;
                        default:

                            // Page number.
                            MyDataGrid.CurrentPageIndex = Convert.ToInt32(arg);
                            break;
                    }
                    BindGrid();
                }
                */
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

        protected void BindGrid()
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.email WHERE email.emailFrom='" + (String)(Session["uemail"]) + "' ORDER BY date DESC  "))
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

        
    }
            
            
        }

      
    
