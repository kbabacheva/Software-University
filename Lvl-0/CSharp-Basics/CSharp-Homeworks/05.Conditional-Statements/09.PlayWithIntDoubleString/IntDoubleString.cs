using System;
// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
// If the variable is int or double, the program increases it by one. 
// If the variable is a string, the program appends "*" at the end. Print the result at the console. 
// Use switch statement. 

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Type 1 for int, 2 for double or 3 for string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter integer variable");
                int first = int.Parse(Console.ReadLine());
                int result = first + 1;
                Console.WriteLine(result);
                break;
            case 2:
                Console.WriteLine("Enter double variable");
                double second = double.Parse(Console.ReadLine());
                double result2 = second + 1.0;
                Console.WriteLine(result2);
                break;
            case 3:
                Console.WriteLine("Enter string variable");
                string third = Console.ReadLine();
                string result3 = (third + "*");
                Console.WriteLine(result3);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}

