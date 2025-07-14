using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string stored_username = ConfigurationManager.AppSettings["username"];
            string stored_password = ConfigurationManager.AppSettings["password"];


            if(Login1.UserName == stored_password && Login1.Password == stored_password)
            {
                Session["Admin"] = true;
                e.Authenticated = true;
                Response.Redirect("AdminPanel.aspx");
            }
            else
            {
                e.Authenticated = false;
            }

        }
    }
}