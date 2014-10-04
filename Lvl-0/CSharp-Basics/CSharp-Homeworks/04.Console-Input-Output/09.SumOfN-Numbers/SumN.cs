using System;
// Write a program that enters a number n and after that enters more n numbers 
// and calculates and prints their sum. Note that you may need to use a for-loop. 

class SumN
{
    static void Main()
    {
        Console.Write("Enter numbers:");
        int number = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= number; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}

