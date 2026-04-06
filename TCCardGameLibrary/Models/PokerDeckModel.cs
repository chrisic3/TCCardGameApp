using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCardGameLibrary.Models
{
    public class PokerDeckModel : DeckModel
    {
        public PokerDeckModel()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }

        public void SwapCards(List<PlayingCardModel> hand, List<PlayingCardModel> discard)
        {
            foreach (PlayingCardModel card in discard)
            {
                discardPile.Add(card);
                hand.Remove(card);
                hand.Add(DrawOneCard());
            }
        }

        // Original version
        //public List<PlayingCardModel> SwapCards(List<PlayingCardModel> discard)
        //{
        //    List<PlayingCardModel> output = new List<PlayingCardModel>();

        //    foreach (PlayingCardModel card in discard)
        //    {
        //        discardPile.Add(card);
        //        output.Add(DrawOneCard());
        //    }

        //    return output;
        //}
    }
}
