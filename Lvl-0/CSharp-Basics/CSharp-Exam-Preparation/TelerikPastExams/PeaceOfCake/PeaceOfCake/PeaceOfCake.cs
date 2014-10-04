using System;
using System.Numerics;

class PeaceOfCake
{
    static void Main()
    {
        decimal numberA = decimal.Parse(Console.ReadLine());
        decimal numberB = decimal.Parse(Console.ReadLine());
        decimal numberC = decimal.Parse(Console.ReadLine());
        decimal numberD = decimal.Parse(Console.ReadLine());

        decimal cakes = (numberA / numberB) + (numberC / numberD);

        if (cakes >= 1)
        {
            Console.WriteLine((int)cakes);
        }
        else
        {
            Console.WriteLine("{0:F22}", cakes);
        }

        decimal denominator = numberB * numberD;
        decimal nominator = (numberA * numberD + numberC * numberB);

        Console.WriteLine("{0}/{1}", nominator, denominator);
    }
}

