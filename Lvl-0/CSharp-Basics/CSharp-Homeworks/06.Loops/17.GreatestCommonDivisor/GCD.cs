using System;
// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. 
// Use the Euclidean algorithm (find it in Internet). 


class GCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int divisor = 1;
        if (a<0)
        {
            a = -1 * a;
        }
        if (b<0)
        {
            b = -1 * b;
        }
        if (a>b)
        {
            divisor = b;
        }
        if (b>a)
        {
            divisor = a;  
        }
        if (a == b)
        {
            Console.WriteLine(a);
        }
        for (int i = divisor; i > 0; i--)
        {
            if (a % i == 0 && b % i == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}

