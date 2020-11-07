using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class35
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

            var arr1 = new[] { 1,3,5};
            var arr2 = new[] { 2, 4, 6 };

            var b = common(arr1,arr2);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(string.Join(", ", b.ToArray()));

            Console.ReadLine();
        }

        public static int[] common(int[] arr1, int[] arr2)
        {
            var list = new List<int>();
            int j = 0;
            int i = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                var v1 = arr1[i];
                var v2 = arr2[j];
                if (v1 > v2)
                {
                    list.Add(v2);
                    j++;
                } else
                {
                    list.Add(v1);
                    i++;
                }
            }

            for (int a = i; a < arr1.Length; a++)
            {
                var v1 = arr1[a];
                list.Add(v1);
            }

            for (int a = j; a < arr2.Length; a++)
            {
                var v2 = arr2[a];
                list.Add(v2);
            }

            return list.ToArray();
        }
    }
}
