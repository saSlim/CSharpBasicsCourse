using System;

namespace _06.Loops
{
    class NumsFrom1ToN
    {

        //        Problem 1. Numbers from 1 to N
        //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

        static void Main(string[] args)
        {

            Console.Title = "Problem 1. Numbers from 1 to N";

            int n;
            string output = string.Empty;

            Console.Write("Enter n: ");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    output += i;
                }
                else
                {
                    output += " " + i;
                }
            }

            Console.WriteLine(output);

        }
    }
}
