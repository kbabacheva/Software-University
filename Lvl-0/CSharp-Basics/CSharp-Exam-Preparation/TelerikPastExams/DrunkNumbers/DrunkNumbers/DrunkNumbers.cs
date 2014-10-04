using System;
using System.Numerics;

class DrunkNumbers
{
    static void Main()
    {
        int rounds = int.Parse(Console.ReadLine());
        int vladkoBeers = 0;
        int mitkoBeers = 0;
        BigInteger mitkoBeerCount = 0;
        BigInteger vladkoBeerCount = 0;
        for (int i = 0; i < rounds; i++)
        {
            int numberInput = int.Parse(Console.ReadLine());
            numberInput = Math.Abs(numberInput);//removing minus
            string newString = Convert.ToString(numberInput);//removing leading zeros
            int number = int.Parse(newString);
            if (newString.Length % 2 == 0)
            {
                for (int j = 0; j < newString.Length / 2; j++)
                {
                    vladkoBeers = number % 10;
                    vladkoBeerCount += vladkoBeers;
                    number /= 10;
                }
                for (int k = 0; k < newString.Length / 2; k++)
                {
                    mitkoBeers = number % 10;
                    mitkoBeerCount += mitkoBeers;
                    number /= 10;
                }
            }
            if (newString.Length % 2 != 0)
            {
                for (int m = 0; m <= newString.Length / 2; m++)
                {
                    vladkoBeers = number % 10;
                    vladkoBeerCount += vladkoBeers;
                    number /= 10;
                }
                for (int n = 0; n <= newString.Length / 2; n++)
                {
                    mitkoBeers = number % 10;
                    mitkoBeerCount += mitkoBeers;
                    number /= 10;
                }
                mitkoBeerCount += vladkoBeers;
            }
        }
        if (vladkoBeerCount > mitkoBeerCount)
        {
            Console.WriteLine("V {0}", vladkoBeerCount - mitkoBeerCount);
        }
        else if (mitkoBeerCount > vladkoBeerCount)
        {
            Console.WriteLine("M {0}", mitkoBeerCount - vladkoBeerCount);
        }
        else if (vladkoBeerCount == mitkoBeerCount)
        {
            Console.WriteLine("No {0}", mitkoBeerCount * 2);
        }
    }
}

