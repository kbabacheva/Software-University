using System;

class Bittris
{
    static void Main()
    {
        int leftMostBitMask = 128;
        int rightMostBitMask = 1;
        int totalScore = 0;
        int fullRowMask = 255;

        int[] numbers = new int[4];

        int numberOfCommands = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCommands / 4; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            int currentRow = 0;
            int currentScore = 0;

            for (int j = 0; j < 32; j++)
            {
                if ((currentNumber & (1 << j)) != 0)
                {
                    currentScore++;
                }
            }

            string commands = Console.ReadLine() + Console.ReadLine() + Console.ReadLine();

            for (int j = 0; j < commands.Length; j++)
            {
                if (commands[j] == 'L')
                {
                    if ((currentNumber & leftMostBitMask) == 0)
                    {
                        currentNumber <<= 1;
                    }
                }
                else if (commands[j] == 'R')
                {
                    if ((currentNumber & rightMostBitMask) == 0)
                    {
                        currentNumber >>= 1;
                    }
                }

                if (currentRow != 3 &&(currentNumber & numbers[currentRow + 1]) == 0)
                {
                    currentRow++;
                }
                else
                {
                    break;
                }
            }
            numbers[currentRow] |= currentNumber;

            if ((numbers[currentRow] & fullRowMask) == fullRowMask)
            {
                totalScore += 10 * currentScore;

                for (int j = currentRow; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = 0;
            }
            else
            {
                totalScore += currentScore;
            }
        }
        Console.WriteLine(totalScore);
    }
}

