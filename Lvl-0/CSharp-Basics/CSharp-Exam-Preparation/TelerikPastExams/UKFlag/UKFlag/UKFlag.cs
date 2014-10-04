using System;

    class UKFlag
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char dots = '.';
            char slash = '/';
            char backslash = '\\';
            char line = '|';
            int innerDotsCount = n / 2 - 1;
            int outterDotsCount = 0;

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string(dots,outterDotsCount));
                Console.Write(new string(backslash, 1));
                Console.Write(new string(dots, innerDotsCount));
                Console.Write(new string(line, 1));
                Console.Write(new string(dots, innerDotsCount));
                Console.Write(new string(slash, 1));
                Console.WriteLine(new string(dots, outterDotsCount));
                innerDotsCount--;
                outterDotsCount++;
            }
            Console.Write(new string('-',n/2));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('-', n / 2));
            innerDotsCount = 0;
            outterDotsCount = n / 2 - 1;
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string(dots, outterDotsCount));
                Console.Write(new string(slash, 1));
                Console.Write(new string(dots, innerDotsCount));
                Console.Write(new string(line, 1));
                Console.Write(new string(dots, innerDotsCount));
                Console.Write(new string(backslash, 1));
                Console.WriteLine(new string(dots, outterDotsCount));
                innerDotsCount++;
                outterDotsCount--;
            }
        }
    }

