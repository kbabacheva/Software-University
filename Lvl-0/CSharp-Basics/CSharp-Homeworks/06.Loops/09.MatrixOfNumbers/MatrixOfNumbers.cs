﻿using System;
// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
// like in the examples below. Use two nested loops. 

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
            for (int j = i + 1; j <= i + n - 1; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

