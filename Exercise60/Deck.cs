using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Exercise60
{
    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();

            foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                {
                    cards.Add(new Card(rank, suit));
                }
            }
        }

        public void Shuffle()
        {
            int cardCount = cards.Count;

            for (int i = cardCount - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card DrawCard()
        {
            if (cards.Count == 0)
            {
                return null;
            }

            Card topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
        }
    }
}
