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
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                ViewState.Add("Balance", "100"); 
                spinOutcome();
                
            }


        }


        Random random = new Random();
        private  string spinWheel()
        {
            int current = random.Next(0,11);

            switch (current)
            {
                case 0: return "Bar.png";
                case 1: return "Bell.png";
                case 2: return "Cherry.png";
                case 3: return "Clover.png";
                case 4: return "Diamond.png";
                case 5: return "HorseShoe.png";
                case 6: return "Lemon.png";
                case 7: return "Orange.png";
                case 8: return "Plum.png";
                case 9: return "Seven.png";
                case 10: return "Strawberry.png";
                default: return "Bar.png";
            }
        }

        private void spinOutcome() { 
            
            //update the outcome of the spins to the three images
            reelImage1.ImageUrl = "Images\\" + spinWheel();
            reelImage2.ImageUrl = "Images\\" + spinWheel();
            reelImage3.ImageUrl = "Images\\" + spinWheel();
           
        
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            int betAmount = getBetAmount();
            int balance = int.Parse(ViewState["Balance"].ToString());
            int winnings = 0;
            if (betAmount > 0 && balance>0)
            {
                spinOutcome();
                //calculate winnings
                winnings = calculateWinnings(betAmount);

                //display balance and winnings
                updateBalance(winnings, betAmount, balance);
            }
            else
            {
                betTextBox.Text = "Enter Credit";
            }

            //save balance in viewstate
            ViewState["Balance"] = balance-betAmount+winnings;

        }

        


        private int getBetAmount()
        {
            //returns the integer value entered
            if (betTextBox.Text.Length>0)
            {
                int bet;
                int.TryParse(betTextBox.Text, out bet);
                return bet;
                
            }
            
            //if no integer entered returns -1 for error
            return -1;
        }

        private int calculateWinnings(int betAmount)
        {
            
            //if any bar shows up no prize is paid
            if (reelImage1.ImageUrl == "Images\\Bar.png" || reelImage2.ImageUrl == "Images\\Bar.png" || reelImage3.ImageUrl == "Images\\Bar.png")
            {
                return 0;
            }

            //if there are 3 sevens you have hit jackpot and the prize is 100 times the bet
            else if (reelImage1.ImageUrl == "Images\\Seven.png" && reelImage2.ImageUrl == "Images\\Seven.png" && reelImage3.ImageUrl == "Images\\Seven.png")
            {
                return 100 * betAmount;
            }

            //number of cherries which show up
            int cherries = countCherries();

            //calculate cherry prize
            switch (cherries)
            {
                case 1: return betAmount * 2;
                case 2: return betAmount * 3;
                case 3: return betAmount * 4;
                default: return 0;
            }
        }

        private int countCherries()
        {
            int count = 0;
            
            if (reelImage1.ImageUrl=="Images\\Cherry.png")
        	{
                count++; 
	        }
            if (reelImage2.ImageUrl == "Images\\Cherry.png")
            {
                count++;
            }
            if (reelImage3.ImageUrl == "Images\\Cherry.png")
            {
                count++;
            }
            return count;
            
        }

        //update balance and display to user
        private void updateBalance(int winnings, int betAmount, int balance)
        {
            winningsLabel.Text = string.Format("Your winnings are : {0:C}", winnings);
            balanceLabel.Text = string.Format("Your current balance is : {0:C}", balance - betAmount + winnings);
        }
    }
}