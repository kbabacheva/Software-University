using System;
// Write a program that reads the radius r of a circle and prints its perimeter 
// and area formatted with 2 digits after the decimal point.

class PerimeterArea
{
    static void Main()
    {
        Console.WriteLine("Enter raduis =");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("The perimeter is {0:f2} and the area is {1:f2}", perimeter,area);
    }
}

