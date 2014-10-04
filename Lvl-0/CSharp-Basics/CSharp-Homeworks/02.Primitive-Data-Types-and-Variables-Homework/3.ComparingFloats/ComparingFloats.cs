using System;
// Write a program that safely compares floating-point numbers with precision eps = 0.000001. 
// Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature 
// of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely 
// to each other than a fixed constant eps.

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Print your first number:");
        decimal firstNumber = (decimal.Parse(Console.ReadLine()));
        Console.WriteLine("Print your second number:");
        decimal secondNumber = (decimal.Parse(Console.ReadLine()));
        bool comparing = (Math.Abs(firstNumber - secondNumber) < 0.000001m);
        Console.WriteLine(comparing);
    }
}

