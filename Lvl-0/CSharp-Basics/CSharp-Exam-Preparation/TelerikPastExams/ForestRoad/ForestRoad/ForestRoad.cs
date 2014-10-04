using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char star = '*';
        char dot = '.';
        int leftDotsCount = 0;
        int rightDotsCount = n - 1;
        int starsCount = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(dot, leftDotsCount));
            Console.Write(new string(star, starsCount));
            Console.WriteLine(new string(dot, rightDotsCount));
            leftDotsCount++;
            rightDotsCount--;
        }

        leftDotsCount = n - 2;
        rightDotsCount = 1;
        starsCount = 1;
        for (int i = 1; i < n; i++)
        {
            Console.Write(new string(dot, leftDotsCount));
            Console.Write(new string(star, starsCount));
            Console.WriteLine(new string(dot, rightDotsCount));
            leftDotsCount--;
            rightDotsCount++;
        }
    }
}

