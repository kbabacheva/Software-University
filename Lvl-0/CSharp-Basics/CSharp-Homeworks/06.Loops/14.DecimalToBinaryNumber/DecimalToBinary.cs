using System;
// Using loops write a program that converts an integer number to its binary representation. 
// The input is entered as long. The output should be a variable of type string. 

class DecimalToBinary
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        long restValue;
        string binary = string.Empty;

        while (decimalNumber > 0)
        {
            restValue = decimalNumber % 2;
            decimalNumber = decimalNumber / 2;
            binary = restValue.ToString() + binary;
        }
        Console.WriteLine(binary);
    }
}

