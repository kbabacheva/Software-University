﻿using System;
// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long. 
// Do not use the built-in .NET functionality. 

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimal = Console.ReadLine();
        long decValue = 0;
        long power = 1;

        for (int i = hexadecimal.Length - 1; i >= 0; i--)
        {
            int num;
            switch (hexadecimal[i])
            {
                case 'A':
                    num = 10;
                    break;
                case 'B':
                    num = 11;
                    break;
                case 'C':
                    num = 12;
                    break;
                case 'D':
                    num = 13;
                    break;
                case 'E':
                    num = 14;
                    break;
                case 'F':
                    num = num = 15;
                    break;
                default:
                    num = (int)hexadecimal[i] - 48;
                    break;
            }
            decValue += num * power;
            power *= 16;
        }
        Console.WriteLine(decValue);
    }
}

