using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCardGameLibrary.Models
{
    public class BlackjackDeckModel : DeckModel
    {
        public BlackjackDeckModel()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }

        public void Hit(List<PlayingCardModel> hand)
        {
            hand.Add(DrawOneCard());
        }
    }
}
