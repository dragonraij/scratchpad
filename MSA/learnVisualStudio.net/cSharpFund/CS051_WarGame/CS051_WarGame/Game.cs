using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS051_WarGame
{
    public class Game
    {
        private Player player1 { get; set; }
        private Player player2 { get; set; }


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