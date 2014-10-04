using System;
// Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 

class RandomNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); ;
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        var r = new Random();
        for (int i = 0; i < n; i++)
        {
        Console.Write("{0} ", r.Next(min, max));
        }
    }
}
