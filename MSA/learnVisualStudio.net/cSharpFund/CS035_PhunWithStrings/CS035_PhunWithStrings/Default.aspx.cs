﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS035_PhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String input = TextBox1.Text;
            String output = "";
            for (int i = input.Length-1; i>= 0; i--)
            {
                output= output + input[i].ToString();
            }
             Label1.Text = output;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string[] names = {"Leia", "Luke", "chewy", "R2D2"};
            string[] reversed = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                reversed[reversed.Length-i-1] = names[i];
            }

            Label3.Text = string.Join(",", reversed);
        }
    }
}