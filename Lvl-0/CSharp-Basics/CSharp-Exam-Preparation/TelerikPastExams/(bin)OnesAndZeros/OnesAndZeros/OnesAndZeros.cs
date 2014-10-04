using System;

class OnesAndZeros
{
    static void Main()
    {
        string str = Console.ReadLine();
        int n = int.Parse(str);
        string binary32 = Convert.ToString(n, 2).PadLeft(32, '0');

        // making new string with 16 digits
        string binary0 = new string(binary32[16],1);
        string binary1 = new string(binary32[17], 1);
        string binary2 = new string(binary32[18], 1);
        string binary3 = new string(binary32[19], 1);
        string binary4 = new string(binary32[20], 1);
        string binary5 = new string(binary32[21], 1);
        string binary6 = new string(binary32[22], 1);
        string binary7 = new string(binary32[23], 1);
        string binary8 = new string(binary32[24], 1);
        string binary9 = new string(binary32[25], 1);
        string binary10 = new string(binary32[26], 1);
        string binary11 = new string(binary32[27], 1);
        string binary12 = new string(binary32[28], 1);
        string binary13 = new string(binary32[29], 1);
        string binary14 = new string(binary32[30], 1);
        string binary15 = new string(binary32[31], 1);
        string binary = binary0 + binary1 + binary2 + binary3 + binary4 + binary5 + binary6 + binary7
            + binary8 + binary9 + binary10 + binary11 + binary12 + binary13 + binary14 + binary15;

        // first line
        for (int i = 0; i < binary.Length - 1; i++)
        {
            if (binary[i] == '0')
            {
                Console.Write(new string('#', 3));
            }
            if (binary[i] == '1')
            {
                Console.Write(new string('.',1));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', 1));
            }
                Console.Write(new string('.', 1));
        }
        if (binary[15] == '1')
        {
            Console.Write(new string('.', 1));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', 1));
        }
        else
        {
            Console.Write(new string('#', 3));
        }
        Console.WriteLine();

        //second line
        for (int i = 0; i < binary.Length - 1; i++)
        {
            if (binary[i] == '0')
            {
                Console.Write(new string('#', 1));
                Console.Write(new string('.', 1));
                Console.Write(new string('#', 1));
            }
            if (binary[i] == '1')
            {
                Console.Write(new string('#', 1));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', 1));
            }
            Console.Write(new string('.', 1));
        }
        if (binary[15] == '1')
        {
            Console.Write(new string('#', 1));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', 1));
        }
        else
        {
            Console.Write(new string('#', 1));
            Console.Write(new string('.', 1));
            Console.Write(new string('#', 1));
        }
        Console.WriteLine();
        //third and firth line
        for (int k = 0; k < 2; k++)
        {
            for (int i = 0; i < binary.Length - 1; i++)
        {
            if (binary[i] == '0')
            {
                Console.Write(new string('#', 1));
                Console.Write(new string('.', 1));
                Console.Write(new string('#', 1));
            }
            if (binary[i] == '1')
            {
                Console.Write(new string('.', 1));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', 1));
            }
            Console.Write(new string('.', 1));
        }
        if (binary[15] == '1')
        {
            Console.Write(new string('.', 1));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', 1));
        }
        else
        {
            Console.Write(new string('#', 1));
            Console.Write(new string('.', 1));
            Console.Write(new string('#', 1));
        }
        Console.WriteLine(); 
        }
        //fifth line
        for (int i = 0; i < binary.Length - 1; i++)
        {
            Console.Write(new string('#', 3));
            Console.Write(new string('.', 1));
        }
        Console.Write(new string('#', 3));
        Console.WriteLine();
    }
}

