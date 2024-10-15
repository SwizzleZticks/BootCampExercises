using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise60
{
    public class Card
    {
        public enum Rank
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            King,
            Queen,
            Ace
        }
        public enum Suit
        {
            Spades,
            Diamonds,
            Hearts,
            Clubs
        }

        private Rank _rank;
        private Suit _suit;

        public Rank CardRank 
        {
            get { return _rank; }
            set {  _rank = value; }
        }
        public Suit CardSuit 
        { 
            get { return _suit; } 
            set { _suit = value; }
        }

        public Card(Rank rank, Suit suit)
        {
            _suit = suit;
            _rank = rank;
        }

        public override string ToString()
        {
            return $"{_rank} of {_suit}";
        }
    }
}
