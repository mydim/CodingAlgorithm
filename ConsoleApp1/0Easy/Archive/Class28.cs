using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
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

            //    var b = LetterCombinations("237");

            //  Console.WriteLine(string.Join(", ", b.ToArray()));

            var a = new[,] {    { 1,              3 },     { 5, 6 }, { 10,           20 } };
            var b = new[,] { { 0, 1 }, {    2, 2 }    , { 4,              15 }, { 19,       21 } };
            // c = new[,] { { 2, 2 }, { 5, 6 }, {10, 15}, { 99, 100 } };

            var c = GetOtrezki(a, b);

            Console.ReadLine();
        }

        public static List<Tuple<int, int>> GetOtrezki(int[,] a, int[,] b)
        {
            var result = new List<Tuple<int, int>>();
            
            var indexB = 0;

            for (int indexA = 0; indexA < a.GetLength(0); indexA++)
            {
                if (indexB == b.GetLength(0))
                {
                    break;
                }

                var startA = a[indexA, 0];
                var endA = a[indexA, 1];

                var startB = b[indexB, 0];
                var endB = b[indexB, 1];

                GetOtrezok(startA, endA, startB, endB, result);         

                if (endA == endB)
                {
                    indexB++;
                } else
                if (endA > endB)
                {
                    indexA--;
                    indexB++;
                }
            }

            return result;
        }

        public static void GetOtrezok(int startA, int endA, int startB, int endB, List<Tuple<int, int>> result)
        {
            // - 1 2 3 -
            // 0 - - - -
            if (endB < startA)
            {
                return ;
            }

            // - 1 2 3 -
            // - - - - 4
            if (startB > endA)
            {
                return ;
            }

            var startC = Math.Max(startA, startB);
            var endC = Math.Min(endA, endB);

            var res = new Tuple<int, int>(startC, endC);
            result.Add(res);
        }
    }
}
