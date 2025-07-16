using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class AdminPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Session["Admin"] == null)
            {
                Response.Redirect("~/Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                defaultT1.Text = Application["DefaultText1"] as string;
                defaultT2.Text = Application["DefaultText2"] as string;
                footerT.Text = Application["FooterText"] as string;
                headerT.Text = Application["HeaderText"] as string;
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session["Admin"] == null)
            {
                Response.Redirect("~/Login.aspx");
                return;
            }
            Application["DefaultText1"] = defaultT1.Text;
            Application["DefaultText2"] = defaultT2.Text;
            Application["FooterText"] = footerT.Text;
            Application["HeaderText"] = headerT.Text;
            Response.Redirect(Request.RawUrl);
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["Admin"] = null;
            Response.Redirect("~/Login.aspx");
        }
    }
}