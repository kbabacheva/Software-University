using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Point
    {
        private static readonly Point startPoint;

        private double x;
        private double y;
        private double z;

        static Point()
        {
            startPoint = new Point(0, 0, 0);
        }

        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point StartPoint { get { return Point.startPoint; } }

        public double X {
            get { return this.x; }
            set { this.x = value; } 
        }

        public double Y {
            get { return this.y; }
            set { this.y = value; } 
        }

        public double Z {
            get { return this.z; }
            set { this.z = value; } 
        }

        public override string ToString()
        {
            string toStr = "Point: {" + this.X + ", " + this.Y + ", " + this.Z + "}";
            return toStr;
        }
    }
}
