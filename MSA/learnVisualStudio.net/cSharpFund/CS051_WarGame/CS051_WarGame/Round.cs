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
        public string BountyAsString { get; set; };
        public Player RoundWinner { get; set; }

        public Round(Player player1, Player player2) {
            this.player1 = player1;
            this.player2 = player2;
        }


        public void PlayRound() {
            player1Card = player1.PlayFirstCard();
            player2Card = player2.PlayFirstCard();
            bounty.Add(player1Card);
            bounty.Add(player2Card);

            whoWon();
        }

        private void whoWon()
        {
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

        public string DisplayBounty()
        {
            //create string and add all the card names in bounty stack
            string bountyCards = "";
            bountyCards += bounty.ElementAt(1).DisplayCard();
            for (int i = 1; i < bounty.Count; i++)
            {
                bountyCards += ", " +bounty.ElementAt(i).DisplayCard();
            }

            return bountyCards;
        }


        private void winnerGetsBounty(Player winner)
        {
            //before removing bounty cards store their details as string
            BountyAsString = DisplayBounty();

            //update details of round winner
            RoundWinner=winner;

            //while cards remain in bounty remove and give to winner
            while (bounty.Count>0)
            {
                winner.Hand.Add(bounty.ElementAt(0));
                bounty.RemoveAt(0);
            }
        }

        private void thisIsWar()
        {
            bounty.Add(player1.PlayFirstCard());
            bounty.Add(player1.PlayFirstCard());
            player1Card = player1.PlayFirstCard();
            bounty.Add(player1Card);

            bounty.Add(player2.PlayFirstCard());
            bounty.Add(player2.PlayFirstCard());
            player2Card = player2.PlayFirstCard();
            bounty.Add(player2Card);

            whoWon();
        }
    }

}