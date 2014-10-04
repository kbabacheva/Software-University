using System;
using System.Collections.Generic;

class BullsAndCows
{
    const int Digits = 4;

    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int resultCount = 0;

        for (int guessNumber = 1111; guessNumber <= 9999; guessNumber++)
        {
            int bullsFound = GetBulls(secretNumber, guessNumber);
            int cowsFound = GetCows(secretNumber, guessNumber);
            if (bulls == bullsFound && cows == cowsFound)
            {
                if (guessNumber.ToString().IndexOf('0') == -1)
                {
                    Console.Write(guessNumber);
                    Console.Write(" ");
                    resultCount++;
                }
            }
        }
        if (resultCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int GetBulls(int secretNumber, int guessNumber)
    {
        string secretNum = secretNumber.ToString().PadLeft(Digits, '0');
        string guessNum = guessNumber.ToString().PadLeft(Digits, '0');
        int bullsCount = 0;
        for (int i = 0; i < Digits; i++)
        {
            if (secretNum[i] == guessNum[i])
            {
                bullsCount++;
            }
        }
        return bullsCount;
    }

    private static int GetCows(int secretNumber, int guessNumber)
    {
        List<char> secChars = new List<char>();
        for (int i = 0; i < Digits; i++)
        {
            int digit = secretNumber % 10;
            string digitStr = "" + digit;
            char digitCh = digitStr[0];
            secChars.Insert(0, digitCh);
            secretNumber = secretNumber / 10;
        }

        List<char> guessChars = new List<char>();
        for (int i = 0; i < Digits; i++)
        {
            int digit = guessNumber % 10;
            string digitStr = "" + digit;
            char digitCh = digitStr[0];
            guessChars.Insert(0, digitCh);
            guessNumber = guessNumber / 10;
        }

        for (int i = 0; i < Digits; i++)
        {
            if (guessChars[i] == secChars[i])
            {
                guessChars[i] = '*';
                secChars[i] = '*';
            }  
        }
        int cowsCount = 0;
        for (int secIndex = 0; secIndex < Digits; secIndex++)
        {
            for (int guessIndex = 0; guessIndex < Digits; guessIndex++)
            {
                if (secChars[secIndex] == guessChars[guessIndex] && secChars[secIndex] != '*')
                {
                    cowsCount++;
                    secChars[secIndex] = '*';
                    guessChars[guessIndex] = '*';
                }         
            }
        }
        return cowsCount;
    }
}

