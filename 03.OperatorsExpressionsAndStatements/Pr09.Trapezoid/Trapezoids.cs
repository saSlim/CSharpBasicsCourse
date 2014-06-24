using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr09.Trapezoid
{
    class Trapezoids
    {
        //        Problem 9. Trapezoids
        //Write an expression that calculates trapezoid's area by given sides a and b and height h.
        static void Main(string[] args)
        {
            Console.Title = " Problem 9. Trapezoids";

            double a;
            double b;
            double h;
            double area;

            do
            {
                Console.WriteLine("Please enter a = ");
                
            } while (!double.TryParse(Console.ReadLine(),out a));

            do
            {
                Console.WriteLine("Please enter b = ");

            } while (!double.TryParse(Console.ReadLine(), out b));

            do
            {
                Console.WriteLine("Please enter h = ");

            } while (!double.TryParse(Console.ReadLine(), out h));

            area = (a + b) / 2 * h;
            Console.WriteLine("The area of the trapezoid is {0}", area);

        }
    }
}
