using System;
// Write an if-statement that takes two integer variables a and b and exchanges their values 
// if the first one is greater than the second one. As a result print the values a and b, separated by a space. 

class ExchangeGreater
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        double c = 0;
        if (a>b)
        {
            c = b;
            b = a;
            a = c;
            Console.WriteLine("{0} {1}",a,b);
        }
        else
        {
            Console.WriteLine("{0} {1}",a,b);
        }
    }
}

