using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class Test
    {
        static void Main(string[] args)
        {
            Fraction firstNum = new Fraction(22,3);
            Fraction secondNum = new Fraction(2,5);
            Fraction sum = firstNum + secondNum;
            Console.WriteLine(sum);
            Fraction minus = firstNum - secondNum;
            Console.WriteLine(minus);
        }
    }
}
