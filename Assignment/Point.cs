using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Point
    {

        public double X { get; set; }
        public double Y { get; set; }


        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }



        public double DistanceTo(Point delta)
        {
            double deltaX = X - delta.X;
            double deltaY = Y - delta.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

    }


}
