using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    throw new ArithmeticException("Square root cannot be negative");
                    
                }
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
                //Console.WriteLine("Valid operation");
            }
            catch (FormatException)
            {
                throw new Exception("Invalid number");
            }
            finally
            {
                Console.WriteLine("good bye");
            }
        }
    }
}
