using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session["Session1"] = "Session 1 Data";
        //Session["Session2"] = "Session 2 Data";

        //Response.Write("Session 1 Data = " + Session[0].ToString());
        //Response.Write("<br/>");
        //Response.Write("Session 2 Data = " + Session["Session2"].ToString());

        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        using (SqlConnection con = new SqlConnection())
        {
            SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                Response.Write(rdr[0].ToString());
                Response.Write(rdr["Name"].ToString());
                Response.Write("<br>/");
            }
        }

    }
}