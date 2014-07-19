using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Pr17.PerimeterAndArea
{
    class PerimeterAndArea
    {
        //        Problem 17. * Perimeter and Area of Polygon
        //Write a program that calculates the perimeter and the area of given polygon (not necessarily convex) consisting of n floating-point coordinates in the 2D plane. Print the result rounded to two decimal digits after the decimal point. Use the input and output format from the examples. To hold the points, define a class Point(x, y). To hold the polygon use a Polygon class which holds a list of points. Find in Internet how to calculate the polygon perimeter and how to calculate the area of a polygon.

        static void Main(string[] args)
        {
            Console.Title = "Problem 17. * Perimeter and Area of Polygon";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<Point> pointList = new List<Point>();

            int pointsNumber = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < pointsNumber; i++)
            {
                int[] coordinates = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                Point p = new Point(coordinates[0], coordinates[1]);
                pointList.Add(p);
            }

            Polygon polygon = new Polygon(pointList);

            Console.WriteLine("perimeter = {0:0.##}", polygon.Perimeter());
            Console.WriteLine("area = {0:0.##}", polygon.Area());
        }

    }
}
