using System;
// Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
// the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 

class MinMaxSumAverage
{
    static void Main()
    {
        int lenght = int.Parse(Console.ReadLine());

        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        int sum = 0;
        double average = 0;

        for (int i = 0; i < lenght; i++)
        {
            int number = int.Parse(Console.ReadLine());

            minValue = Math.Min(minValue, number);

            maxValue = Math.Max(maxValue, number);

            sum += number;

            average = (double)sum / lenght;
        }
        Console.WriteLine("min = {0}", minValue);
        Console.WriteLine("max = {0}", maxValue);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", average);
    }
}

