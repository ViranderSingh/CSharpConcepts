using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Indexers
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Example 1 of Indexers
            //Session["Session1"] = "Session 1 Data";
            //Session["Session2"] = "Session 2 Data";

            //Response.Write("Session 1 Data = " + Session[0].ToString() + "<br/>");
            //Response.Write("Session 2 Data = " + Session["Session2"]);

            //Example 2 of Indexers
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;        //Connection string DBCS is included in Web.config file
            using(SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    Response.Write("Id = " + rdr[0].ToString() + " ");
                    Response.Write("Name = " + rdr["Name"].ToString() + "<br/>");
                }
            }

        }
    }
}