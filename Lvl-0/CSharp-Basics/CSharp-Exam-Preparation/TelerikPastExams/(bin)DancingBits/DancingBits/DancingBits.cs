using System;

class DancingBits
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        string result = "";

        for (int i = 0; i < N; i++)
        {
            int number = int.Parse(Console.ReadLine());
            result += Convert.ToString(number, 2); // adding to the result the current number represented in binary
        }

        char previousChar = result[0];
        int count = 1;
        int endResult = 0;
        for (int i = 1; i < result.Length; i++)
        {
            if (result[i] == previousChar)
            {
                count++;
            }
            else
            {
                if (count == K)
                {
                    endResult++;
                }
                count = 1;
                previousChar = result[i]; // to compare to the next char, not just zero char
            }
        }
        if (count == K)
        {
            endResult++;
        }
        Console.WriteLine(endResult);
    }
}

