using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensions
{
    class Test
    {
        public static void Main()
        {
            StringBuilder s = new StringBuilder();
            s.Append("Name:Petya");
            Console.WriteLine(s);
            string result = s.Substring(0,4);
            Console.WriteLine(result);
            s.RemoveText("Na");
            Console.WriteLine(s);
            List<int> nums = new List<int>() { 1, 2, 3 };
            s.AppendAll(nums);
            Console.WriteLine(s);
        }
    }
}
