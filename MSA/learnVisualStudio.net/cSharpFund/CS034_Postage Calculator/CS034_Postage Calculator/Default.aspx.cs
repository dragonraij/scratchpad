//Raj Prasad
//Calculates the shipping for item using provided business rules

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS034_Postage_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            resultLabel.Text = "Hello";
            findVolume();
        }

        //Calculate shipping
        void updateShippingCost() { }

            // Find Volume
        double findVolume() {
            double height = double.Parse(heightTextBox.Text);
            double width = double.Parse(widthTextBox.Text);
            double length = double.Parse(lengthTextBox.Text);
            return 1;
        }            

        
        //Find shipping method multiplier
        double shippingMultiplier() {
            if (groundRadioButton.Checked)
            {
                return .25;
            }
            else if (airRadioButton.Checked)
            {
                return 1.25;
            }
            else if (nextDayRadioButton.Checked)
            {
                return 2.5;
            }
            else
            {

                return -1;
            }
        }

        protected void inputChanged(object sender, EventArgs e)
        {
            //check if values entered
            if (!valuesEntered()) return;
            //get volume

            //get shipping multiplier

            //calculate cost

            //display result
            
        }

        private bool valuesEntered()
        {
            //if no value entered in width and height
            if (widthTextBox.Text.Trim().Length==0 &&
                heightTextBox.Text.Trim().Length==0)
            {
                return false;
            }

            //if no postage method selected
            if (!(groundRadioButton.Checked||airRadioButton.Checked||nextDayRadioButton.Checked))
            {
                return false;
            }

            //values are selected so returns true
            return true;
        }



            //check info
        
            //display result
        

    }
}