using System;
using System.Collections.Generic;

    class Horror
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long currentNumber = 0;
            long sum = 0;
            long counter = 0;
            for (int i = 0; i < input.Length; i += 2)
            {

                char x = input[i];
                if (!(char.IsDigit(x))) // If there is char in the string
                {

                    continue;
                }
                else
                {
                    currentNumber = long.Parse(Convert.ToString(x));
                    counter++;
                    sum += currentNumber;
                }

            }
            Console.WriteLine(counter + " " + sum);
        }
    }








//using System;
//using System.Numerics;
//using System.Text.RegularExpressions;

//class TheHorror
//{
//    static void Main()
//    {
//        string input = Console.ReadLine();
//        string transformed = (Regex.Replace(input, "[^0-9]", ""));//Replacing where there is char with ""
//        Console.WriteLine(transformed.Length);
//        BigInteger number = BigInteger.Parse(transformed);
//        BigInteger result = 0;
//        BigInteger sum = 0;
//        BigInteger counter = 0;
//        if (transformed.Length % 2 != 0)
//        {
//            for (int i = 0; i <= transformed.Length/2; i++)
//            {
//                result = number % 10;
//                sum += result;
//                number /= 100;
//                counter++;
//            }
//            Console.Write(counter);
//            Console.Write(" ");
//            Console.Write(sum);
//        }
//        if (transformed.Length % 2 == 0)
//        {
//            number /= 10;
//            for (int i = 0; i <= (transformed.Length-1)/2; i++)
//            {
//                result = number % 10;
//                sum += result;
//                number /= 100;
//                counter++;
//            }
//            Console.Write(counter);
//            Console.Write(" ");
//            Console.Write(sum);
//        }
//    }
//}

