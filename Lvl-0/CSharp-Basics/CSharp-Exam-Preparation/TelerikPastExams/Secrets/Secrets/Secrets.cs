using System;
using System.Numerics;

class Secrets
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();
        inputNumber = inputNumber.TrimStart('-'); //Removing "-" if the number is negative
        var inputCharArray = inputNumber.ToCharArray(); // making it array
        Array.Reverse(inputCharArray); // reversing the array
        long specialSum = 0;

        for (int i = 0; i < inputCharArray.Length; i++)
        {
            int currentDigit = int.Parse(inputCharArray[i].ToString());
            if (i % 2 == 1)
            {
                specialSum += currentDigit * currentDigit * (i+1);
            }
            else
            {
                specialSum += currentDigit * (i + 1) * (i + 1);
            }
        }
        Console.WriteLine(specialSum);

        int sequenceLenght = (int)specialSum % 10;
        int currentLetter = (int)(specialSum % 26);
        if (sequenceLenght == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence",inputNumber);
        }
        else
        {
            for (int i = 0; i < sequenceLenght; i++)
            {
                Console.Write((char)((currentLetter + i) % 26 + 65));
            }
        }
    }
}

