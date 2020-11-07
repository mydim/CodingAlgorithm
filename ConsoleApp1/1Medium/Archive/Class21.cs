using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class21
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

            var a = 500;
            var c = new[] { 25, 10 };
            var b = common(a,c);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);
            //Console.WriteLine(string.Join(", ", b.ToArray()));


            Console.ReadLine();
        }

        public static long common(int rest, int[] arr)
        {
            // var res = new Dictionary<int, int>();

            var count = helper(rest, arr, 0, new Dictionary<string, long>());

            //var curChangerIndex = 0;
            //while (rest > 0 && curChangerIndex < arr.Length)
            //{
            //    var curChangerValue = arr[curChangerIndex];
            //    var count = rest / curChangerValue;
            //    if (count > 0)
            //    {
            //        rest -= count * curChangerValue;
            //        res.Add(curChangerValue, count);                    
            //    }

            //    curChangerIndex++;
            //}

            return count;//res.Select(v=> v.Key +"="+v.Value).ToArray();
        }

        private static long helper(int rest, int[] arr, int v, Dictionary<string, long> mem)
        {
            var key = rest + "-" + v;

            if (mem.ContainsKey(key))
                return mem[key];

            if (rest == 0)
            {
                mem.Add(key, 1);
                return 1;
            }

            long count = 0;

            for (int curChangerIndex = v; curChangerIndex < arr.Length; curChangerIndex++)
            {
                var curChangerValue = arr[curChangerIndex];
                var coinCount = rest / curChangerValue;
                if (coinCount > 0)
                {
                    for (int i = 1; i <= coinCount; i++)
                    {
                        var newRest = rest - i * curChangerValue;
                        count += helper(newRest, arr, curChangerIndex + 1, mem);
                    }                                        
                }
            }

            mem.Add(key, count);
            return count;
        }
    }
}
