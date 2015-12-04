using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_045_SimpleDartsGame
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player() {
            this.Name = "Undefined";
            this.Score = 0;
        }

        public Player (string name) : this()
        {
            this.Name = name;
        }
    }
}