using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class41
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

            var arr = new int[3][];
            arr[0] = new int[2] { 1, 1 };
            arr[1] = new int[2] { 3, 4 };
            arr[2] = new int[2] { -1, 0 };

            var b = MinTimeToVisitAllPoints(arr);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static int MinTimeToVisitAllPoints(int[][] arr)
        {
            if (arr.Length < 2)
            {
                return arr.Length;
            }


            var first = arr[0];

            var sec = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                var cur = arr[i];

                sec += GetDiffSec(first, cur);
                first = cur;
            }

            return sec;
        }

        private static int GetDiffSec(int[] first, int[] cur)
        {
            var difX = Math.Abs(first[0] - cur[0]);
            var difY = Math.Abs(first[1] - cur[1]);

            var sec = Math.Min(difX, difY) + Math.Abs(difX - difY);
            return sec;
        }
    }
}
