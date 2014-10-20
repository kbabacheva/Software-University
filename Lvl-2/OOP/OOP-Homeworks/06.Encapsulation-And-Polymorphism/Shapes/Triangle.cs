using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle:BasicShape
    {
        public Triangle(double width, double height):base(width,height)
        {

        }

        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;     
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.Height;
        }
    }
}
