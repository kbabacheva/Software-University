using System;
// Write an expression that calculates rectangle’s perimeter and area by given width and height

class AreaAndPerimeter
{
    static void Main()
    {
        Console.WriteLine("Enter rectange's width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle's height:");
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = 2*(width + height);
        Console.WriteLine("Rectangle's area is {0:0.00} and its perimeter is {1:0.00}", area, perimeter);
    }
}

