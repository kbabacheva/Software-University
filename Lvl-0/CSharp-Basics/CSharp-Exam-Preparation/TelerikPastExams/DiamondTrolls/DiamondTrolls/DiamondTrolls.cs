using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char stars = '*';
        char dots = '.';
        int outterDotsCount = (n)/2;
        int innerDotsCount = (n)/2;
        int starsCount = 1;
        int width = 2*n + 1;

        Console.Write(new string(dots,((width-n)/2)));
        Console.Write(new string(stars,n));
        Console.WriteLine(new string(dots, ((width - n) / 2)));
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string(dots,outterDotsCount));
            Console.Write(new string(stars,starsCount));
            Console.Write(new string(dots,innerDotsCount));
            Console.Write(new string(stars, starsCount));
            Console.Write(new string(dots,innerDotsCount));
            Console.Write(new string(stars, starsCount));
            Console.WriteLine(new string(dots, outterDotsCount));
            outterDotsCount--;
            innerDotsCount++;
        }
        Console.WriteLine(new string(stars,width ));

        for (int i = 0; i < n - 1; i++)
        {
            outterDotsCount++;
            innerDotsCount--;
            Console.Write(new string(dots, outterDotsCount));
            Console.Write(new string(stars, starsCount));
            Console.Write(new string(dots, innerDotsCount));
            Console.Write(new string(stars, starsCount));
            Console.Write(new string(dots, innerDotsCount));
            Console.Write(new string(stars, starsCount));
            Console.WriteLine(new string(dots, outterDotsCount));
        }
        Console.Write(new string(dots,n));
        Console.Write(new string(stars,starsCount));
        Console.WriteLine(new string(dots,n));
    }
}

