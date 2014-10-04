using System;
using System.Numerics;
// In combinatorics, the number of ways to choose k different members out of a group of n different elements
// (also known as the number of combinations) is calculated by the following formula: n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
 


class CalcCombinations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        BigInteger FactorielNMinusK = 1;
        BigInteger result;
        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            factorielK *= i;
        }
        for (int i = 1; i <= n - k; i++)
        {
            FactorielNMinusK *= i;
        }
        result = factorielN / (factorielK * FactorielNMinusK);
        Console.WriteLine(result);
    }
}

