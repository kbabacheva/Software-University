using System;
// Write an expression that extracts from given integer n the value of given bit at index p.

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index p:");
        int p = int.Parse(Console.ReadLine());
        int index = number >> p;
        int bit = index & 1;
        Console.WriteLine("The bit at index {0} is {1}", p, bit);
    }
}

