using System;

class Garden
{
    static void Main()
    {
        ushort tomatoSeeds = ushort.Parse(Console.ReadLine());
        ushort tomatoArea = ushort.Parse(Console.ReadLine());
        ushort cucumberSeeds = ushort.Parse(Console.ReadLine());
        ushort cucumberArea = ushort.Parse(Console.ReadLine());
        ushort patatoSeeds = ushort.Parse(Console.ReadLine());
        ushort patatoArea = ushort.Parse(Console.ReadLine());
        ushort carrotSeeds = ushort.Parse(Console.ReadLine());
        ushort carrotArea = ushort.Parse(Console.ReadLine());
        ushort cabbageSeeds = ushort.Parse(Console.ReadLine());
        ushort cabbageArea = ushort.Parse(Console.ReadLine());
        ushort beanSeeds = ushort.Parse(Console.ReadLine());
        ushort beanArea;

        ushort totalArea = 250;
        float tomatoCost = 0.5f;
        float cucumberCost = 0.4f;
        float patatoCost = 0.25f;
        float carrotCost = 0.6f;
        float cabbageCost = 0.3f;
        float beanCost = 0.4f;
        float totalCost = tomatoSeeds * tomatoCost + cucumberSeeds * cucumberCost + patatoSeeds * patatoCost +
            carrotSeeds * carrotCost + cabbageSeeds * cabbageCost + beanSeeds * beanCost;
        Console.WriteLine("Total costs: {0:F2}",totalCost);
        ushort vegetablesArea = (ushort)(tomatoArea + cucumberArea + patatoArea + carrotArea + cabbageArea);
        beanArea = (ushort)(totalArea - vegetablesArea);
        if (vegetablesArea > totalArea)
        {
            Console.WriteLine("Insufficient area");
        }
        else
        {
            if (beanArea <= 0)
            {
                Console.WriteLine("No area for beans");
            }
            else if (beanArea > 0)
            {
                Console.WriteLine("Beans area: " + beanArea);
            }
        }
    }
}

