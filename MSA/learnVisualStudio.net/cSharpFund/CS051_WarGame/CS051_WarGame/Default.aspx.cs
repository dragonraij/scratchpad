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
            battleLabel.Text+= warGame.DealCards();
        }
    }
}