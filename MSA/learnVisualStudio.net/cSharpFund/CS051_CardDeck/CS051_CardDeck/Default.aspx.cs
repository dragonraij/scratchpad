using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS051_CardDeck
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Deck currentDeck = new Deck();
           // Label1.Text = currentDeck.DisplayDeck();
            for (int i = 0; i < 52; i++)
            {
                Label1.Text += "<p>"+currentDeck.DealCard().DisplayCard()+"</p>";
            }
        }
    }
}