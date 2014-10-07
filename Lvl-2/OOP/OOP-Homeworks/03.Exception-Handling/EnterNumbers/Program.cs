using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
      //  int start = 1;
        const int end = 100;

        public static void Main()
        {
            int start = 0;
            var numbers = new int[10];

            Console.WriteLine("Enter number: [0-100]");
            for (int i = 1; i < numbers.Length; i++)
            {
              //  bool isValid = false;
                try
                {
                    numbers[0] = 0;
                    numbers[i] = ReadNumber(start, end);
                    if (numbers[i] < numbers[i-1] )
                    {
                        throw new ArithmeticException("Invalid number");
                    }
                    Console.WriteLine("Enter number:" + numbers[i] + " < Number < 100");
                }
                catch (FormatException)
                {
                    Console.WriteLine("The number must to be in range [" + numbers[i] + ".." + end + "]");
                }
                catch(ArithmeticException)
                {
                    Console.WriteLine("The number must be greater than " + numbers[i - 1]);
                }
               // Console.WriteLine("Enter number:" + numbers[i] + " < Number < 100");
            }
        }
        public static int ReadNumber(int start, int end)
        {
          //  Console.WriteLine("Enter number " + start + " < Number < " + end);
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if(number > end || number < start)
            {
                throw new IndexOutOfRangeException("Number is not in range");
            }
            return number;
        }
    }
}
