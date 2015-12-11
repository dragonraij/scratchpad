using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS051_WarGame
{
    public class Round
    {
        private Player player1 { get; set; }
        private Player player2 { get; set; }
        public Card  player1Card { get; set; }
        public Card player2Card { get; set; }
        private List<Card> bounty = new List<Card>();



    }
}