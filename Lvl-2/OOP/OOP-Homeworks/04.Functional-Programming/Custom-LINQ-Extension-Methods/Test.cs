using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_LINQ_Extension_Methods
{
    class Test
    {
        static void Main()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
            string result = string.Join(", ",nums.WhereNot<int>(a => a == 2));
            Console.WriteLine(result);
            string result2 = string.Join(", ",nums.Repeat<int>(3));
            Console.WriteLine(result2);
            List<string> words = new List<string>(){"Comming", "Driving","Crying", "Run", "See"};
            List<string> suffixes = new List<string>(){"ing","ee"};
            string suffix = string.Join(", ", words.WhereEndsWith(suffixes));
            Console.WriteLine(suffix);
        }
    }
}
