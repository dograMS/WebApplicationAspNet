using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["DefaultText1"] = "Default Text One";
            Application["DefaultText2"] = "Default Text Two";
            Application["FooterText"] = "Footer Text";
            Application["HeaderText"] = "Header Text";

        }

        void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();

            if (Application["VisitorCount"] == null)
            {
                Application["VisitorCount"] = "1";
            }
            else
            {
                int VisitorCount = Convert.ToInt32(Application["VisitorCount"]);
                VisitorCount++;
                Application["VisitorCount"] = VisitorCount.ToString();
            }
            Application.UnLock();
        }
    }

        
}