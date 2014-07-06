using System;
using System.Globalization;
using System.Threading;

namespace Pr07.Sort3Nums
{
    class Sort3Nums
    {

        //        Problem 7. Sort 3 Numbers with Nested Ifs
        //Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality

        static void Main(string[] args)
        {
            Console.Title = "Problem 7. Sort 3 Numbers with Nested Ifs";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double a;
            double b;
            double c;

            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("c = ");
            double.TryParse(Console.ReadLine(), out c);

            if (a < b)
            {
                if (b < c)
                {
                    c += b;
                    b = c - b;
                    c = c - b;
                }

                b += a;
                a = b - a;
                b = b - a;
            }

            if (b < c)
            {
                c += b;
                b = c - b;
                c = c - b;

                if (a < b)
                {
                    b += a;
                    a = b - a;
                    b = b - a;
                }
            }

            Console.WriteLine("{0} {1} {2} ", a, b, c);
        }
    }
}
