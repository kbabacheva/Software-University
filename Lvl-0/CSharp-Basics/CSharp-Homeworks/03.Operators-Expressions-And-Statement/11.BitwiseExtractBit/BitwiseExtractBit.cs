﻿using System;
// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0. 
// The result of the expression should be either 1 or 0. 

class BitwiseExtractBit
{
    static void Main()
    {
        Console.WriteLine("Enter your number");
        int number = int.Parse(Console.ReadLine());
        int numberMovedRight = number >> 3;
        int bit = numberMovedRight & 1;
        Console.WriteLine("The value of big #3 is {0}",bit);
    }
}

