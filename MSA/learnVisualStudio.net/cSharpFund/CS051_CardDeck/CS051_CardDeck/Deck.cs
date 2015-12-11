using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CS051_CardDeck
{
    public class Deck
    {

        Random random = new Random();
        private List<Card> cards = new List<Card>();


        public string DisplayDeck()
        {

            string display = "";
            foreach (var card in cards)
            {
                display+="<p>"+card.DisplayCard()+"</p>";
                
            }

            return display;
        }

        public Card DealCard() { 
             int cardPosition=random.Next(cards.Count);
             Card toRemove = cards.ElementAt(cardPosition);
             cards.RemoveAt(cardPosition);
             return toRemove;
        }

        public Deck(){
            for (var j = 0; j < 13; j++)
            {
                for (var i = 0; i < 4; i++)
                {
                    //cards.Add(new Card() { rank = Rank.Joker, suit = Suit.Joker });
                    cards.Add(new Card() { rank = (Rank)Enum.Parse(typeof(Rank), j.ToString()), suit = (Suit)Enum.Parse(typeof(Suit), i.ToString()) });
                }
            }
            
        }
    }
}