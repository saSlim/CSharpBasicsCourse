using System;
using System.Globalization;
using System.Threading;

namespace Pr05.Calculate
{
    class Calculate
    {

        //        Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
        //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.

        static void Main(string[] args)
        {
            Console.Title = "Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n;
            int x;
            int fact=1;
            double s=1;

            Console.Write("Enter n: ");
            int.TryParse(Console.ReadLine(), out n);

            Console.Write("Enter x: ");
            int.TryParse(Console.ReadLine(), out x);

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
                s += fact / Math.Pow(x, i);
            }
            Console.WriteLine("{0:0.00000}",s);

        }
    }
}
