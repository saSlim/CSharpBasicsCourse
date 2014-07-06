using System;
using System.Globalization;
using System.Threading;

namespace Pr05.BiggestOf3Nums
{
    class BiggestOf3Nums
    {
        //        Problem 5. The Biggest of 3 Numbers
        //Write a program that finds the biggest of three numbers. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 5. The Biggest of 3 Numbers";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double a;
            double b;
            double c;
            double biggest;

            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("c = ");
            double.TryParse(Console.ReadLine(), out c);

            biggest = a;
            if (b > biggest)
            {
                biggest = b;
            }
            if (c > biggest)
            {
                biggest = c;
            }

            Console.WriteLine(biggest);

        }
    }
}
