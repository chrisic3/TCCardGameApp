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
            Console.Write("Which game demo would you like to see? (poker/blackjack): ");
            string input = Console.ReadLine();
            Console.WriteLine();

            if (input.ToLower() == "poker")
            {
                PokerDeckModel poker = new PokerDeckModel();
                List<PlayingCardModel> hand = poker.DealCards();

                // Display initial hand
                Console.WriteLine("Initial hand:");
                foreach (PlayingCardModel card in hand)
                {
                    Console.WriteLine($"{card.Value} of {card.Suit}");
                }

                Console.WriteLine();

                // Cards selected to discard
                int[] cardsToDiscard = { 2, 4 };
                Console.WriteLine("Swapping cards at index's 2 and 4:");

                List<PlayingCardModel> discard = new List<PlayingCardModel>();
                foreach (int card in cardsToDiscard) // Populate list of cards to discard
                {
                    discard.Add(hand[card]);
                }

                // Swap cards and add new ones to hand
                poker.SwapCards(hand, discard);

                // Display new hand
                foreach (PlayingCardModel card in hand)
                {
                    Console.WriteLine($"{card.Value} of {card.Suit}");
                }
            }
            else if (input.ToLower() == "blackjack")
            {
                BlackjackDeckModel blackjack = new BlackjackDeckModel();
                List<PlayingCardModel> hand = blackjack.DealCards();

                // Display initial hand
                Console.WriteLine("Initial hand:");
                foreach (PlayingCardModel card in hand)
                {
                    Console.WriteLine($"{card.Value} of {card.Suit}");
                }

                Console.WriteLine();

                Console.Write("Would you like to hit? (yes/no): ");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "yes")
                {
                    blackjack.Hit(hand);
                }

                Console.WriteLine();

                Console.WriteLine("Final hand:");
                foreach (PlayingCardModel card in hand)
                {
                    Console.WriteLine($"{card.Value} of {card.Suit}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
