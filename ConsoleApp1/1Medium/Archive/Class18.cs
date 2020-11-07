using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class18
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
            var b = MaxSubArraySum(new int[] { -1, 0, 1, 2, -1, -4 });
            //  Console.WriteLine(string.Join(", ", b.ToArray()));

            Console.ReadLine();
        }

        private static int MaxSubArraySum(int[] arr)
        {
            var max = arr[0];
            var curMax = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                curMax = Math.Max(arr[i], curMax + arr[i]);
                if (curMax > max)
                {
                    max = curMax;
                }
            }

            return max;
        }
    }
}
