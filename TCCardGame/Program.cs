using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCardGameLibrary.Models;

namespace TCCardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PokerDeckModel poker = new PokerDeckModel();
            List<PlayingCardModel> hand = poker.DealCards();

            // Display initial hand
            foreach (PlayingCardModel card in hand)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }

            Console.WriteLine();

            // Cards selected to discard
            int[] cardsToDiscard = { 2, 4 };

            List<PlayingCardModel> discard = new List<PlayingCardModel>();
            foreach (int card in cardsToDiscard) // Populate list of cards to discard
            {
                discard.Add(hand[card]);
            }

            // Remove cards from hand
            foreach (PlayingCardModel card in discard)
            {
                hand.Remove(card);
            }

            // TODO: swap cards and add new ones to hand
            
            // Display new hand
            foreach (PlayingCardModel card in hand)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }

            Console.ReadLine();
        }
    }
}
