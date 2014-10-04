using System;
using System.Numerics;
// Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

class CalcNDividedK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        
        for (int i = k + 1; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}
