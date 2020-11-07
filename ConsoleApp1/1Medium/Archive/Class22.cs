using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class22
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

            var a = new[,]{
                { 0, 0, 0, 1, 1, 0, 0 },
                { 1, 0, 0, 0, 1, 1, 0 },
                { 1, 0, 0, 1, 1, 0, 0 },
                { 1, 1, 0, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 1, 1, 1 },
            };
            var b = common(a);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine();
            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static int common(int[,] matrix)
        {
            var visited = new HashSet<string>();
            var res = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(" " + matrix[row, column]);
                    var region = findWholeRegionSize(matrix, row, column, visited);                    
                    if (region > res)
                    {
                        res = region;
                    }
                }
            }
            
            return res;
        }

        private static int findWholeRegionSize(int[,] matrix, int row, int column, HashSet<string> visited)
        {
            if (row < 0 || column < 0 || row >= matrix.GetLength(0) || column >= matrix.GetLength(1))
                return 0;

            var key = row + "-" + column;
            if (visited.Contains(key))
            {
                return 0;
            }

            visited.Add(key);

            if (matrix[row, column] == 0)
            {
                return 0;
            }

            // 0 0 0
            // 0 c 0 
            // 0 0 0

            var count = 1;

            // row, column+1
            var rc1 = findWholeRegionSize(matrix, row, column + 1, visited);

            // row+1, column-1
            var r1c_1 = findWholeRegionSize(matrix, row + 1 , column -1, visited);

            // row+1, column
            var r1c = findWholeRegionSize(matrix, row + 1, column , visited);

            // row+1, column+1
            var r1c1 = findWholeRegionSize(matrix, row + 1, column + 1, visited);


            return count + rc1 + r1c_1 + r1c + r1c1;
        }
    }
}
