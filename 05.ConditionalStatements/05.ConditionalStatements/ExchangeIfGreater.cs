using System;
using System.Globalization;
using System.Threading;

namespace _05.ConditionalStatements
{
    class ExchangeIfGreater
    {
        //        Problem 1. Exchange If Greater
        //Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

        static void Main(string[] args)
        {
            Console.Title = "Pr01.ExchangeIfGreater";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;



                double a;
                double b;


                Console.Write("a = ");
                double.TryParse(Console.ReadLine(), out a);

                Console.Write("b = ");
                double.TryParse(Console.ReadLine(), out b);


                if (a > b)
                {
                    a += b;
                    b = a - b;
                    a = a - b;
                }

                Console.WriteLine(string.Format("{0} {1}", a, b));

        }
    }
}
