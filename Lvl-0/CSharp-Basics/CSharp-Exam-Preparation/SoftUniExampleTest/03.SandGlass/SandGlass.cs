using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int couterStars = n;
        int leftDots = 0;
        int rightDots = 0;
        char star = '*';
        char dot = '.';
        for (int i = 0; i < n/2+1; i++)
        {
            Console.Write(new string(dot,leftDots));
            Console.Write(new string(star,couterStars));
            Console.Write(new string(dot,rightDots));
            Console.WriteLine();
            leftDots++;
            rightDots++;
            couterStars -= 2;
        }
        leftDots = n / 2 - 1;
        rightDots = n / 2 - 1;
        couterStars = 3;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string(dot, leftDots));
            Console.Write(new string(star, couterStars));
            Console.Write(new string(dot, rightDots));
            Console.WriteLine();
            leftDots--;
            rightDots--;
            couterStars += 2;
        }
    }
}

