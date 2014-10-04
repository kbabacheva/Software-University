using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ApplesOrOranges
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            long[] array = new long[number];
            int evenNumber = 0;
            int oddNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number%10;
                number /= 10;
            }
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    evenNumber += num;
                }
                else
                {
                    oddNumber += num;
                }
            }
            if (evenNumber>oddNumber)
            {
                Console.WriteLine("apples");
                Console.WriteLine(evenNumber);
            }
            if (oddNumber>evenNumber)
            {
                Console.WriteLine("oranges");
                Console.WriteLine(oddNumber);
            }
            if (oddNumber == evenNumber)
            {
                Console.WriteLine("both");
                Console.WriteLine(oddNumber);
            }
        }
    }

