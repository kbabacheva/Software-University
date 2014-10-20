using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle:BasicShape
    {
        public Circle(double width):base(width) //if we asume width is radius
        {
            
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Width, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Width;
        }

    }
}
