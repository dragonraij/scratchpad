using CS051_CardDeck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS051_WarGame
{
    public class Game
    {
        public Player player1 { get; set; }
        public Player player2 { get; set; }
        Deck cardDeck = new Deck();


        public void Play20Rounds()
        {
            for (int rounds = 0; rounds < 20; rounds++)
            {
                while (player1.Hand.Count>0 && player2.Hand.Count>0)
                {
                    Round newRound = new Round(player1, player2);
                    newRound.PlayRound();
                }
            }
        }

        
        //the player with most cards is the winner
        public string Winner() {
            if (player1.Hand.Count>player2.Hand.Count)
            {
                return player1.Name;
            }
            else if (player2.Hand.Count>player1.Hand.Count)
            {
                return player2.Name;
            }
            else
            {
                return "Its a draw !!";
            }
        }

        //object initializers
        public Game() {
            player1 = new Player(){ Name="Player 1"};
            player2 = new Player() { Name = "Player 2" };
        }


        public Game(string name1, string name2)
        {
            player1 = new Player() { Name = name1 };
            player2 = new Player() { Name = name2 };
        }

    }
}