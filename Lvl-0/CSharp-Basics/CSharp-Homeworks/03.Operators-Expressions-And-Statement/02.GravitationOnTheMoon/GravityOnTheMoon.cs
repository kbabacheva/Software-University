using System;
// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 

class GravityOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight:");
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = weight * 17 / 100;
        Console.WriteLine("Your weight on the moon will be {0}", moonWeight);
    }
}

