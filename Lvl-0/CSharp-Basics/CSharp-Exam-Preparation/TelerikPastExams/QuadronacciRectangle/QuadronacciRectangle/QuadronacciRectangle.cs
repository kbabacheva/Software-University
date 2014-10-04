using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long first = long.Parse(Console.ReadLine());
        long second = long.Parse(Console.ReadLine()); ;
        long third = long.Parse(Console.ReadLine()); ;
        long forth = long.Parse(Console.ReadLine()); ;
        int rows = int.Parse(Console.ReadLine()); ;
        int columns = int.Parse(Console.ReadLine()); ;
        long nextNum = 0;

        for (int i = 0; i < rows; i++)
        {
                if (i == 0)
                {
                    Console.Write(first + " ");
                    Console.Write(second + " ");
                    Console.Write(third + " ");
                    Console.Write(forth + " ");
                    for (int k = 0; k < columns-4; k++)
                    {
                        nextNum = first + second + third + forth;
                        first = second;
                        second = third;
                        third = forth;
                        forth = nextNum;
                        Console.Write(forth + " "); 
                    }
                }
                if (i >=1)
                {
                    for (int h = 0; h < columns; h++)
                    {
                        nextNum = first + second + third + forth;
                        first = second;
                        second = third;
                        third = forth;
                        forth = nextNum;
                        Console.Write(forth + " ");
                    }
                }
            Console.WriteLine();
        }
    }
}

