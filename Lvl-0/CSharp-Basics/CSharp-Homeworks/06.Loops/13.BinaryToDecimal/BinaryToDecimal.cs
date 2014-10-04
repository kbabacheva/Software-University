using System;
// Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. 
// The output should be a variable of type long. Do not use the built-in .NET functionality. 

class BinaryToDecimal
{
    static void Main()
    {
        string str = Console.ReadLine();
        long binary = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[str.Length-1] == 0)
            {
                continue;
            }
            binary += (long)Math.Pow(2, i);
        }
        Console.WriteLine(binary);
    }
}

