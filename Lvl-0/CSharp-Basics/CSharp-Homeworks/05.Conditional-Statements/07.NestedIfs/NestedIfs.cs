using System;
// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements. Don’t use arrays and the built-in sorting functionality. 

class NestedIfs
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        if (a>=b)
        {
            if (a>=c)
            {
                if (b>=c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else if (c>=b)
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            if (c>=a)
            {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        if (b>=c)
        {
            if (b>=a)
            {
                if (a>=c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else if (c>=a)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
        }
        if (c>=a)
        {
            if (c>=b)
            {
                if (a<=b)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
        }
    }
}

