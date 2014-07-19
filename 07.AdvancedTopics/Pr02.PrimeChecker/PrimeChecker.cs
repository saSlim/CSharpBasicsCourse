using System;

namespace Pr02.PrimeChecker
{
    class PrimeChecker
    {
        //        Problem 2. Prime Checker
        //Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 2. Prime Checker";

            long n;
            long.TryParse(Console.ReadLine(), out n);

            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            bool isPrime = true;
            int boundary = (int)Math.Floor(Math.Sqrt(n));

            if (n == 0 || n == 1)
                isPrime = false;

            for (int i = 2; i <= boundary; ++i)
            {
                if (n % i == 0)
                    isPrime = false;
            }
            return isPrime;
        }


    }

}
