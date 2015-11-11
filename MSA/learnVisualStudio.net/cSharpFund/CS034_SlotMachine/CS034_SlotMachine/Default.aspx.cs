﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS034_SlotMachine
{
    public partial class Default : System.Web.UI.Page
    {
        int balance;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                
                balance = 100;
                spinOutcome();
                
            }


        }


        Random random = new Random();
        private  string spinWheel()
        {
            int current = random.Next(0,8);

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

        protected void leverButton_Click(object sender, EventArgs e)
        {
            int betAmount = getBetAmount();

            if (betAmount > 0)
            {
                spinOutcome();
                //calculate winnings
                int winnings = calculateWinnings(betAmount);

                //update balance and winnings
                updateBalance(winnings, betAmount, balance);
            }

        }

        


        private int getBetAmount()
        {
            //returns the integer value entered
            if (betTextBox.Text.Length>0)
            {
                return int.Parse(betTextBox.Text);
                
            }
            
            //if no integer entered returns -1 for error
            return -1;
        }

        private int calculateWinnings(int betAmount)
        {   
            //if any bar shows up no prize is paid
            if (img1Label.Text=="bar" || img2Label.Text=="bar"||img3Label.Text=="bar")
            {
                return 0;
            }

            //if there are 3 sevens you have hit jackpot and the prize is 100 times the bet
            else if (img1Label.Text=="seven" && img2Label.Text=="seven"&&img3Label.Text=="seven")
            {
                return 100 * betAmount;
            }

            //number of cherries which show up
            int cherries = countCherries();

            //calculate cherry prize
            switch (cherries)
            {
                case 1: return betAmount * 2;
                case 2: return betAmount * 5;
                case 3: return betAmount * 8;
                default: return 0;
            }
        }

        private int countCherries()
        {
            int count = 0;
            
            if (img1Label.Text=="cherry")
        	{
                count++; 
	        }
            if (img2Label.Text == "cherry")
            {
                count++;
            }
            if (img3Label.Text == "cherry")
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