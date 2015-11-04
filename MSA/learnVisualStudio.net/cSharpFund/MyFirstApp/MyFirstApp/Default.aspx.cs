using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fortuneButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "At " + ageTextBox.Text + " years old, I would have expected you to have more than " +
                moneyTextBox.Text + " in your pocket";
               
        }
    }
}