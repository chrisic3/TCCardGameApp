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
        private List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();
        private List<PlayingCardModel> drawPile = new List<PlayingCardModel>();
        private List<PlayingCardModel> discardPile = new List<PlayingCardModel>();

        protected void CreateDeck()
        {
            fullDeck.Clear();

            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 0; value < 13; value++)
                {
                    fullDeck.Add(new PlayingCardModel() { Suit = (CardSuit)suit, Value = (CardValues)value });
                }
            }
        }

        protected virtual void ShuffleDeck()
        {

        }

        // Abstract because each game type deals differently
        public abstract List<PlayingCardModel> DealCards();

        protected PlayingCardModel DrawOneCard()
        {
            throw new NotImplementedException();
        }
    }
}
