using System;
// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter your number(<=100)");
        int number = int.Parse(Console.ReadLine());
        bool notPrime = number <= 100 && (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || 
            number ==2 || number ==3 || number ==5);
        Console.WriteLine("This number is prime:{0}", !notPrime);
    }
}

