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
        }

        public override List<PlayingCardModel> DealCards()
        {
            throw new NotImplementedException();
        }
    }
}
