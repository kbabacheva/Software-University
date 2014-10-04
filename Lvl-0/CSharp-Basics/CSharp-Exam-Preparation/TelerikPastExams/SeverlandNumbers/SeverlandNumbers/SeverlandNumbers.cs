using System;

    class SeverlandNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine()); ;
            int newNumber = number + 1;
            if (number>0 && number<66)
            {
                if (newNumber % 10 == 7)
                {
                    Console.WriteLine(number+4);
                }
                else if (newNumber % 10 != 7)
                {
                    Console.WriteLine(newNumber);
                }
            }
            else if (number==66)
            {
                Console.WriteLine(100);
            }
            else if (number>=100 && number<666)
            {
                if (newNumber % 10 == 7)
                {
                    if (newNumber/10 % 10 == 6)
                    {
                        Console.WriteLine(number+34);
                    }
                    else
                    {
                        Console.WriteLine(number + 4);
                    }
                }
                else if (newNumber % 10 != 7)
                {
                    Console.WriteLine(newNumber);
                }
            }
            else if (number == 0)
            {
                Console.WriteLine(1);
            }
            else if (number == 666)
            {
                Console.WriteLine(1000);
            }
        }
    }

