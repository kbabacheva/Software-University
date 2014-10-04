using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());
        long[] nums = new long[16];
        for (int i = 0; i < n; i++)
        {
            nums[i] = long.Parse(Console.ReadLine());
        }
        // variant 1 za vdigane na stepen n -1
        int maxI = 1;
        for (int i = 1; i <= n; i++)
        {
            maxI *= 2;
        }
        maxI -= 1;
        //var 2
        //maxI = (int)Math.Pow((double)2, n) - 1;
        int count = 0;
        for (int i = 1; i <= maxI; i++)
        {
            long currentSum = 0;
            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    currentSum += nums[j];
                }
            }
            if (currentSum == s)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

