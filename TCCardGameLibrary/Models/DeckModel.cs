using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCardGameLibrary.Enums;

namespace TCCardGameLibrary.Models
{
    public abstract class DeckModel
    {
        protected List<PlayingCardModel> deck = new List<PlayingCardModel>();
        //private List<PlayingCardModel> drawPile = new List<PlayingCardModel>();
        protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();

        protected void CreateDeck()
        {
            deck.Clear();

            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 0; value < 13; value++)
                {
                    deck.Add(new PlayingCardModel() { Suit = (CardSuit)suit, Value = (CardValues)value });
                }
            }
        }

        public virtual void ShuffleDeck()
        {
            Random rand = new Random();
            deck = deck.OrderBy(x => rand.Next()).ToList();
        }

        // Abstract because each game type deals differently
        public abstract List<PlayingCardModel> DealCards();

        protected PlayingCardModel DrawOneCard()
        {
            //PlayingCardModel output = deck.Take(1).First();
            PlayingCardModel output = deck[0];
            deck.Remove(output);
            return output;
        }
    }
}
