using System;
// Write a program that gets two numbers from the console and prints the greater of them. 
// Try to implement this without if statements. 

class NumberComparer
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        double ab = a > b ? a : b;
        Console.WriteLine("The greater number is {0}", ab);
    }
}

