using System;
// Write a program that finds the biggest of five numbers by using only five if statements. 

class BiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter first number = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter thirdnumber = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter forth number = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter fifth number = ");
        double e = double.Parse(Console.ReadLine());

        if (a>=b && a>=c && a>=d && a>=e)
        {
            Console.WriteLine(a);
        }
        else if (b>=a && b>=c && b>=d & b>=e)
        {
            Console.WriteLine(b);
        }
        else if (c>=a && c>=b && c>=d && c>=e)
        {
            Console.WriteLine(c);
        }
        else if (d>=a && d>=b && d>=c && d>=e)
        {
            Console.WriteLine(d);
        }
        else if (e>=a && e>=b && e>=c && e>=d)
        {
            Console.WriteLine(e);
        }
    }
}

