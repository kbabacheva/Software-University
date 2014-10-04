using System;
// Create a program that assigns null values to an integer and to a double variable. 
// Try to print these variables at the console. Try to add some number or the null literal 
// to these variables and print the result.

    class NullValuesAritmetic
    {
        static void Main()
        {
            int? nullInt = null;
            double? nullDouble = null;
            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);

            nullInt += 10;
            nullDouble += 10.5;
            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);

            nullInt = 10;
            nullDouble = 10.5;
            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);
        }
    }

