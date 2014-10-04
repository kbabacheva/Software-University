using System;
// Write a program that takes as input a four-digit number in format abcd and performs the following:
// •	Calculates the sum of the digits
// •	Prints on the console the number in reversed order: dcba 
// •	Puts the last digit in the first position: dabc 
// •	Exchanges the second and the third digits: acbd 
// The number has always exactly 4 digits and cannot start with 0. 


class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a 4-digit number that doesn't start with zero:");
        string number = Console.ReadLine();
        char a = number[0];
        char b = number[1];
        char c = number[2];
        char d = number[3];
        int fourDigits = int.Parse(number);
        if (fourDigits > 1000 & fourDigits <= 9999)
        {
            int sum = a + b + c + d - 4*48;

            // 4*48 comes from -> when converting char to int, the symbol 1 is the number 49 in ASCII table, 
            // 2 is 50 and so on, so we need to substract 4 times the number 48 which corresponds to the symbol 0
            
            Console.WriteLine("The sum of the digits is {0}", sum);
            Console.WriteLine("The reversed number is {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("The last number showed first is {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("The second and the third number exchanged is {0}{1}{2}{3}", a, c, b, d);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}
