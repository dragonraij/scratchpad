using CS051_CardDeck;
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

            if (player1Card.rank > player2Card.rank)
            {
                winnerGetsBounty(player1);
            }
            else if (player2Card.rank > player1Card.rank)
            {
                winnerGetsBounty(player2);
            }
            else
                thisIsWar();
        }


        private void winnerGetsBounty(Player winner)
        {
            while (bounty.Count>0)
            {
                winner.Hand.Add(bounty.ElementAt(0));
                bounty.RemoveAt(0);
            }
        }

        private void thisIsWar()
        {
           
        }
    }

}