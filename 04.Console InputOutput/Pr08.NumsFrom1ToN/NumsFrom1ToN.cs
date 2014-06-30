using System;

namespace Pr08.NumsFrom1ToN
{
    class NumsFrom1ToN
    {

        //        Problem 8. Numbers from 1 to n
        //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop.

        static void Main(string[] args)
        {
            Console.Title = " Problem 8. Numbers from 1 to n";

            int n;

            Console.Write("n = ");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 1; i < (n + 1); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
