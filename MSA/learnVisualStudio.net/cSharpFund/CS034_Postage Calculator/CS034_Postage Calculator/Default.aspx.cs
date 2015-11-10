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

            int volume = calculateVolume();
            
            //get shipping multiplier
            double shippingMultiplier = getShippng();
            

            //calculate cost
            double cost = volume * shippingMultiplier;


            //display result
            resultLabel.Text = string.Format("The shipping cost for your item is {0:C}", cost);
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


        private int calculateVolume()
        {
            int width = int.Parse(widthTextBox.Text);
            int height = int.Parse(heightTextBox.Text);
            //double check this code
            int length = 0;

            if (!int.TryParse(lengthTextBox.Text, out length))
            {
                length = 1;
            }

            return width * height * length;
        }


        private double getShippng()
        {
            if (groundRadioButton.Checked)
            {
                return 1.25;

            }
            else if (airRadioButton.Checked)
            {
                return 5.5;
            }
            else if (nextDayRadioButton.Checked)
            {
                return 7.5;
            }
            else
            {
                return 0;
            }
        }
         

    }
}