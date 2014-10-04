using System;
// Write an expression that calculates trapezoid's area by given sides a and b and height h. 

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter side a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter h:");
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) * h / 2;
        Console.WriteLine("Trapezoid's area is {0}",area);
    }
}

