using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS010_SimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = (int.Parse(FirstTextBox.Text) + int.Parse(SecondTextBox.Text)).ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = (int.Parse(FirstTextBox.Text) - int.Parse(SecondTextBox.Text)).ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = (int.Parse(FirstTextBox.Text) * int.Parse(SecondTextBox.Text)).ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = (double.Parse(FirstTextBox.Text) / double.Parse(SecondTextBox.Text)).ToString();
        }
    }
}