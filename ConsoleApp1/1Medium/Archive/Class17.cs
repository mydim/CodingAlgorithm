using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class17
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
            var b = ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
            //  Console.WriteLine(string.Join(", ", b.ToArray()));

            Console.ReadLine();
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            //Array.Sort(nums);

            var list = new List<IList<int>>();

            //var previ1 = int.MinValue;
            //for (int i1 = 0; i1 <= nums.Length-1; i1++)
            //{
            //    if (previ1 == nums[i1])
            //        continue;
            //    previ1 = nums[i1];[]

            //    var previ2 = int.MinValue;
            //    for (int i2 = i1 + 1; i2 <= nums.Length - 1; i2++)
            //    {

            //        if (previ2 == nums[i2])
            //            continue;
            //        previ2 = nums[i2];
            //        var previ3 = int.MinValue;
            //        for (int i3 = i2 + 1; i3 <= nums.Length - 1; i3++)
            //        {

            //            if (previ3 == nums[i3])
            //                continue;
            //            previ3 = nums[i3];

            //            if (nums[i1] + nums[i2] + nums[i3] == 0)
            //            {
            //                var l = new List<int>();
            //                l.Add(nums[i1]);
            //                l.Add(nums[i2]);
            //                l.Add(nums[i3]);
            //                list.Add(l);
            //            }
            //        }
            //    }
            //}

            return list;
        }
    }
}
    
