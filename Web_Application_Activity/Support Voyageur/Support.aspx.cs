using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Web_Application_Activity.Support_Voyageur
{
    public partial class Support1 : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        String queryStr;
        Int32 idLike;
        String name;
        String iduser;
        String userName;
        String datee;
        String contentmeta;
        String countlike;
        String count;
        bool test;
         public Int32 idmetadata;
        public Int32 idmetadata1;
        public Int32 idmetadata3;
        Int32 countindex;

        MySql.Data.MySqlClient.MySqlDataReader reader;
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
                if (((String)Session["role"]) == "user")
                {
                    ContentData.Visible = false;
                    ButtonPost.Visible = false;
                    FileUpload1.Visible = false;
                    LabelMessage.Text = "vous êtes un utilisateur simple, vous n'avez pas le droit de publier sur cette page";
                }
                DoSQLImage();
                DoSQLQueryyIm();
                BindGrid();
                DoSQLCountComment();
            }

            userName = (String)(Session["utname"]);
            Label1.Text = userName;

            

        }

        protected void BindGrid()
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
            String queryStr1 = "";
             queryStr1 = "SELECT id FROM database.metadata WHERE metadata.codeuser='" + Session["urole"] + "'  ";
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
            reader = cmd.ExecuteReader();

            while (reader.HasRows && reader.Read())
            {
                idmetadata1 = reader.GetInt32(reader.GetOrdinal("id"));

            }


            reader.Close();
            conn.Close();

            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["WebAppConnString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.comment WHERE comment.codeuser='" + Session["urole"] + "' AND comment.idmetadata='"+ idmetadata1 + "'  "))
                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                MyDataGridComment.DataSource = dt;
                                MyDataGridComment.DataBind();
                            }
                        }
                    }

                }
            }


        }

        private void DoSQLQueryDelete()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                String queryStr = "";
                 queryStr = "DELETE FROM database.metadata WHERE metadata.codeuser='" + Session["urole"] + "'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private bool DoSQLQueryTest()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                String queryStr = "";
                queryStr = "SELECT COUNT(id) as countindex FROM database.metadata WHERE metadata.codeuser='" + Session["urole"] + "' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                countindex = 0;

                while (reader.HasRows && reader.Read())
                {
                    countindex = reader.GetInt32(reader.GetOrdinal("countindex"));


                }


                if (countindex != 0)
                {
                    return true;
                }

                reader.Close();
                conn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }
        protected void DoSQLQueryVoyageur(object sender, EventArgs e)
        {
            try
            {
                test = false;
                test = DoSQLQueryTest();
                if(test == true)
                {
                    DoSQLQueryDelete();
                }

                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                string contentType = FileUpload1.PostedFile.ContentType;
                Stream fs = FileUpload1.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);
                byte[] bytes = br.ReadBytes((Int32)fs.Length);
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();

                String queryStr = "";
                Session["edate2"] = System.DateTime.Now.ToString();

                queryStr = "INSERT INTO database.metadata (username,date,media,content,codeuser,iduser)VALUES('" + Session["nom"] + "','" + (String)(Session["edate2"]) + "', @Content , '" + ContentData.Value + "','" + Session["urole"] + "','" + Session["Id"] + "')";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@Content", bytes);

                cmd.ExecuteNonQuery();

                Response.BufferOutput = true;
                Response.Redirect("~/Support Voyageur/Support.aspx", false);

                conn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        protected void DoSQLQueryComment(object sender, EventArgs e)
        {
            try
            {
               
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                String queryStr1 = "";
                queryStr1 = "SELECT id FROM database.metadata WHERE metadata.codeuser='" + Session["urole"] + "'  ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    idmetadata = reader.GetInt32(reader.GetOrdinal("id"));

                }


                reader.Close();

                String queryStr = "";
                Session["edate2"] = System.DateTime.Now.ToString();

                queryStr = "INSERT INTO database.comment (username,description,date,idmetadata,codeuser,iduser)VALUES('" + Session["nom"] + "', '" + Comment_id.Text + "' ,'" + (String)(Session["edate2"]) + "','"+ idmetadata + "','" + Session["urole"] + "','" + Session["Id"] + "')";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                cmd.ExecuteNonQuery();

                Response.BufferOutput = true;
                Response.Redirect("~/Support Voyageur/Support.aspx", false);

                conn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void DoSQLQueryyIm()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                String queryStr = "";
                queryStr = "SELECT * FROM database.metadata WHERE metadata.codeuser='" + Session["urole"] + "' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                //   z01 = "";
                userName = "";
                datee = "";
                contentmeta = "";
                while (reader.HasRows && reader.Read())
                {
                    userName = reader.GetString(reader.GetOrdinal("username"));
                    iduser = reader.GetString(reader.GetOrdinal("iduser"));
                    idmetadata3 = reader.GetInt32(reader.GetOrdinal("id"));
                    datee = reader.GetString(reader.GetOrdinal("date"));
                    contentmeta = reader.GetString(reader.GetOrdinal("content"));
                }
                if (reader.HasRows)
                {
                    //  Label3.Text = z01;
                    Image2.ImageUrl = "~/ShowImage.ashx?id=" + iduser;
                    Image3.ImageUrl = "~/ShowMetadata.ashx?codeuser=" + Session["urole"]  ;
                    Image4.ImageUrl = "~/ShowImage.ashx?id=" + Session["Id"];

                    LabelProfil.Text = userName;
                    LabelDate.Text = datee;
                    LabelContent.Text = contentmeta;
                }

                reader.Close();
                String queryStr1 = "";
                queryStr1 = "SELECT COUNT(id) as countlike FROM database.like WHERE like.idmetadata='" + idmetadata3 + "' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr1, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    countlike = reader.GetString(reader.GetOrdinal("countlike"));


                }
                LabelLike.Text = countlike;






                conn.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);

            }
        }


        protected void maGrille_ItemCommand(object sender, DataGridCommandEventArgs e)
        {
            Session["Indexcomment"] = e.Item.Cells[0].Text;

            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";
                queryStr = "DELETE FROM database.comment WHERE id='" + Session["Indexcomment"] + "' ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Response.BufferOutput = true;
            Response.Redirect("~/Support Voyageur/Support.aspx", false);
        }
        protected void DoSQLCountLike(object sender, EventArgs e)
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
               String queryStr = "";

                queryStr = "SELECT id FROM database.metadata WHERE metadata.codeuser='" + Session["urole"] + "'  ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    idmetadata3 = reader.GetInt32(reader.GetOrdinal("id"));

                }
                reader.Close();




                String queryStr3;
                idLike = 0;
                queryStr3 = "";
                queryStr3 = "SELECT id FROM database.like WHERE like.idmetadata='" + idmetadata3 + "' AND like.iduser='"+Session["Id"]+"'  ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr3, conn);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    idLike = reader.GetInt32(reader.GetOrdinal("id"));

                }
                reader.Close();




                if (idLike == 0)
                {
                    String queryStr2 = "";

                    queryStr2 = "INSERT INTO database.like (iduser,idmetadata)VALUES('" + Session["Id"] + "','" + idmetadata3 + "')";

                    cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr2, conn);

                    cmd.ExecuteNonQuery();
                }



                
               
                conn.Close();
                DoSQLQueryyIm();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);

            }
        }

        private void DoSQLCountComment()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                String queryStr = "";
                queryStr = "SELECT COUNT(id) as countcom FROM database.comment WHERE comment.codeuser='"+ Session["urole"] + "' AND comment.idmetadata= (SELECT id from database.metadata WHERE metadata.codeuser='" + Session["urole"] + "') ";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
                reader = cmd.ExecuteReader();
                count = "";
                
                while (reader.HasRows && reader.Read())
                {
                    count = reader.GetString(reader.GetOrdinal("countcom"));

                }
                if (reader.HasRows)
                {
                    LaCountComment.Text = count;

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
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}