using System;
// Write an expression that checks for given integer if its third digit from right-to-left is 7. 

class IsThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int seven = number / 100; //Getting the first
        bool isSeven = seven % 7 == 0 && number>=100;
        Console.WriteLine("The third digit of {0} is 7: {1}", number, isSeven);
    }
}

