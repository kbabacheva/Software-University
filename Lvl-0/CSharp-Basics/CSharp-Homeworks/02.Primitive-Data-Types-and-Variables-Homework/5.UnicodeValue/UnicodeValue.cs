﻿using System;
// Declare a character variable and assign it with the symbol that has Unicode code 72, and then print it. 
// Hint: first, use the Windows Calculator to find the hexadecimal representation of 72. The output should be “H”.

class UnicodeValue
{
    static void Main()
    {
        char symbol = 'H';
        Console.WriteLine("The code of '{0}' is: {1}", symbol, (int)symbol);
    }
}

