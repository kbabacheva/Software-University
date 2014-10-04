using System;
// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 

class RandomizeTheNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        for (int i = 0; i < number; i++)
        {
            array[i] = i + 1;
        }
        Random random = new Random();
        foreach (int i in array)
        {
            int randomNumber = random.Next(0, number);
            int temp = array[randomNumber];
            array[randomNumber] = array[0];
            array[0] = temp;
        }
        Console.WriteLine(String.Join(" ", array));
    }
}

