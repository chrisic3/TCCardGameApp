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
        // internal so that other classes in the assembly can use it but not the ui
        internal CardSuit Suit { get; set; }
        internal CardValues Value { get; set; }
    }
}
