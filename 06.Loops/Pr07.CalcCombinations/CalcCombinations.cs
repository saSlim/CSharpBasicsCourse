using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Pr07.CalcCombinations
{
    class CalcCombinations
    {



        //        Problem 7. Calculate N! / (K! * (N-K)!)
        //In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:

        //For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. 

        static void Main(string[] args)
        {

            Console.Title = "Problem 7. Calculate N! / (K! * (N-K)!)";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n;
            int k;
            BigInteger factN = 1;
            BigInteger factK = 1;
            BigInteger factNK = 1;

            do
            {
                Console.Write("Enter n: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n >= 100);

            do
            {
                Console.Write("Enter k: ");
                int.TryParse(Console.ReadLine(), out k);
            } while (k >= n);

            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    factK = factK * i;
                }
                factN = factN * i;
            }

            for (int i2 = 1; i2 <= n-k; i2++)
            {
                factNK = factNK * i2;
            }

            Console.WriteLine("n!/(k!*(n-k)!) = {0}", factN / (factK * factNK));

        }
    }
}
