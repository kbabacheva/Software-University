using System;
// Write a program that reads 3 numbers from the console and prints their sum.

class Sum3Integers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers:");
        Console.WriteLine("Number 1");
        double one = double.Parse(Console.ReadLine());
        Console.WriteLine("Number 2");
        double two = double.Parse(Console.ReadLine());
        Console.WriteLine("Number 3");
        double three = double.Parse(Console.ReadLine());
        double sum = one + two + three;
        Console.WriteLine(sum);
    }
}

