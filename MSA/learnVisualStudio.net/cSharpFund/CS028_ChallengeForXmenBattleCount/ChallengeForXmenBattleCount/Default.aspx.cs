using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };
            
            //declare variables to store details of max and min amounts and positions
            int max = 0, min = 99, maxPosition = 0, minPosition = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i]>max)
                {
                    max = numbers[i];
                    maxPosition = i;
                }

                if (numbers[i]<min )
                {
                    min = numbers[i];
                    minPosition = i;
                }
            }

            string result = string.Format("Minimum battles: {0}, fought by  {1} <br>Max battles: {2}, fought by {3}",
                            min, names[minPosition], max, names[maxPosition]);


            // Your Code Here!


            resultLabel.Text = result;
        }
    }
}