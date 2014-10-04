using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dash = '#';
        char dot = '.';
        char slash = '/';
        char backslash = '\\';
        int outterDotCount = n/2 - 1;
        int innerDotcount = 0;
        int slashCount = n / 2;
        int backslashCount = n / 2;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string(dot,outterDotCount));
            Console.Write(new string(dash,1));
            Console.Write(new string(dot,innerDotcount));
            Console.Write(new string(dash, 1));
            Console.WriteLine(new string(dot, outterDotCount));
            outterDotCount--;
            innerDotcount += 2;
        }
        outterDotCount = 0;
        innerDotcount = n - 2;
        for (int i = 0; i < n/4; i++)
        {
            Console.Write(new string(dot, outterDotCount));
            Console.Write(new string(dash, 1));
            Console.Write(new string(dot, innerDotcount));
            Console.Write(new string(dash, 1));
            Console.WriteLine(new string(dot, outterDotCount));
            outterDotCount++;
            innerDotcount -= 2;
        }
        Console.WriteLine(new string('-',n));
        outterDotCount = 0;

        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string(dot,outterDotCount));
            Console.Write(new string(backslash, backslashCount));
            Console.Write(new string(slash, slashCount));
            Console.WriteLine(new string(dot, outterDotCount));
            outterDotCount++;
            slashCount--;
            backslashCount--;
        }
    }
}

