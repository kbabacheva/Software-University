using System;
using System.Linq;
// Write a program that enters 5 numbers (given in a single line, separated by a space), 
// calculates and prints their sum. 

class Sum5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter numbers:");
        string numbers = Console.ReadLine();
        string[] split = numbers.Split(' ');
        double result = 0;
        for (int i = 0; i < split.Length ; i++)
        {
            result += Convert.ToDouble(split[i]);
        }
        Console.WriteLine("Result: {0}", result);
    }
}

