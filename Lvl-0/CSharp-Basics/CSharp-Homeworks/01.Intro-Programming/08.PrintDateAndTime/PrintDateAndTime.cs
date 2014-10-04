using System;
// Create a console application that prints the current date and time.

class PrintDateAndTime
{
    static void Main()
    {
        DateTime time = DateTime.Now;
        string format = "MMM ddd d HH:mm yyyy";
        Console.WriteLine(time.ToString(format));
    }
}

