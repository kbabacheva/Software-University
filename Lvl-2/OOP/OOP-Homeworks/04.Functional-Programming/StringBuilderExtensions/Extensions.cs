using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensions
{
    public static class Extensions
    {
        public static string Substring(this StringBuilder strB, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();
            if (startIndex < 0 || startIndex > strB.Length || length > strB.Length || length < 1)
            {
                throw new IndexOutOfRangeException("Not in range");
            }
            for (int i = startIndex; i < length; i++)
            {
                result.Append(strB[i]);
            }
            return result.ToString();
        }

        public static StringBuilder RemoveText(this StringBuilder strB, string text)
        {
            strB.Replace(text, "");
            return strB;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder strB, IList<T> list)
        {
            foreach (var item in list)
            {
                strB.Append(item.ToString());
            }
            return strB;
        }
    }
}
