using System;

namespace Pr08.PrimeNumCheck
{
    class PrimeNumCheck
    {

        //        Problem 8. Prime Number Check
        //Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1)

        static void Main()
        {
            Console.Title = "Prime number check";

            int n = new int();

            bool isPrime = true;

            do
            {
                Console.WriteLine("Please enter number between 0-100:");
            } while (!(int.TryParse(Console.ReadLine(), out n) && n >= 0 && n <= 100));

            int boundary = (int)Math.Floor(Math.Sqrt(n));

            if (n == 0 || n == 1)
                isPrime = false;

            if (n == 2)
                isPrime = true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (n % i == 0)
                    isPrime = false;
            }

            Console.WriteLine("The number \'{0}\' {1}!", n, isPrime ? "is prime" : "is not prime");

        }
    }
}
