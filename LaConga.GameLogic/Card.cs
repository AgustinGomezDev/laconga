using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConga.GameLogic
{
    public class Card
    {
        public int Id { get; set; }
        public string Suit {  get; set; }
        public int Value {  get; set; }

        public Card(int id, string suit, int value)
        {
            Id = id;
            Suit = suit;
            Value = value;
        }
    }
}
