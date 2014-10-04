using System;
// Write a Boolean expression that checks for given integer if it can be divided (without remainder)
// by 7 and 5 in the same time.

class DevidedBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        bool division = number % 5 == 0 && number % 7 == 0 && number != 0;
        Console.WriteLine("The number can be divided by 5 and 7 at the same time: {0}", division);
    }
}

