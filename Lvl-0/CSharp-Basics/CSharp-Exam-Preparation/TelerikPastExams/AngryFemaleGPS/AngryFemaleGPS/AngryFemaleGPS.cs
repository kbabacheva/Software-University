using System;
using System.Linq;

class AngryFemaleGPS
{
    static void Main()
    {
        long input1 = long.Parse(Console.ReadLine());
        if (input1 < 0)
        {
            input1 = -input1;
        }
        string input = input1.ToString();
        long oddCounter = 0;
        long evenCounter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] % 2 != 0)
            {
                int oddNumber = input[i] - 48;
                oddCounter += oddNumber;
            }
            if (input[i] % 2 == 0)
            {
                int evenNumber = input[i] - 48;
                evenCounter += evenNumber;
            }
        }
        if (oddCounter > evenCounter)
        {
            Console.WriteLine("left {0}",oddCounter);
        }
        if (evenCounter > oddCounter)
        {
            Console.WriteLine("right {0}",evenCounter);
        }
        if (evenCounter == oddCounter)
        {
            Console.WriteLine("straight {0}",oddCounter);
        }
    }
}

