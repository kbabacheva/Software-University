using System;
// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
// Use only one loop. Print the result with 5 digits after the decimal point.

class Factoriel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double powXN = 1;
        double result = 1;
        double factoriel = 1;
        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            powXN *= x;
            result += factoriel / powXN;
        }
        Console.WriteLine("{0:0.00000}",result);
    }
}

