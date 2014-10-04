using System;
using System.Threading;
using System.Globalization;
// A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
// (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or 
// “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 
// Note that you may need to learn how to parse dates and times. 


class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine(@"Enter time in format ""hh:mm TT"", for example 06:30 PM");
        string time = Console.ReadLine();
        DateTime givenTime = DateTime.Parse(time);
        DateTime startBeerTime = DateTime.Parse("1:00 PM");
        DateTime endBeerTime = DateTime.Parse("3:00 AM");
        if (givenTime>=startBeerTime || givenTime<endBeerTime)
        {
            Console.WriteLine("Beer time");
        }
        else
        {
            Console.WriteLine("Not beer time");
        }
    }
}

