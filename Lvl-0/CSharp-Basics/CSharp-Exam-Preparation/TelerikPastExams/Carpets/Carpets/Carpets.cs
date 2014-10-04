using System;

class Carpets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int lines = int.Parse(input);
        int elementsOnLines = lines;
        int center = elementsOnLines/2;
        //upper part
        for (int i = 1; i <= lines/2; i++)
        {
            int elPosition = 1;
            while (elPosition <= elementsOnLines)
            {
                if ((elPosition <= center - i) || (elPosition> center + i))
                {
                    Console.Write(".");
                    elPosition++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("/");
                            elPosition++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elPosition++;
                        }
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("\\");
                            elPosition++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elPosition++;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
        //down part
        for (int i = lines/2; i >0; i--)
        {
            int elPosition = 1;
            while (elPosition <= elementsOnLines)
            {
                if ((elPosition <= center - i) || (elPosition > center + i))
                {
                    Console.Write(".");
                    elPosition++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("\\");
                            elPosition++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elPosition++;
                        }
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("/");
                            elPosition++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elPosition++;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

