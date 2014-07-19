using System;
using System.Collections.Generic;

namespace Pr03.PrimesInRange
{
    class PrimesInRange
    {

        //        Problem 3. Primes in Given Range
        //Write a method that calculates all prime numbers in given range and returns them as list of integers:
        //static List<int> FindPrimesInRange(startNum, endNum)
        //{
        //    …
        //}
        //Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.

        static void Main(string[] args)
        {
            int a;
            int b;

            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            PrintIntList(FindPrimesInRange(a, b));

        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> temp = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                int boundary = (int)Math.Floor(Math.Sqrt(i));

                if (i == 0 || i == 1)
                    isPrime = false;

                for (int j = 2; j <= boundary; ++j)
                {
                    if (i % j == 0)
                        isPrime = false;
                }

                if (isPrime)
                {
                    temp.Add(i);
                }
            }
            return temp;
        }

        static void PrintIntList(List<int> intList)
        {
            Console.WriteLine(String.Join(", ", intList));
        }
    }
}
