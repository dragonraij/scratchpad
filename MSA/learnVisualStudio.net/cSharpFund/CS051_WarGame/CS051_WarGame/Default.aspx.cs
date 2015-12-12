using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS051_WarGame
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Initialise new game object
            Game warGame = new Game("Steve", "Bob");
            vsLabel.Text = String.Format("<h3><b>{0} vs {1}</h3></b>", warGame.player1.Name, warGame.player2.Name);
            dealLabel.Text+= warGame.DealCards();

            //play 20 rounds of game
            for (int i = 0; i < 20; i++)
            {
                battleLabel.Text += String.Format("<h3>Round {0}</h3>", i+1);
                battleLabel.Text+= warGame.PlayRounds();
                
            }
        }
    }
}