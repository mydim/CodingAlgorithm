using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class28
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
            var arr = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            
            var b = common(arr);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static int common(int[] arr)
        {
            int max = 0;
            int a = 0;
            int b = arr.Length - 1;
            while (a < b)
            {                
                if (arr[a] < arr[b])
                {
                    max = Math.Max(max, arr[a] * (b - a));
                    a++;
                }
                else {
                    max = Math.Max(max, arr[b] * (b - a));
                    b--;
                }        
            }
            return max;
        }
    }
}
