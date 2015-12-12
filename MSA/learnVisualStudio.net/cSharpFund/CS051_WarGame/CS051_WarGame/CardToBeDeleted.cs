using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS051_WarGame
{
    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

        public string DisplayCard() {
            return String.Format("{0} of {1}", Rank, Suit);
        }

        public Card() {
            Suit = "notDefined";
            Rank = "notDefined";

        }
    }
}