using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class BasicShape:IShape
    {
        private double width;
        private double height;

        public BasicShape(double width)
        {
            this.Width = width;
            this.Height = height;
        }

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width 
        {
            get { return this.width; } 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Width cannot be empty");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
