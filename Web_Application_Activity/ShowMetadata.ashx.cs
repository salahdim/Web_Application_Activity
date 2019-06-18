using System;
using System.Configuration;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Activity
{
    /// <summary>
    /// Summary description for ShowMetadata
    /// </summary>
    public class ShowMetadata : IHttpHandler
    {

        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;

        String queryStr;
        public void ProcessRequest(HttpContext context)
        {
            Int32 empno;
            if (context.Request.QueryString["codeuser"] != null)
            {
                empno = Convert.ToInt32(context.Request.QueryString["codeuser"]);

            }
            else
                throw new ArgumentException("No parameter specified");

            context.Response.ContentType = "image/jpeg";
            Stream strm = ShowEmpImage4(empno);
            byte[] buffer = new byte[4096];
            int byteSeq = strm.Read(buffer, 0, 4096);

            while (byteSeq > 0)
            {
                context.Response.OutputStream.Write(buffer, 0, byteSeq);
                byteSeq = strm.Read(buffer, 0, 4096);
            }
            //context.Response.BinaryWrite(buffer);
        }

        public Stream ShowEmpImage4(int empno)
        {

            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            queryStr = "";
            queryStr = "SELECT media FROM metadata WHERE codeuser= @CD" ;
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CD", empno);

            conn.Open();
            object img = cmd.ExecuteScalar();
            try
            {
                return new MemoryStream((byte[])img);
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


    }
}