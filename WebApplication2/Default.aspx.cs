﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDefaultText1.Text = Application["DefaultText1"] as string;
            lblDefaultText2.Text = Application["DefaultText2"] as string;
            
        }

        
        
    }
}