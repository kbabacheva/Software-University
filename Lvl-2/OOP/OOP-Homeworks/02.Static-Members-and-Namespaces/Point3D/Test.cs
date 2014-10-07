using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Test
    {
        static void Main()
        {
            Point point = new Point(2,3,4);
            Console.WriteLine(point);
            Console.WriteLine(Point.StartPoint);

            Point a = new Point(-7, -4, 3);
            Point b = new Point(17,6,2.5);
            Console.WriteLine(DistanceCalculator.CalculateDistance(a,b));
        }
    }
}
