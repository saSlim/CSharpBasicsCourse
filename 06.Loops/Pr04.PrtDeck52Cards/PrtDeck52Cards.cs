using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04.PrtDeck52Cards
{
    class PrtDeck52Cards
    {

        //        Problem 4. Print a Deck of 52 Cards
        //Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

        //I don't see the need of switch-case! 

        static void Main(string[] args)
        {
            Console.Title = "Problem 4. Print a Deck of 52 Cards";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            char[] colors = { '♣', '♦', '♥', '♠' };
            string output = string.Empty;

            for (int i = 0; i < cards.Length; i++)
            {
                output = string.Empty;
                for (int n = 0; n < colors.Length; n++)
                {
                    output += cards[i].PadLeft(2,' ') + colors[n] + " ";
                }
                Console.WriteLine(output);
            }

        }
    }
}
