using System;
// Write a program that reads two positive integer numbers and prints how many numbers p exist between 
// them such that the reminder of the division by 5 is 0. 

class DividableByGivenNumber
{
    static void Main()
    {
        Console.Write("First number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int second = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = first; i <= second; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + " ");
                p++;
            }
        }
        Console.WriteLine();
        Console.WriteLine(p);
    }
}

