using System;

namespace Pr18.TrailingZeroesInNFact
{
    class TrailingZeroesInNFact
    {

        //        Problem 18. * Trailing Zeroes in N!
        //Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000.

        static void Main(string[] args)
        {
            Console.Title = "Problem 18. * Trailing Zeroes in N!";

            int n;
            int trail=0;

            int.TryParse(Console.ReadLine(), out n);

            for (int i = 5; (n / i) >= 1; i *= 5)
            {
                
                trail += (n / i);
            }

            Console.WriteLine(trail);
        }
    }
}
