using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char star = '*';
        char dot = '.';
        int countStar = 1;
        int leftDotsCount = n - 1;
        int righDotsCount = n - 1;

        Console.Write(new string(dot,n));
        Console.WriteLine(new string(star,n));

        for (int i = 0; i < n-1; i++)
        {
            Console.Write(new string(dot,leftDotsCount));
            Console.Write(new string (star,countStar));
            Console.Write(new string(dot,righDotsCount));
            Console.WriteLine(new string(star, countStar));
            leftDotsCount--;
            righDotsCount++;
        }
        Console.WriteLine(new string(star,2*n));
    }
}

