using System;

namespace Pr17.PerimeterAndArea
{
    class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public double Distance(Point p2)
        {
            double x1 = this.X;
            double y1 = this.Y;
            double x2 = p2.X;
            double y2 = p2.Y;
            double distance = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
            return distance;
        }
    }

}
