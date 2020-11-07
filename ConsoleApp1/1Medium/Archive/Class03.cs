using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class03
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
            //Console.Write("");
            //Console.ReadLine();

            //return ;
        }


        ///static List<KeyValuePair<int, int>> _arrayData;
        ///static List<KeyValuePair<int, int>> _books;


        public static int[] TwoSum(int[] nums, int target)
        {

            


            for (var i = 0; i < nums.Length; i++)
                for (var j = 0; j < nums.Length; j++)
                {
                    if ((i != j) && (nums[i] + nums[j] == target))
                        return new[] { i, j };

                }

            return new int[] { };
        }

    }
}
