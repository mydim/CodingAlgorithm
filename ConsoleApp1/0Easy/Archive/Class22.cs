using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class22
    {
    //    665. Non-decreasing Array
    //Easy
    //923
    //193
    //Favorite
    //Share
    //Given an array with n integers, your task is to check if it could become non-decreasing by modifying at most 1 element.
    //We define an array is non-decreasing if array[i] <= array[i + 1] holds for every i(1 <= i<n).
    //Example 1:
    //Input: [4,2,3]
    //Output: True
    //Explanation: You could modify the first 4 to 1 to get a non-decreasing array.
    //Example 2:
    //Input: [4,2,1]
    //Output: False
    //Explanation: You can't get a non-decreasing array by modify at most one element.
    //Note: The n belongs to [1, 10,000].

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
            var arr = new[] {4, 2, 1};
            var b = CheckPossibility(arr);
            //Console.WriteLine(b);
            Console.ReadLine();
        }

        public static bool CheckPossibility(int[] nums)
        {
            var prev = nums[0];
            var used = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                var cur = nums[i];
                if (cur > prev)
                {
                    used++;
                    if (used > 1)
                        break;
                    prev = prev + 1;
                }
                else
                    prev = cur;
            }

            return used < 2;
        }

    }
}
