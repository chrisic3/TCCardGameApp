using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCardGameLibrary.Enums;

namespace TCCardGameLibrary.Models
{
    public class PlayingCardModel
    {
        public CardValues Value { get; internal set; }
        public CardSuit Suit { get; internal set; }
    }
}
