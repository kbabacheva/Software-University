using System;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long currentNumber, result = 0;
        for (int i = 0; i < n; i++)
        {
            currentNumber = long.Parse(Console.ReadLine());
            result ^= currentNumber;
        }
        Console.WriteLine(result);
    }
}

