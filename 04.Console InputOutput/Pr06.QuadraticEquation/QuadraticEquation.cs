using System;
using System.Globalization;
using System.Threading;

namespace Pr06.QuadraticEquation
{
    class QuadraticEquation
    {

        //        Problem 6. Quadratic Equation
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 
        static void Main(string[] args)
        {
            Console.Title = "Problem 6. Quadratic Equation";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            double a;
            double b;
            double c;
            double x1;
            double x2;
            double insideRoot;

            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("c = ");
            double.TryParse(Console.ReadLine(), out c);

            insideRoot = Math.Pow(b, 2) - (4 * a * c);

            if (insideRoot < 0)
            {
                Console.WriteLine("No real roots!");
                return;
            }

            x1 = (-b - Math.Sqrt(insideRoot)) / (2 * a);
            x2 = (-b + Math.Sqrt(insideRoot)) / (2 * a);

            if (x1 == x2)
            {
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }

        }
    }
}
