using System;

class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        int outterDotsCount = n - 1;
        int innerDotsCount = n + 1;
        //first half
        Console.Write(new string(dot,n + 1));
        Console.Write(new string(star, n - 1));
        Console.WriteLine(new string(dot, n + 1));

        for (int i = 0; i < (n/2)-1; i++)
        {
        Console.Write(new string(dot,outterDotsCount));
        Console.Write(new string(star,1));
        Console.Write(new string(dot,innerDotsCount));
        Console.Write(new string(star, 1));
        Console.WriteLine(new string(dot, outterDotsCount));
        outterDotsCount -= 2;
        innerDotsCount += 4;
        }
        if (n > 2)
        {
            for (int i = 0; i < (2 * n - 1) / 4; i++)
            {
                Console.Write(new string(dot, 1));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, 3*n - 3));
                Console.Write(new string(star, 1));
                Console.WriteLine(new string(dot, 1));
            }
        }
        //drowing
        Console.Write(new string(dot, 1));
        Console.Write(new string(star, 1));
        for (int i = 0; i < (3 * n - 3)/2; i++)
        {
        Console.Write(new string('@', 1));
        Console.Write(new string(dot, 1));
        }
        Console.Write(new string('@', 1));
        Console.Write(new string(star, 1));
        Console.WriteLine(new string(dot, 1));
        
        Console.Write(new string(dot, 1));
        Console.Write(new string(star, 1));

        for (int i = 0; i < (3 * n - 3) / 2; i++)
        {
            Console.Write(new string(dot, 1));
            Console.Write(new string('@', 1));
        }
        Console.Write(new string(dot, 1));
        Console.Write(new string(star, 1));
        Console.WriteLine(new string(dot, 1));
        //second half
        if (n > 2)
        {
            for (int i = 0; i < (2  *n - 1) / 4; i++)
            {
                Console.Write(new string(dot, 1));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, 3 * n - 3));
                Console.Write(new string(star, 1));
                Console.WriteLine(new string(dot, 1));
            }
        }

        outterDotsCount = 1;
        innerDotsCount = 3*n - 3;
        for (int i = 0; i < (n / 2)-1; i++)
        {
            outterDotsCount += 2;
            innerDotsCount -= 4;
            Console.Write(new string(dot, outterDotsCount));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, innerDotsCount));
            Console.Write(new string(star, 1));
            Console.WriteLine(new string(dot, outterDotsCount));
        }
        Console.Write(new string(dot, n + 1));
        Console.Write(new string(star, n - 1));
        Console.WriteLine(new string(dot, n + 1));
    }
}

