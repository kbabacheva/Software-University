using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger first = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger second = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger third = new BigInteger(int.Parse(Console.ReadLine()));
        int n = int.Parse(Console.ReadLine());
        BigInteger next = 0;
        if (n == 1)
        {
            Console.WriteLine(first);
        }
        if (n == 2)
        {
            Console.WriteLine(second);
        }
        if (n == 3)
        {
            Console.WriteLine(third);
        }
        if (n > 3)
        {
            for (int i = 4; i <= n; i++)
            {
                next = first + second + third;
                first = second;
                second = third;
                third = next;
            }
            Console.WriteLine(third);
        }
    }
}

