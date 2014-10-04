using System;


class ExcelColumns
{
    static void Main()
    {
        int shift = 64;
        int columns = int.Parse(Console.ReadLine());
        long[] array = new long[10];
        if (columns > 1)
        {
            for (int i = 1, j = 0; i <= columns; i++, j++)
            {
                string str = Console.ReadLine();
                int number = str[0] - shift;
                array[j] = number;
            }
            int multiplier = 26;
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * (long)Math.Pow(multiplier, columns);
                columns--;
                sum += array[i];
            }
            long result = sum / multiplier;
            Console.WriteLine(result);
        }
        else if (columns == 1)
        {
            string str = Console.ReadLine();
            int number = str[0] - shift;
            Console.WriteLine(number);
        }
    }
}

