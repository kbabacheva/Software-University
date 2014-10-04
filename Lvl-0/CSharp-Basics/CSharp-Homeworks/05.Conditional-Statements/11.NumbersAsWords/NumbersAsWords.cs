using System;
// Write a program that converts a number in the range [0…999] to words, 
// corresponding to the English pronunciation. 
// Doesn't work properly ofcourse :D

class NumbersAsWords
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int[] array = new int[3];
        array[0] = numbers / 100;
        array[1] = numbers / 10 % 10;
        array[2] = numbers % 10;
        if (numbers>=20 || numbers<=9 && numbers > 0)
        {
            switch (array[0])
            {
                case 0:
                    Console.Write("");
                    break;
                case 1: 
                    Console.Write("One hudnred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hudnred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hudnred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
            }
            switch (array[1])
            {
                case 0:
                    Console.Write("");
                    break;
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("fourty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninety ");
                    break;
            }
            switch (array[2])
            {
                case 1: 
                    Console.WriteLine("one ");
                    break;
                case 2:
                    Console.WriteLine("two ");
                    break;
                case 3:
                    Console.WriteLine("three ");
                    break;
                case 4:
                    Console.WriteLine("four ");
                    break;
                case 5:
                    Console.WriteLine("five ");
                    break;
                case 6:
                    Console.WriteLine("six ");
                    break;
                case 7:
                    Console.WriteLine("seven ");
                    break;
                case 8:
                    Console.WriteLine("eight ");
                    break;
                case 9:
                    Console.WriteLine("nine ");
                    break;
            }
        }
        else if (numbers>=10 && numbers<20)
        {
            switch (numbers)
            {
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 14:
                    Console.WriteLine("Fourteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("Seventeen");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 19:
                    Console.WriteLine("Nineteen");
                    break;
            }
        }
        else if (numbers == 0)
        {
            Console.WriteLine("Zero");
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}

// the right way:
/*using System;
 
class NumbersToText
{
    static void Main()
    {
        Console.WriteLine("Write a number from 0 to 999:");
        string input = Console.ReadLine();
        int number = 0;
 
        try
        {
            number = int.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number!");
        }
 
        int n2 = (number % 100) % 10;
        int n1 = (number % 100) / 10;
        int n = number / 100;
 
        string[] ones = new string[] { "", "one", "two", "three", "four", "five", "six",
                                      "seven", "eight", "nine"};
 
        string[] tens = new string[] {"", "", "twenty", "thirty", "fourty", "fifty", "sixty",
                                      "seventy", "eighty", "ninety"};
 
        string[] specialNumbers = new string[] {"ten","eleven", "twelve", "thirteen", "fourteen",
                                                "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
 
 
 
        if (input.Length == 1)
        {
            if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine(ones[n2]);
            }
        }
 
        else if (input.Length == 2)
        {
            if (n1 == 1)
            {
                Console.WriteLine(specialNumbers[n2]);
            }
            else
            {
                if (n2 == 0)
                {
                    Console.WriteLine(tens[n1]);
                }
                else
                {
                    Console.WriteLine(tens[n1] + " " + ones[n2]);
                }
            }
        }
 
        else if (input.Length == 3)
        {
            if (n1 == 1)
            {
                Console.WriteLine(ones[n] + " hundred and " + specialNumbers[n2]);
            }
            else
            {
                Console.WriteLine(ones[n] + " hundred and " + tens[n1] + " " + ones[n2]);
            }
        }
 
        else
        {
            Console.WriteLine("Please enter a number between 0 and 999");
        }
    }
}
*/