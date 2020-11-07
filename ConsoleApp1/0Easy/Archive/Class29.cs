using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class29
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

               var b = rob(new []{ 100,200,101 });
            Console.WriteLine(b);
            //  Console.WriteLine(string.Join(", ", b.ToArray()));

            Console.ReadLine();
        }

        private static int rob(int[] arr)
        {
            if (arr.Length == 0) return 0;

            if (arr.Length == 1) return arr[0];

            if (arr.Length == 2) return 0;

            var mem = new Dictionary<int, int>();


            return Math.Max(helper(arr, 0, mem), helper(arr, 1, mem));

        }

        private static int helper(int[] arr, int index, Dictionary<int, int> mem)
        {
            if (index >= arr.Length) return 0;

            if (mem.ContainsKey(index))
                return mem[index];

            var res = arr[index] + Math.Max(helper(arr, index + 2, mem), helper(arr, index + 3, mem));

            mem[index] = res;
            return res;
        }
    }
}
