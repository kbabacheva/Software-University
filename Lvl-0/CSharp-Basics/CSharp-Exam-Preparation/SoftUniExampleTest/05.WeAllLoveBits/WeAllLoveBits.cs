using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] Pnew = new int[n];

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                Pnew[i] <<= 1;
                Pnew[i] |= (num & 1);
                num >>= 1;
            }
        }
        foreach (int P in Pnew)
        {
            Console.WriteLine(P);
        }
    }
}

