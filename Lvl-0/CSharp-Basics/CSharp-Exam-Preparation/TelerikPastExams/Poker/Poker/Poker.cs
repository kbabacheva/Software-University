using System;

class Poker
{
    static void Main()
    {
        int[] cards = new int[5];
        int number = 0;
        for (int i = 0; i < 5; i++)
        {
            string card = Console.ReadLine();
            switch (card)
            {
                case "2": number = 2; break;
                case "3": number = 3; break;
                case "4": number = 4; break;
                case "5": number = 5; break;
                case "6": number = 6; break;
                case "7": number = 7; break;
                case "8": number = 8; break;
                case "9": number = 9; break;
                case "10": number = 10; break;
                case "J": number = 11; break;
                case "Q": number = 12; break;
                case "K": number = 13; break;
                case "A": number = 14; break;
            }
            cards[i] = number;
        }
        Array.Sort(cards);
        if (cards[0] == cards[1] && cards[1] == cards[2] && cards[2] == cards[3] && cards[3] == cards[4])
        {
            Console.WriteLine("Impossible");
        }
        else if ((cards[0] == cards[1] && cards[1] == cards[2] && cards[2] == cards[3] && cards[3] != cards[4])
            || (cards[0] != cards[1] && cards[1] == cards[2] && cards[2] == cards[3] && cards[3] == cards[4]))
        {
            Console.WriteLine("Four of a Kind");
        }
        else if ((cards[0] == cards[1] && cards[1] == cards[2] && cards[3] == cards[4])
            ||(cards[0] == cards[1] && cards[2] == cards[3] && cards[3] == cards[4]))
        {
            Console.WriteLine("Full House");
        }
        else if ((cards[0] == cards[1] && cards[1] == cards[2]) || (cards[1] == cards[2] && cards[2] == cards[3])
            || (cards[2] == cards[3] && cards[3] == cards[4]))
        {
            Console.WriteLine("Three of a Kind");
        }
        else if ((cards[0] + 1 == cards[1] && cards[1] + 1 == cards[2] && cards[2] + 1 == cards[3] && cards[3] + 1 == cards[4])
            || (cards[0] == 2 && cards[1] == 3 && cards[2] == 4 && cards[3] == 5 && cards[4] == 14))
        {
            Console.WriteLine("Straight");
        }
        else if ((cards[0] == cards[1] && (cards[2] == cards[3] || cards[3] == cards[4])) || cards[1] == cards[2] && cards[3] == cards[4])
        {
            Console.WriteLine("Two Pairs");
        }
        else if (cards[0] == cards[1] || cards[1] == cards[2] || cards[2] == cards[3] || cards[3] == cards[4])
        {
            Console.WriteLine("One Pair");
        }
        else if (cards[0] != cards[1] && cards[1] != cards[2] && cards[2] != cards[3] && cards[3] != cards[4])
        {
            Console.WriteLine("Nothing");
        }
    }
}

