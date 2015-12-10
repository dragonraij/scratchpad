using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CS051_CardDeck
{
    public class Deck
    {
        public enum Rank { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace, Joker };
        public enum Suit { Clubs, Spades, Diamonds, Hearts, Joker };

        Random random = new Random();
        private List<Card> cards { get; set; }


        public string DisplayDeck()
        {

            string display = "";
            foreach (var card in cards)
            {
                display+="<p>"+card.DisplayCard()+"</p>";
                
            }

            return display;
        }

        public Deck(){
            for (var j = 0; j < 13; j++)
            {
                for (var i = 0; i < 4; i++)
                {
                    cards.Add(new Card((Rank)j, (Suit)i));
                }
            }
            
        }
    }
}