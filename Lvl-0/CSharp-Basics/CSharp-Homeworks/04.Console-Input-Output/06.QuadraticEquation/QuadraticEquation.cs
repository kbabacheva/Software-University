using System;
// Write a program that reads the coefficients a, b and c of a quadratic equation 
// ax2 + bx + c = 0 and solves it (prints its real roots). 

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double discriminant = b * b - 4 * a * c;
        if (discriminant<0)
        {
            Console.WriteLine("There are no real roots");
        }
        if (discriminant==0)
        {
            double result = -b/(2*a);
            Console.WriteLine("There is 1 real root: {0}",result);
        }
        if (discriminant>0)
        {
            double result1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double result2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("There are 2 real roots: {0} and {1}",result1,result2);
        }
    }
}

