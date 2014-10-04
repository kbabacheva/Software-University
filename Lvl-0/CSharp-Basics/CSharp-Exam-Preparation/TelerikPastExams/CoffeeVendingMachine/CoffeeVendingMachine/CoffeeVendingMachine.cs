using System;

class CoffeeVendingMachine
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        double amount = double.Parse(Console.ReadLine());
        double prize = double.Parse(Console.ReadLine());
        double coin005 = n1 * 0.05;
        double coin010 = n2 * 0.1;
        double coin020 = n3 * 0.2;
        double coin050 = n4 * 0.5;
        double coin100 = n5 * 1.00;
        double coinsSum = coin005 + coin010 + coin020 + coin050 + coin100;
        if (amount > prize)
        {
            if (amount - prize > coinsSum)
            {
                Console.WriteLine("No {0:f2}", amount - prize - coinsSum);
            }
            else if (amount - prize < coinsSum)
            {
                Console.WriteLine("Yes {0:f2}", coinsSum - (amount - prize));
            }
        }
        else if (amount < prize)
        {
            Console.WriteLine("More {0:f2}",prize - amount);
        }
        else if (amount == prize)
        {
            Console.WriteLine("Yes {0:f2}",coinsSum);
        }
    }
}

