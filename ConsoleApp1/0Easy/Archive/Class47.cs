using CodingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class47
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

            var a = new int[] { 1,2,3,4,5,6,7,8,9,10};
            var b = runningMedian(a);

            //    var b = common("I was here", "I have been here");
            CodeUtils.PrintArray(b);
            Console.WriteLine(b);

            Console.ReadLine();
        }

        static double[] runningMedian(int[] a)
        {
            if (a.Length == 0) return new double[] { };
            if (a.Length == 1) return new double[1] { (double)a[0] };

            if (a.Length == 2) return new double[1] { Math.Round((double)(a[0] + a[1]) / 2, 1) };

            Dictionary<int, int> dict = a.
                Select((value, index) => new { i = index, v = value }).
                OrderBy(v => v.v).
                ToDictionary(v => v.i, v => v.v);

            var res = new double[a.Length] ;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                res[i] = GetMedian(dict);
                dict.Remove(i);
            }

            return res;
        }

        static double GetMedian(Dictionary<int, int> dict)
        {
            var cnt = dict.Count;
            var mid = cnt / 2;
            if (cnt % 2 == 0)
            {
                return Math.Round((double)(dict.ElementAt(mid-1).Value + dict.ElementAt(mid).Value) / 2, 1);
            }
            else
            {
                return (double)dict.ElementAt(mid).Value;
            }
        }
    }
}
