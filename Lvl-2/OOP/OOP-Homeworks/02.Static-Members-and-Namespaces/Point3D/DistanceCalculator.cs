using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point a, Point b)
        {
            double x = Math.Pow((b.X - a.X),2);
            double y = Math.Pow((b.Y - a.Y), 2);
            double z = Math.Pow((b.Z - a.Z), 2);
            double result = Math.Sqrt(x + y + z);
            return result;
        }
    }
}
