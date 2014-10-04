using System;
// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter an unsigned integer:");
        uint number = uint.Parse(Console.ReadLine());
        int position3 = 3;
        int position4 = 4;
        int position5 = 5;
        int position24 = 24;
        int position25 = 25;
        int position26 = 26;

        int bit3 = (int)(number >> position3) & 1;
        int bit4 = (int)(number >> position4) & 1;
        int bit5 = (int)(number >> position5) & 1;
        int bit24 = (int)(number >> position24) & 1;
        int bit25 = (int)(number >> position25) & 1;
        int bit26 = (int)(number >> position26) & 1;

        number = number & (uint)(~(1 << position24)) | (uint)(bit3 << position24);
        number = number & (uint)(~(1 << position25)) | (uint)(bit4 << position25);
        number = number & (uint)(~(1 << position26)) | (uint)(bit5 << position26);
        number = number & (uint)(~(1 << position3)) | (uint)(bit24 << position3);
        number = number & (uint)(~(1 << position4)) | (uint)(bit25 << position4);
        number = number & (uint)(~(1 << position5)) | (uint)(bit26 << position5);

        Console.WriteLine(number);
    }
}

