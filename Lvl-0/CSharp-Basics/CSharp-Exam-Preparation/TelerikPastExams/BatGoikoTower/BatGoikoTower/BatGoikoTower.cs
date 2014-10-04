using System;

class BatGoikoTower
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char leftDash = '/';
        char rightDash = '\\';
        char dash = '-';
        int outterDotCount = n - 1;
        int innerDotCount = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(dot,outterDotCount));
            Console.Write(new string(leftDash,1));
            if (i == 2 || i == 4 || i == 7 || i == 11 || i == 16 || i == 22 || i == 29 || i == 37)
            {
                Console.Write(new string(dash,innerDotCount));
            }
            else
            {
                Console.Write(new string(dot,innerDotCount));
            }
            Console.Write(new string(rightDash, 1));
            Console.Write(new string(dot, outterDotCount));
            innerDotCount += 2;
            outterDotCount -= 1;
              
            Console.WriteLine();
        }
    }
}

