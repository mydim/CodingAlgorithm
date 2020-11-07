using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class13
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

            //    var b = LetterCombinations("237");

            //  Console.WriteLine(string.Join(", ", b.ToArray()));
            
            var arr = new[] { 2, 4, 6 };
            var mem = new Dictionary<string, int>();
            var b = count(arr, 15, arr.Length - 1, mem);

            Console.WriteLine(b);
            Console.WriteLine(string.Join(", ", mem.Select(a => a.Key).ToArray()));
            Console.WriteLine(string.Join(", ", mem.Select(a => a.Value).ToArray()));

            Console.ReadLine();
        }

        public static int count(int[] arr, int total, int index, Dictionary<string,int> mem)
        {
            

            var key = total.ToString() + ":" + index;

            Console.WriteLine(key + " > check total:" + total + " index:" + index);
            if (mem.ContainsKey(key))
            {
                Console.WriteLine("use cache");
                return mem[key];
            }

            if (total == 0)
                return 1;

            if (total < 0)
                return 0;

            if (index < 0)
                return 0;

            int toreturn;

            if (total < arr[index])
                toreturn = count(arr, total, index - 1, mem);
            else
                toreturn = count(arr, total - arr[index], index - 1, mem) +
                            count(arr, total, index - 1, mem);

            mem[key] = toreturn;

            Console.WriteLine("toreturn:" + toreturn);

            // Console.WriteLine(string.Join(", ", mem.Select(a=>a.Key).ToArray()));
            return toreturn;
        }
    }
}
