namespace CSharpPartOneExam
{
    using System;
    class NightmareOnCodeStreet
    {
        static bool isDigit(char c)
        {
            bool digit = (c >= '0') && (c <= '9');
            return digit;
        }

        static void Main()
        {
            string text = Console.ReadLine();
            int count = 0;
            int sum = 0;
            int length = text.Length;
            for (int i = 1; i < length; i += 2)
            {
                if (isDigit(text[i]))
                {
                    count++;
                    sum += text[i] - '0';
                }
            }
            Console.WriteLine("{0} {1}", count, sum);
        }
    }
}




// 70 PTS IN BGCODER
//using System;
//using System.Linq;

//class Nightmare
//{
//    static void Main()
//    {
//        string inputWithLetters = Console.ReadLine();
//        string input = new String(inputWithLetters.Where(Char.IsDigit).ToArray()); // removing letters
//        long number = 0;
//        long totalSum = 0;
//        long counter = 0;
//        for (int i = 1; i < input.Length; i+=2)
//        {
//            number = input[i] - 48;
//            totalSum += number;
//            counter++;
//        }
//        Console.WriteLine(counter + " " + totalSum);
//    }
//}

