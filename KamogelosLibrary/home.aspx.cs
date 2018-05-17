using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Sql;

namespace KamogelosLibrary
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello, " + Session["userName"]);
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {

            try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["kamogelosLibrary"].ConnectionString);
                    conn.Open();
                    string checkBook = "Select title From availableBooks Where title  Like ='" + searchBox.Text + "'";

                    SqlCommand scom = new SqlCommand(checkBook, conn);
                    SqlDataReader booksAvail = scom.ExecuteReader();

                    if (booksAvail.Read())
                    {
                        do
                        {
                            Response.Write(booksAvail["title"]);


                        } while (booksAvail.Read());

                    }

                    conn.Close();
                }
                catch (SqlException exp)
                {
                    Response.Write("<p> ERROR CODE" + exp.Number + exp.Message + "</p>");
                }

        }
    }
}