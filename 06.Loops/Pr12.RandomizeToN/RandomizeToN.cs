using System;

namespace Pr12.RandomizeToN
{
    class RandomizeToN
    {

        //        Problem 12. * Randomize the Numbers 1…N
        //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.Title = "Problem 12. * Randomize the Numbers 1…N";

            int n;
            string output = string.Empty;

            int.TryParse(Console.ReadLine(), out n);

            for (int i = 0; i < n; i++)
            {
                output += random.Next(1, n + 1) + " ";
            }
            Console.WriteLine(output);
        }
    }
}
