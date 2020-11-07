using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class23
    {
        public static void RunCode()
        {
            //_arrayData = new List<KeyValuePair<int, int>>();
            //var arr1 = new int[0];
            //var arr2 = new int[] { };
            //int[] arr3 = { };
            //var arr4 = Enumerable.Empty<int>().ToArray();
            //var arr5 = Array.Empty<int>();
            //var arr6 = new List<int>().ToArray();
            //int count=0;
            //Math.Max
            //Math.Min
            //(bln ? 1 : 0)
            //int.Parse(res);


            //for (int i = 0; i < length; i++)
            //{

            //}

            //foreach (var item in collection)
            //{

            //}

            var a = 10;
            var b = common(a);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static int common(int a)
        {
            var mem = new Dictionary<int, int>();

            var count = helper(a, 0, mem);
            return count;
        }

        private static int helper(int max, int from, Dictionary<int, int> mem)
        {
            if (!mem.ContainsKey(from))
            {
                int res;
                if (from > max)
                {
                    res = 0;
                }
                else
                if (from == max)
                {
                    res = 1;
                }
                else
                {
                    res = helper(max, from + 1, mem) + helper(max, from + 2, mem);                    
                }
                mem.Add(from, res);
            }

            return mem[from];
        }
    }
}
