using System;

class MissCat
{
    static void Main()
    {
        //variant 2 - array

        int judge = int.Parse(Console.ReadLine());

        int[] cats = new int[11];

        for (int i = 0; i < judge; i++)
        {
            int mark = int.Parse(Console.ReadLine());
            cats[mark]++;
        }
        int max = 0;
        int result = 0;
        for (int i = 1; i < cats.Length; i++)
        {
            int currentValue = cats[i];
            if (max < currentValue)
            {
                max = currentValue;
                result = i;
            }
        }
        Console.WriteLine(result);

    //    variant 1 - without array
        //int n = int.Parse(Console.ReadLine());
        //int cat1Votes = 0;
        //int cat2Votes = 0;
        //int cat3Votes = 0;
        //int cat4Votes = 0;
        //int cat5Votes = 0;
        //int cat6Votes = 0;
        //int cat7Votes = 0;
        //int cat8Votes = 0;
        //int cat9Votes = 0;
        //int cat10Votes = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    int vote = int.Parse(Console.ReadLine());
        //    switch (vote)
        //    {
        //        case 1: cat1Votes++; break;
        //        case 2: cat2Votes++; break;
        //        case 3: cat3Votes++; break;
        //        case 4: cat4Votes++; break;
        //        case 5: cat5Votes++; break;
        //        case 6: cat6Votes++; break;
        //        case 7: cat7Votes++; break;
        //        case 8: cat8Votes++; break;
        //        case 9: cat9Votes++; break;
        //        case 10: cat10Votes++; break;
        //    }
        //}
        //int max = 0;
        //int maxCat = 0;
        //if (cat1Votes>max)
        //{
        //    max = cat1Votes;
        //    maxCat = 1;
        //}
        //if (cat2Votes > max)
        //{
        //    max = cat2Votes;
        //    maxCat = 2;
        //}
        //if (cat3Votes > max)
        //{
        //    max = cat3Votes;
        //    maxCat = 3;
        //}
        //if (cat4Votes > max)
        //{
        //    max = cat4Votes;
        //    maxCat = 4;
        //}
        //if (cat5Votes > max)
        //{
        //    max = cat5Votes;
        //    maxCat = 5;
        //}
        //if (cat6Votes > max)
        //{
        //    max = cat6Votes;
        //    maxCat = 6;
        //}
        //if (cat7Votes > max)
        //{
        //    max = cat7Votes;
        //    maxCat = 7;
        //}
        //if (cat8Votes > max)
        //{
        //    max = cat8Votes;
        //    maxCat = 8;
        //}
        //if (cat9Votes > max)
        //{
        //    max = cat9Votes;
        //    maxCat = 9;
        //}
        //if (cat10Votes > max)
        //{
        //    max = cat10Votes;
        //    maxCat = 10;
        //}
        //Console.WriteLine(maxCat);
    }
}

