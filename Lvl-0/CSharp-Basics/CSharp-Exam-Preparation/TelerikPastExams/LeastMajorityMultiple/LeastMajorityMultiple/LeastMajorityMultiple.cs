using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int[] myArray = new int[5];
        myArray[0] = a;
        myArray[1] = b;
        myArray[2] = c;
        myArray[3] = d;
        myArray[4] = e;
        Array.Sort(myArray);
        int divider = myArray[2];
        int maxDivider = myArray[0] * myArray[1] * myArray[2] * myArray[3];
        for (int i = divider; i < maxDivider; i++)
        {
            if (i % myArray[0] == 0 && i % myArray[1] == 0 && i % myArray[2] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % myArray[0] == 0 && i % myArray[1] == 0 && i % myArray[3] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % myArray[0] == 0 && i % myArray[1] == 0 && i % myArray[4] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % myArray[0] == 0 && i % myArray[2] == 0 && i % myArray[3] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % myArray[0] == 0 && i% myArray[2] == 0 && i % myArray[4] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % myArray[0] == 0 && i % myArray[3] == 0 && i % myArray[4] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % myArray[1] == 0 && i % myArray[2] == 0 && i % myArray[3] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % myArray[1] == 0 && i % myArray[2] == 0 && i % myArray[4] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % myArray[1] == 0 && i % myArray[3] == 0 && i % myArray[4] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % myArray[2] == 0 && i % myArray[3] == 0 && i % myArray[4] == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}

