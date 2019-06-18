using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity.Tableau_De_Bord
{
    public partial class Details : System.Web.UI.MasterPage
    {
        String userName;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            userName = (String)(Session["utname"]);
            NomLabel1.Text = userName;
            NomLabel2.Text = userName;
            LabelDetail.Text = (String)(Session["detail"]);

            DoSQLImage();
        }

        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("~/Login/LoginPage.aspx", false);


        }
        public void DoSQLImage()
        {
            try
            {
                Image1.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];
                Image2.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}