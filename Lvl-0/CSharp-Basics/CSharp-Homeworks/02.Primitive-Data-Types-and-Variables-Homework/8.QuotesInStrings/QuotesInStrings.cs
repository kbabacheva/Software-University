using System;
// Declare two string variables and assign them with following value:
// The "use" of quotations causes difficulties.
// Do the above in two different ways: with and without using quoted strings. 
// Print the variables to ensure that their value was correctly defined.


class QuotesInStrings
{
    static void Main()
    {
        string first = (@"The ""use"" of quotation causes difficulties.");
        string second = ("The \"use\" of quotation causes difficulties.");
        Console.WriteLine(first);
        Console.WriteLine(second);
    }
}

