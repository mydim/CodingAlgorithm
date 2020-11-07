using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class09
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

            //Console.WriteLine(b);
            Console.ReadLine();
        }

        public static int minimumDays(int rows, int columns, int[,] grid)
        {
            var isAnyUpdatedOverAll = NextDay(grid);
            if (!isAnyUpdatedOverAll)
            {
                return 0;
            }

            var cntDays = 1;

            while (NextDay(grid))
            {
                cntDays++;
            }

            return cntDays;
        }

        public static bool NextDay(int[,] grid)
        {
            var rowsHeight = grid.GetLength(0);
            var colsWidth = grid.GetLength(1);

            var isAnyUpdatedOverAll = true;
            for (int row = 0; row < rowsHeight; row++)
            {
                for (int column = 0; column < colsWidth; column++)
                {
                    isAnyUpdatedOverAll = isAnyUpdatedOverAll && UpdateAdjacents(grid, row, column);                    
                }
            }

            return isAnyUpdatedOverAll;
        }

        private static bool UpdateAdjacents(int[,] grid, int row, int column)
        {
            var s1 = UpdateServer(grid, row - 1, column);
            var s2 = UpdateServer(grid, row + 1, column);
            var s3 = UpdateServer(grid, row, column - 1);
            var s4 = UpdateServer(grid, row, column + 1);

            return s1 || s2 || s3 || s4;
        }

        private static bool UpdateServer(int[,] grid, int row, int column)
        {
            if (row < 0 || column < 0)
            {
                return false;
            }

            var rowsHeight = grid.GetLength(0);
            var colsWidth = grid.GetLength(1);
            if (row == rowsHeight || column == colsWidth)
            {
                return false;
            }

            if (grid[row, column] == 1)
            {
                return false;
            }

            grid[row, column] = 1;
            return true;
        }

        public static List<string> popularNFeatures(int numFeatures,
                                    int topFeatures,
                                    List<string> possibleFeatures,
                                    int numFeatureRequests,
                                    List<string> featureRequests)
        {

            var dict = new Dictionary<string, int>();

            foreach (var str in featureRequests)
            {
                foreach (var features in possibleFeatures)
                {
                    if (str.Contains(features))
                    {
                        if (dict.ContainsKey(features))
                        {
                            dict[features]++;
                            var cnt = dict[features];
                        }
                        else
                        {
                            dict.Add(features, 1);
                        }
                    }
                }
            }

            var sortResult = dict.OrderByDescending(a => a.Value).ThenBy(a => a.Key).Select(c=>c.Key).ToList();
            return sortResult.GetRange(0, topFeatures);

            //for (int i = 0; i < length; i++)
            //{
            //    sortResult
            //}
           
            //foreach (var pair in dict)
            //{
            //    if (pair.Value == maxCount)
            //    {
            //        res.Add(pair.Key);
            //    }
            //}
            //res.Sort();
            ////res.Sort(delegate (string s1, string s2) { return });

            //return res;// c => c);
        }



    }
}
