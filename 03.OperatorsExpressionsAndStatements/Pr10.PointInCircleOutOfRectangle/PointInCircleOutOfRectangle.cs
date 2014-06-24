using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr10.PointInCircleOutOfRectangle
{
    class PointInCircleOutOfRectangle
    {
        //Problem 10. Point Inside a Circle & Outside of a Rectangle
        //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 

        static void Main(string[] args)
        {
            Console.Title = "Problem 10. Point Inside a Circle & Outside of a Rectangle";

            double x;
            double y;

            Console.WriteLine("Enter value for x:");
            double.TryParse(Console.ReadLine(), out x);

            Console.WriteLine("Enter value for y:");
            double.TryParse(Console.ReadLine(), out y);

            //(x - center_x)^2 + (y - center_y)^2 < radius^2.
            bool isInside = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow((1.5), 2);

            Console.WriteLine("inside K & outside of R: {0}", (isInside && y > 1)? "yes":"no");
        }
    }
}
