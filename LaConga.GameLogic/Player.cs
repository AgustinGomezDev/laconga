using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConga.GameLogic
{
    public class Player
    {
        private List<Card> Hand = new List<Card>();
        public int Id;

        public List<Card> GetHand()
        {
            return Hand;
        }
        public void SetHand(List<Card> cards)
        {
            Hand = cards;
        }

        public bool PlayCard(Card card)
        {
            if (Hand.Count < 8) return false;

            int index = Hand.FindIndex(c => c.Id == card.Id);
            if(index != -1)
            {
                Hand.RemoveAt(index);
                return true;
            }
            return false;
        }

        public void DrawCard(Card card)
        {
            Hand.Add(card);
        }
    }
}
