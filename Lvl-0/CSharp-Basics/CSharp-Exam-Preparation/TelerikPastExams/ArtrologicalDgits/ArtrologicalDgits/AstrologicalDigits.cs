using System;

class AstrologicalDigits
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        long num = 0;
        long sum = 0;
        if (inputStr.Length == 1)
        {
            Console.WriteLine(inputStr);
        }
        else if (inputStr.Length > 1)
        {
            for (int i = 0; i < inputStr.Length; i++)
            {
                char x = inputStr[i];
                if (!(char.IsDigit(x)))
                {
                    continue;
                }
                else
                {
                    num = (long)(inputStr[i] - 48);
                    sum += num;
                }
            }
            if (sum <= 9)
            {
                Console.WriteLine(sum);
            }
            else if (sum > 9)
            {
                while (sum > 9)
                {
                    num = 0;
                    while (sum != 0)
                    {
                        num += sum % 10;
                        sum /= 10;
                    }
                    sum = num;
                }
                Console.WriteLine(sum);
            }
        }
    }
}

