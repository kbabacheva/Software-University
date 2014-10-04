using System;
using System.Numerics;
// In combinatorics, the Catalan numbers are calculated by the following formula:
// (2n)! / (n+1)! * n!. Write a program to calculate the nth Catalan number by given n (1 < n < 100).

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactoriel = 1;
        BigInteger N2Factoriel = 1;
        BigInteger NPlus1Factoriel = 1;
        BigInteger result;
        for (int i = 1; i <= n; i++)
        {
            nFactoriel *= i;
        }
        for (int i = 1; i <= 2*n; i++)
        {
            N2Factoriel *= i;
        }
        for (int i = 1; i <= n+1; i++)
        {
            NPlus1Factoriel *= i;
        }
        result = N2Factoriel/(NPlus1Factoriel * nFactoriel);
        Console.WriteLine(result);
    }
}

