using System;
/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
*/

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Please enter your employee information below:");
        Console.WriteLine("Please enter your first name");
        string firstName = (Console.ReadLine());
        Console.WriteLine("Please enter your last name");
        string lastName = (Console.ReadLine());
        Console.WriteLine("Please enter your age");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your gender");
        string gender = (Console.ReadLine());
        Console.WriteLine("Please enter your personal ID");
        uint personalID = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your unique employee number");
        ulong uniqueNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Your first name is {0}", firstName);
        Console.WriteLine("Your last name is {0}", lastName);
        Console.WriteLine("Your age is {0}", age);
        Console.WriteLine("Your gender is {0}", gender);
        Console.WriteLine("Your personal ID is {0}", personalID);
        Console.WriteLine("Your unique employee number is {0}", uniqueNumber);
        Console.WriteLine("Thank you!");
    }
}

