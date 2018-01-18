using System;
using System.Collections.Generic;
using System.Linq;

namespace IterationAndEexcute
{
    class Program
    {
        static void Main()
        {
            var arr = Enumerable.Range(1, 10).Cast<object>();

            var result = I.Iterate(arr, new object[] {"a", "b"}, (item, list) => item + (string) list[0] + (string) list[1]).Cast<string>();
            Console.WriteLine(string.Join(", ", result));

            Console.ReadKey();
        }
    }

    public class I
    {
        public static IList<object> Iterate(IEnumerable<object> items, object[] args, Func<object, object[], object> executeFunc)
        {
            return items.Select(item => executeFunc(item, args)).ToList();
        }
    }
}
