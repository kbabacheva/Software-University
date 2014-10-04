using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        int dotsCount = n-2;
        int starsCount = 1;

        for (int i = 0; i < n-1; i++)
        {
            Console.Write(new string(dot,dotsCount));
            Console.Write(new string(star,starsCount));
            Console.WriteLine(new string(dot, dotsCount));
            dotsCount--;
            starsCount += 2;
        }
        dotsCount = n - 2;
        Console.Write(new string(dot,dotsCount));
        Console.Write(new string(star,1));
        Console.WriteLine(new string(dot, dotsCount));
    }
}

