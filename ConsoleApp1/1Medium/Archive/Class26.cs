using Newtonsoft.Json.Bson;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class26
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

            var a = new int[] { 100, 4, 200, 1, 3, 2 };

            var b = common(a);

            Console.WriteLine(b);
            ///   Console.WriteLine(string.Join(", ", b.ToArray()));

            Console.ReadLine();
        }

        public static int common(int[] arr)
        {
            var max_seq = 0;

            var set = new HashSet<int>();
            foreach (var item in arr)
            {
                set.Add(item);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                var val = arr[i];
                var cur_seq = 0;

                if (!set.Contains(val - 1))
                {
                    while (set.Contains(val + 1))
                    {
                        cur_seq++;
                        val++;
                    }
                }
                max_seq = Math.Max(max_seq, cur_seq);
            }

            return max_seq;
        }

        private static bool isNextExists(int[] arr, int v)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == v)
                    return true;
            }
            return false;
        }
    }
}
