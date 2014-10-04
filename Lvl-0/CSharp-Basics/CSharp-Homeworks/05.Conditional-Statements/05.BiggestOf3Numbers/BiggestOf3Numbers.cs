using System;
// Write a program that finds the biggest of three numbers. 

class BiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a>b && a>c)
        {
            Console.WriteLine(a);
        }
        else if (b>a && b>c)
        {
            Console.WriteLine(b);
        }
        else if (c>a && c>b)
        {
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine("There are 2 bigger numbers");
        }
    }
}

