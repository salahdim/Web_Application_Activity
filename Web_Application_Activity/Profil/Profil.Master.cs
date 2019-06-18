using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity.Profil
{
    public partial class Profil : System.Web.UI.MasterPage
    {
        String userName;
        protected void Page_Load(object sender, EventArgs e)
        {
            userName = (String)(Session["utname"]);
            NomLabel1.Text = userName;
            LabelDetail.Text = (String)(Session["detail"]);
            NomDep.Text = (String)Session["dep"];
            NomLabel2.Text = userName;
            DoSQLImage();
        }

        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("LoginPage.aspx", false);


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