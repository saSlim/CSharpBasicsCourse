using System;

namespace Pr11.RandomNumsInRange
{
    class RandomNumsInRange
    {


        //        Problem 11. Random Numbers in Given Range
        //Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].

        static Random random = new Random();
        
        static void Main(string[] args)
        {
            Console.Title = "Problem 11. Random Numbers in Given Range";

            int n;
            int min;
            int max;

            string output = string.Empty;

            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out min);
            int.TryParse(Console.ReadLine(), out max);

            for (int i = 0; i < n; i++)
            {
                output += random.Next(min, max + 1) + " ";
            }

            Console.WriteLine(output);
        }
    }
}
