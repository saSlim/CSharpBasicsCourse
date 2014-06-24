using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr07.PointInCircle
{
    class PointInCircle
    {
        //        Problem 7. Point in a Circle
        //Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 


        static void Main()
        {
            Console.Title = "Point in circle";


            double x;
            double y;

            Console.WriteLine("Enter value for x:");
            double.TryParse(Console.ReadLine(), out x);

            Console.WriteLine("Enter value for y:");
            double.TryParse(Console.ReadLine(), out y);

            //(x - center_x)^2 + (y - center_y)^2 < radius^2.
            bool isInside = x * x + y * y <= 4;

            Console.WriteLine("The point is{0} in the circle!", isInside ? "" : " not");

        }
    }
}
