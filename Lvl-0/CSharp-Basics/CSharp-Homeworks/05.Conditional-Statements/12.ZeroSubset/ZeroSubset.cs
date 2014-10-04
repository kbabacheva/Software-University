using System;
// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
// Assume that repeating the same subset several times is not a problem. 

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Enter 5 integers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}+{4} = 0", a, b, c, d, e);
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3} = 0", a, b, c, d);
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3} = 0", a, c, d, e);
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3} = 0", a, b, d, e);
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3} = 0", b, c, d, e);
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3} = 0", a, b, c, e);
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0}+{1}+{2} = 0", a, b, c);
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2} = 0", a, c, d);
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2} = 0", a, b, d);
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2} = 0", a, d, e);
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2} = 0", a, c, e);
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2} = 0", a, b, e);
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2} = 0", b, c, d);
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2} = 0", b, d, e);
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2} = 0", b, c, e);
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2} = 0", c, d, e);
        }
        if (a + b == 0)
        {
            Console.WriteLine("{0}+{1} = 0", a, b);
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0}+{1} = 0", a, c);
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0}+{1} = 0", a, d);
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0}+{1} = 0", a, e);
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0}+{1} = 0", b, c);
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0}+{1} = 0", c, e);
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0}+{1} = 0", c, d);
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0}+{1} = 0", d, e);
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0}+{1} = 0", b, d);
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0}+{1} = 0", b, e);
        }
        else if (a+b+c+d+e != 0 && a+b+d+d != 0 && a+b+c !=0 && a+b != 0 && a+c+d+e != 0 && a+c+d != 0
            && a+c != 0 && a+b+d+e != 0 && a+b+d != 0 && a+d != 0 && a+e != 0 && a+d+e != 0 && a+c+e != 0
            &&a+b+e != 0 && b+c+d+e != 0 && b+c+d != 0 && b+c != 0 && b+d+e != 0 && b+c+e != 0
            && c+d+e != 0 && c+e != 0 && c+d != 0 && d+e != 0 && b+d != 0 && b+e != 0 && a+b+c+e != 0)
        {
            Console.WriteLine("No zero subsets");
        }
    }
}

