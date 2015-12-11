using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS051_WarGame
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand = new List<Card>();

        public Card PlayFirstCard() {
            Card currentCard = Hand.ElementAt(0);
            Hand.RemoveAt(0);
            return currentCard;
        
        }



        //object initializers
        public Player() {
            Name = "UnNamedPlayer";
        }

        public Player(string name) {
            Name = name;
        }
    }
}