using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity.ForgetLog
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String name;
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelUName.Text = ((String)Session["nom"]);
            DoSQLImage();
            LabelNom.Text= ((String)Session["utname"]);
            name = (String)(Session["uname"]);
            if (name == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Login/LoginPage.aspx", false);
            }

            if (((String)Session["role"]) == "admin")
            {
                Labeltitre.Text = "Changer mode ";
                Label1.Text = "Vous etez en mode administrateur";
                Label2.Text = "";
            }
            else
            {
                Labeltitre.Text = "Aller au Accueil";
                Label1.Text = "Vous n'avez pas la permission d'ouvrir cette page";
                Label2.Text = "Changer votre session actuelle";
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