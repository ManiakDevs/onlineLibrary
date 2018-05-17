using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KamogelosLibrary
{
    public partial class regSuccess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello, " + Request.Form["userName"] + "</br>");
            Response.Write("Please" + "\t" + "<a href='login.aspx'>Login</a>" + "\t" + "here"); 
        }
    }
}