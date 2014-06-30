using System;

namespace Pr03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        //Problem 3. Circle Perimeter and Area
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
        static void Main(string[] args)
        {

            Console.Title = "Problem 3. Circle Perimeter and Area";

            double r;
            double perimeter;
            double area;

            Console.Write("Please enter circle radius: ");
            double.TryParse(Console.ReadLine(), out r);

            area = Math.PI * Math.Pow(r, 2);
            perimeter = 2 * Math.PI * r;

            Console.WriteLine("The area is {0:F2} and the perimeter is {1:F2}", area, perimeter);

        }
    }
}
