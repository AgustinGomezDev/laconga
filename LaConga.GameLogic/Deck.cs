using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConga.GameLogic
{
    public class Deck
    {
        private List<Card> Cards = new List<Card>();

        public Deck()
        {
            InitializeDeck();
            ShuffleDeck();
        }

        private void InitializeDeck()
        {
            var suits = new[] { "oro", "copa", "basto", "espada" };
            var values = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int i = 0;

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    Cards.Add(new Card(i++, suit, value));
                }
            }

            Cards.Add(new Card(i++, "comodin", 0));
            Cards.Add(new Card(i++, "comodin", 0));
        }

        private void ShuffleDeck()
        {
            Random rng = new Random(); // instance of random
            int n = Cards.Count; // total number of cards in the deck

            while (n > 1) // while there are more than 1 card in the deck
            {
                int k = rng.Next(n--); // random number between 0 and n-1

                var temp = Cards[n]; // temporarily stores the card at position n
                Cards[n] = Cards[k]; // swaps the card at position n with the card at position k
                Cards[k] = temp; // places the card that was at n into position k
            }
        }

        public Card DrawCard()
        {
            if (Cards.Count > 0)
            {
                Card card = Cards[^1];
                Cards.RemoveAt(Cards.Count - 1);
                return card;
            }
            return null;
        }

        public List<List<Card>> DealCards(int playersCount)
        {
            var hands = new List<List<Card>>();

            for (int i = 0; i < playersCount; i++)
            {
                hands.Add(new List<Card>());
                for (int j = 0; j < 7; j++)
                {
                    var card = DrawCard();
                    if (card != null)
                    {
                        hands[i].Add(card);
                    }
                }
            }
            return hands;
        }
    }
}
