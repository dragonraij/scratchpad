﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_042
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Car myCar = new Car();
            Car myCar = new Car("Ford", "Valiant", "Gold", 1990);
            resultLabel.Text = myCar.FormatDetailsForDisplay();
        }

        
    }
}