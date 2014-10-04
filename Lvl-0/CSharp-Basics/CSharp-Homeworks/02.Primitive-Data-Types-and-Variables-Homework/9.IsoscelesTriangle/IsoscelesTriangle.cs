using System;
// Write a program that prints an isosceles triangle of 9 copyright symbols ©
class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        char copyRight = '\u00A9';
        Console.WriteLine(" " + " " + " " + copyRight);
        Console.WriteLine(" " + " " + copyRight + " " + copyRight);
        Console.WriteLine(" " + copyRight + " " + " " + " " + copyRight);
        Console.WriteLine(copyRight+ " " + copyRight + " " + copyRight + " " + copyRight);
    }
}

