using System;


class MathFormula
{
    static void Main(string[] args)
    {
        decimal N = decimal.Parse(Console.ReadLine());
        decimal M = decimal.Parse(Console.ReadLine());
        decimal P = decimal.Parse(Console.ReadLine());

        decimal firstresult = (N * N) + (1 / (M * P)) + 1337;
        decimal secondResult = N - 128.523123123M * P;
        decimal thirdResult = firstresult / secondResult;
        double angle = (int)M % 180;
        double mMod = Math.Sin(angle);

        decimal finalResult = thirdResult + (decimal)mMod;
        decimal output = Math.Round(finalResult, 6);
        Console.WriteLine(output);
    }
}

