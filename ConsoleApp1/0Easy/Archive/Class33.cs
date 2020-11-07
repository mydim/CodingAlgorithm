using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class33
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
            // var sb = ReverseWords("a good   example");
            //sb.Append

            var a = new[] { 2,4,1,6,5,10};
            var b = mult(a, 50);


            //  Console.WriteLine(string.Join(", ", b.ToArray()));
            //    var sb = ReverseWords("a good   example");
            //sb.Append
            Console.WriteLine(b);

         

            Console.ReadLine();
        }

        private static int[] mult(int[] arr, int m)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var val = arr[i];
                var find = m / val;

                var tr = findX(arr, i+1, find);
                if (tr)
                {
                    return new int[] {val, find };
                }
            }

            return null;

             
        }

        private static bool findX(int[] arr, int from, int m)
        {
            for (int i = from; i < arr.Length; i++)
                if (arr[i] == m) return true;

            return false;
        }
    }
}
