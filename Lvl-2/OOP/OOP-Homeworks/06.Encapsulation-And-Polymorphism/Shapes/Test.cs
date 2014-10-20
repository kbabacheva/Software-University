using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Test
    {
        public static void Main()
        {
            BasicShape rect = new Rectangle(2,4);
            BasicShape rect2 = new Rectangle(2.5, 6.4);
            BasicShape circ = new Circle(2.2);
            BasicShape circ2 = new Circle(2.2);
            BasicShape tr = new Triangle(0.5, 3);
            BasicShape tr2 = new Triangle(5,4);
            IList<BasicShape> figures = new List<BasicShape>()
            {
                rect,
                rect2,
                circ,
                circ2,
                tr,
                tr2
            };
            foreach (var item in figures)
            {
                Console.WriteLine("I am a " + item.GetType().Name + ". My area is: " + item.CalculateArea() + ". My perimeter is: " + item.CalculatePerimeter());
            }
        }
    }
}
