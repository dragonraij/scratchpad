using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS051_CardDeck
{
    public enum Rank { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace, Joker };
    public enum Suit { Clubs, Spades, Diamonds, Hearts, Joker };

    public class Card
    {
    
    

        public  Rank rank { get; set; }
        public Suit suit { get; set; }

        public Card() {
            rank = Rank.Joker;
            suit = Suit.Joker;
        }

        public Card(Rank rank, Suit suit) {
            this.rank = rank;
            this.suit = suit;
        }

        public string DisplayCard() {
            return String.Format("{0} of {1}", rank, suit);
        }
    }
}