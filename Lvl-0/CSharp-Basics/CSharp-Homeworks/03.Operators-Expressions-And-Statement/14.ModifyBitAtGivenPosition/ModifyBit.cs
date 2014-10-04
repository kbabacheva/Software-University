using System;
// We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the 
// position p from the binary representation of n while preserving all other bits in n. 

class ModifyBit
{
    static void Main()
    {
        Console.WriteLine("Enter integer number n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position p:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of the bit - 0 or 1:");
        int v = int.Parse(Console.ReadLine());
        if (v == 1)
        {
            int mask1 = 1 << p;
            int result1 = n | mask1;
            Console.WriteLine(result1);
        }
        if (v == 0)
        {
            int mask2 = ~(1 << p);
            int result2 = n & mask2;
            Console.WriteLine(result2);
        }
    }
}

