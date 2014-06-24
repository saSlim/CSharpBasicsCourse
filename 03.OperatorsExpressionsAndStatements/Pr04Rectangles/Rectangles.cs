using System;

namespace Pr04Rectangles
{
    class Rectangles
    {
        //        Problem 4. Rectangles
        //Write an expression that calculates rectangle’s perimeter and area by given width and height.

        static void Main(string[] args)
        {
            Console.Title = "Rectangles";

            double w;
            double h;

            double perimeter;
            double area;

            Console.WriteLine("Please enter width:");
            double.TryParse(Console.ReadLine(), out w);

            Console.WriteLine("Please enter height:");
            double.TryParse(Console.ReadLine(), out h);

            perimeter = w * 2 + h * 2;
            area = h * w;

            Console.WriteLine("Rectangle perimeter is {0} and area is {1}.", perimeter, area);

        }
    }
}
