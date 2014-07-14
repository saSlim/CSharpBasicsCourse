using System;

namespace Pr17.CalcGCD
{
    class CalcGCD
    {

        //        Problem 17. * Calculate GCD
        //Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean algorithm (find it in Internet). 

        static void Main(string[] args)
        {
            Console.Title = "Problem 17. * Calculate GCD";

            int a;
            int b;
            int rem;
            int gcd;

            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            if (a < b)
            {
                b += a;
                a = b - a;
                b = b - a;
            }

            rem = a;

            while (rem > 0)
            {
                rem = a % b;
                a = b;
                b = rem;
            }
            gcd = a;
            
            Console.WriteLine("{0}", gcd);
        }
    }
}
