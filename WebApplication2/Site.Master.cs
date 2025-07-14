using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblHeaderText.Text = Application["HeaderText"] as string;
            lblFooterText.Text = Application["FooterText"] as string;

            if (Session["Admin"] != null)
            {
                
                navDashboard.Visible = true;
            }
            else
            {
                navDashboard.Visible = false;
            }

            if (Application["VisitorCount"] != null)
            {
                lblVisitorCount.Text = Application["VisitorCount"] as string;
            }
            
        }
    }
}