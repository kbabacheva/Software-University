using System;
// Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter value for x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for y:");
        double y = double.Parse(Console.ReadLine());
        double xy = x*x + y*y;
        bool circle = (xy <= 4);
        {
            Console.WriteLine("The point is inside of the circle:{0}", circle);
        }

    }
}

