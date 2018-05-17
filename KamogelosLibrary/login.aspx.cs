using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace KamogelosLibrary
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["userName"] = userName.Text;
            

            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["kamogelosLibrary"].ConnectionString);
                conn.Open();
                string checkUser = "Select count(*) From users Where username='" + userName.Text + "'";
                string checkPass = "Select count(*) From users Where password='" + passWord.Text + "'";

                SqlCommand scom = new SqlCommand(checkUser, conn);

                int temp = Convert.ToInt32(scom.ExecuteScalar().ToString());
                int temp2 = Convert.ToInt32(scom.ExecuteScalar().ToString());

                if (temp == 1 && temp2 == 1)
                {
                    Response.Redirect("home.aspx");
                   



                }
                else
                    if (temp != 1 && temp2 != 1)
                {

                    Response.Redirect("signUp.aspx");
                    Response.Write("Please SignUP");
                }

                conn.Close();

            }



        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Session["userName"] = userName.Text;

        }
    }
}