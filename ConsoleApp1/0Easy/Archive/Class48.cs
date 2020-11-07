using CodingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class48
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

            var a = new int[] { 1, 2, 3};
            var b = Subsets2(a);
            foreach (var item in b)
            {
                CodeUtils.PrintArray(item.ToArray(),true);
            }



            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static string common(string a)
        {
            return a;
        }

        public static IList<IList<int>> Subsets2(int[] nums)
        {
            var res = new List<IList<int>>();
            res.Add(new List<int>());

            for (int i = 0; i < nums.Length; i++)
            {
                var c = res.Count;
                for (int j = 0; j < c; j++) {
                    var nr = new List<int>(res[j]);
                    nr.Add(nums[i]);
                    res.Add(nr);
                }
            }



            //GenSub(0, nums, new List<int>(), res);

            return res;
        }



        public static IList<IList<int>> Subsets(int[] nums)
        {
            var res = new List<IList<int>>();
            GenSub(0, nums, new List<int>(), res);

            return res;
        }

        public static void GenSub(int index, int[] nums, List<int> current, List<IList<int>> res)
        {
            var range = new List<int>(current);
            res.Add(range);

            Console.WriteLine("i:"+ index +" Current:>");
            CodeUtils.PrintArray(current.ToArray(), true, " >>>>>>> {0}");

            for (int i = index; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                GenSub(i + 1, nums, current, res);

                //current.RemoveAt(current.Count() - 1);
            }
        }
    }
}
