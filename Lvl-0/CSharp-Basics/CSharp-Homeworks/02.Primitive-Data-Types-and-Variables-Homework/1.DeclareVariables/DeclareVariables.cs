using System;
// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short,
// ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

class DeclareVariables
{
    static void Main()
    {
        byte a = 97;
        Console.WriteLine(a);
        sbyte b = -115;
        Console.WriteLine(b);
        short c = -10000;
        Console.WriteLine(c);
        ushort d = 52130;
        Console.WriteLine(d);
        int e = 4825932;
        Console.WriteLine(e);
    }
}

