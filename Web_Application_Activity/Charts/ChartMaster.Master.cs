using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity.Charts
{
    public partial class ChartMaster : System.Web.UI.MasterPage
    {
        String userName;
        protected void Page_Load(object sender, EventArgs e)
        {
            userName = (String)(Session["utname"]);
            Label14.Text = userName;
            LabelDetail.Text = (String)(Session["detail"]);
            NomLabel1.Text = userName;
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
        private void DoSQLImage()
        {
            try
            {
                Image1.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];
                Image2.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];
                Image3.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}