using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS034_SlotMachine
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            spinOutcome();

            //spin wheel
            //spin outcome
            //calculate winnings
            //update balance
            //pull lever

        }

        

        private static string spinWheel()
        {
            int current = 99;

            switch (current)
            {
                case 0: return "zero.jpg";
                case 1: return "one.jpg";
                case 2: return "two.jpg";
                case 3: return "three.jpg";
                case 4: return "four.jpg";
                case 5: return "five.jpg";
                case 6: return "six.jpg";
                case 7: return "seven.jpg";
                default: return "zero.jpg";
            }
        }

        private void spinOutcome() { 
            
            //update the outcome of the spins to the three images

            img1Label.Text = spinWheel();
            img2Label.Text = spinWheel();
            img3Label.Text = spinWheel();
        
        }
    }
}