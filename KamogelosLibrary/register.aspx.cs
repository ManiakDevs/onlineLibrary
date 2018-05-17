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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Session["userName"] = userName.Text;
            //Request.Form["userName"] = userName.Text;

            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["kamogelosLibrary"].ConnectionString);
                conn.Open();
                string checkUser = "Select count(*) from users Where username='" + userName.Text + "'";

                SqlCommand scom = new SqlCommand(checkUser, conn);

                int temp = Convert.ToInt32(scom.ExecuteScalar().ToString());

                if (temp == 1)
                {

                    Response.Write("user already Exists");
                }

                conn.Close();

            }




        }

        protected void regBtn_Click(object sender, EventArgs e)
        {
            //Used by the home page to get the username
            Request.Form["userName"] = userName.Text;


            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["kamogelosLibrary"].ConnectionString);
                conn.Open();
                string insertQuery = "Insert Into users ( username, email, password, institution, location) values ( @username, @email, @password, @institution, @location)";
                SqlCommand sCom = new SqlCommand(insertQuery, conn);

                //execute query
                
                sCom.Parameters.AddWithValue("@username", userName.Text);
                sCom.Parameters.AddWithValue("@email", email.Text);
                sCom.Parameters.AddWithValue("@password", passWord.Text);
                sCom.Parameters.AddWithValue("@institution", institution.Text);
                sCom.Parameters.AddWithValue("@location", location.Text);

                sCom.ExecuteNonQuery();
                Response.Redirect("login.aspx");
                conn.Close();
            }

            catch (Exception ex)
            {
                Response.Write("ERROR" + ex.Message);
            }

        }
    }
}