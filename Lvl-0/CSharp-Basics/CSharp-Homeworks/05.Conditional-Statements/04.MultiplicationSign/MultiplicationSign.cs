using System;
// Write a program that shows the sign (+, - or 0) of the product of three real numbers,
// without calculating it. Use a sequence of if operators. 

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double result = a*b*c;

        if (result > 0)
        {
            Console.WriteLine("+");
        }
        else if (result == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}

