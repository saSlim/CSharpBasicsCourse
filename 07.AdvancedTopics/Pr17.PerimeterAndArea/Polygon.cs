using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr17.PerimeterAndArea
{
    class Polygon
    {
        private List<Point> pointsList = new List<Point>();

        public Polygon(List<Point> point)
        {
            this.pointsList = new List<Point>(point);
        }

        public double Area()
        {
            this.pointsList.Add(this.pointsList[0]);
            var area = Math.Abs(this.pointsList.Take(this.pointsList.Count - 1)
               .Select((p, i) => (this.pointsList[i + 1].X - p.X) * (this.pointsList[i + 1].Y + p.Y))
               .Sum() / 2);
            return area;
        }

        public double Perimeter()
        {
            this.pointsList.Add(this.pointsList[0]);
            double perimeter = 0;
            for (int i = 0; i < this.pointsList.Count - 1; i++)
            {
                Point p1 = this.pointsList[i];
                Point p2 = this.pointsList[i + 1];
                perimeter += p1.Distance(p2);
            }

            return perimeter;
        }

    }

}
