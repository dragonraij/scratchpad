using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_045_SimpleDartsGame
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Player player1 = new Player("Alfred");
            Player player2 = new Player("Bob");

            vsLabel.Text = String.Format("{0} vs {1}", player1.Name, player2.Name);

            //pair player
            DartsBattle AlfredVsBob = new DartsBattle(player1, player2);

            //play match
            AlfredVsBob.Battle();

            //Display Score
            scoreLabel.Text = AlfredVsBob.DisplayScore();

            //Display winner name
            resultsLabel.Text = "The winner is "+ AlfredVsBob.WinnerName();

        }
    }
}