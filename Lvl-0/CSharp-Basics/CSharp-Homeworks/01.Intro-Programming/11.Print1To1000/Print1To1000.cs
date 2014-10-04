using System;
// Write a program that prints at the console the numbers from 1 to 1000, each at a separate line. 

class Print1To1000
{
    static void Main()
    {
        Console.BufferHeight = 1001;
        for (int i = 1; i < 1001; i++)
        {
            Console.WriteLine(i);
        }
    }
}

