using System;
// Write a Boolean expression that returns if the bit at position p 
// (counting from 0, starting from the right) in given integer number n has value of 1. 

class CheckBit
{
    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position p:");
        int p = int.Parse(Console.ReadLine());
        int moved = number >> p;
        int check = moved & 1;
        bool isIt1 = check == 1;
        Console.WriteLine("The bit at the position {0} is 1: {1}",p,isIt1);
    }
}

