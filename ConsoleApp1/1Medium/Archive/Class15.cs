using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class15
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
            var a = new[] { 9 };

            var b = increment(a, 5);

            Console.WriteLine(string.Join(", ", b.ToArray()));

            Console.ReadLine();
        }

        private static int[] increment(int[] a, int val)
        {
            if (a.Length == 0)
                return a;

            return helper(a, a.Length-1, val);
        }

        private static int[] helper(int[] a, int index, int val)
        {
            if (index == -1) {
                var newA = new int[a.Length + 1];
                newA[0] = 1;
                for (int i = 1; i <= newA.Length-1; i++)
                {
                    newA[i] = a[i-1];
                }
                return newA;
            }

            a[index] += val;

            if (a[index] <= 9)
            {            
                return a;
            }
            a[index] = a[index] % 10;

            return helper(a, index - 1, val);            
        }
    }
}
