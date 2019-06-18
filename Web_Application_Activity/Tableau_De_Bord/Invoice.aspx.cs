using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity.Tableau_De_Bord
{
    public partial class Invoice : System.Web.UI.Page
    {
        String name;
        String userName;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = (String)(Session["uname"]);
            if (name == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Login/LoginPage.aspx", false);
            }

            userName = (String)(Session["utname"]);
            Label1.Text = userName;
            if (!Page.IsPostBack)
            {
                DoSQLImage();
            }

        }
        public void DoSQLImage()
        {
            try
            {
                Image2.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}