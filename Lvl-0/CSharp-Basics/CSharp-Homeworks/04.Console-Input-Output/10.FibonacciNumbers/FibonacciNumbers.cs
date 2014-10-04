using System;
// Write a program that reads a number n and prints on the console the first n members of the 
// Fibonacci sequence (at a single line, separated by spaces) : 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. 

class FibonacciNumbers
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int first = 0;
        int second = 1;
        int nextNum;
        Console.Write(first + " ");
        Console.Write(second + " ");
        for (int i = 0; i < numbers-2; i++)
        {
            nextNum = first + second;
            first = second;
            second = nextNum;
            Console.Write(nextNum + " ");
        }
    }
}

