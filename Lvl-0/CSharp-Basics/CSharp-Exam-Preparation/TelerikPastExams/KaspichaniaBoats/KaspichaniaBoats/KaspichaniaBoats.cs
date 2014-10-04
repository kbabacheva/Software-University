using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        int outterDotsCount = n-1;
        int innerDotsCount = 0;
        Console.Write(new string (dot,n));
        Console.Write(new string(star,1));
        Console.WriteLine(new string(dot, n));

        for (int i = 0; i < n-1; i++)
        {
            Console.Write(new string(dot,outterDotsCount));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, innerDotsCount));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, innerDotsCount));
            Console.Write(new string(star, 1));
            Console.WriteLine(new string(dot, outterDotsCount));
            innerDotsCount++;
            outterDotsCount--;
        }
        Console.WriteLine(new string(star,2 * n + 1));

        for (int i = 0; i < n /2; i++)
        {
            innerDotsCount--;
            outterDotsCount++;
            Console.Write(new string(dot, outterDotsCount));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, innerDotsCount));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, innerDotsCount));
            Console.Write(new string(star, 1));
            Console.WriteLine(new string(dot, outterDotsCount));

        }
        Console.Write(new string(dot,n/2 + 1));
        Console.Write(new string(star, n));
        Console.WriteLine(new string(dot, n/2 + 1));
    }
}

