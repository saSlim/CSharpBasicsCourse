using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pr06.BiggestOf5Nums
{
    class BiggestOf5Nums
    {

        //        Problem 6. The Biggest of Five Numbers
        //Write a program that finds the biggest of five numbers by using only five if statements. 
        static void Main(string[] args)
        {
            Console.Title = "Problem 6. The Biggest of 5 Numbers";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double a;
            double b;
            double c;
            double d;
            double e;
            double biggest;

            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("c = ");
            double.TryParse(Console.ReadLine(), out c);

            Console.Write("d = ");
            double.TryParse(Console.ReadLine(), out d);

            Console.Write("e = ");
            double.TryParse(Console.ReadLine(), out e);

            biggest = a;
            if (b > biggest)
            {
                biggest = b;
            }
            if (c > biggest)
            {
                biggest = c;
            }
            if (d > biggest)
            {
                biggest = d;
            }
            if (e > biggest)
            {
                biggest = e;
            }

            Console.WriteLine(biggest);

        }
    }
}
