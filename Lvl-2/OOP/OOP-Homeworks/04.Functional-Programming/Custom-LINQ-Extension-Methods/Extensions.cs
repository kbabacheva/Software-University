using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_LINQ_Extension_Methods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(item => !predicate(item));
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            var list = new List<T>();
            var adds = collection.ToList();
            for (int i = 0; i < count; i++)
			{
                list.AddRange(adds);
			}
            return list as IEnumerable<T>;
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes) 
        {
            List<string> result = new List<string>();
            foreach (var item in collection)
            {
                foreach (var suffix in suffixes)
                {
                    if (item.EndsWith(suffix))
                    {
                        result.Add(item);
                    }
                }
            }
            return result as IEnumerable<string>;
        }
    }
}
