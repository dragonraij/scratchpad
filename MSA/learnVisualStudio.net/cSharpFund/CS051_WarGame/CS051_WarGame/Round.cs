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


        public Round(Player player1, Player player2) {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void PlayRound() {
            player1Card = player1.PlayFirstCard();
            player2Card = player2.PlayFirstCard();
            bounty.Add(player1Card);
            bounty.Add(player2Card);
        }
    }

}