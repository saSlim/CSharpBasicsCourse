using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pr04.MultiplicationSign
{
    class MultiplicationSign
    {
        //Problem 4. Multiplication Sign
        //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators.

        static void Main(string[] args)
        {
            Console.Title = "Problem 4. Multiplication Sign";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double a;
            double b;
            double c;
            int sign = 0;

            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("c = ");
            double.TryParse(Console.ReadLine(), out c);

            if (a < 0)
            {
                sign++;
            }

            if (b < 0)
            {
                sign++;
            }

            if (c < 0)
            {
                sign++;
            }

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if (sign == 0 || sign % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }


        }
    }
}
