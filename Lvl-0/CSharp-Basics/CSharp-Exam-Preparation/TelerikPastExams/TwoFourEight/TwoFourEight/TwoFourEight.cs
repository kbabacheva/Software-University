using System;

class TwoFourEifgr
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (b == 2)
        {
            int result = a % c;
            if (result % 4 == 0)
            {
                Console.WriteLine(result / 4);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result % 4);
                Console.WriteLine(result);
            }
        }
        else if (b == 4)
        {
            int result = a + c;
            if (result % 4 == 0)
            {
                Console.WriteLine(result / 4);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result % 4);
                Console.WriteLine(result);
            }
        }
        else if (b == 8)
        {
            int result = a * c;
            if (result % 4 == 0)
            {
                Console.WriteLine(result / 4);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result % 4);
                Console.WriteLine(result);
            }
        }
    }
}