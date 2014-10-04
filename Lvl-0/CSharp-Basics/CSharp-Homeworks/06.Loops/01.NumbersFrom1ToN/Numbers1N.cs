using System;
// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. 

class Numbers1N
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
    }
}

