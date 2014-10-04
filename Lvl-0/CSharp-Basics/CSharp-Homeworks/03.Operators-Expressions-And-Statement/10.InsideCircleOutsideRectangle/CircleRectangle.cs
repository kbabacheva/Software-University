using System;
// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
// and out of the rectangle R(top=1, left=-1, width=6, height=2). 

class CircleRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter value for x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for y:");
        double y = double.Parse(Console.ReadLine());
        double xy = (x-1)*(x-1) + (y-1)*(y-1);
        bool circle = xy < (1.5 * 1.5);
        bool circleRectangle = xy < 2.25 && y > 1;
        Console.WriteLine("The point is inside the circle and out of the rectangle: {0}",circleRectangle);
    }
}

