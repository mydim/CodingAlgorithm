using CodingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class39
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

            var a = "pwwkew";
            var b = LengthOfLongestSubstring(a);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static int LengthOfLongestSubstring(string a)
        {

            var hash = new HashSet<char>();

            var p1 = 0;
            var p2 = 0;

            var maxLength = 0;

            while (p1 < a.Length && p2 < a.Length) {

                if (!hash.Contains(a[p2]))
                {
                    hash.Add(a[p2]);
                    maxLength = Math.Max(maxLength, hash.Count);
                    p2++;
                }
                else {
                    hash.Remove(a[p1]);
                    p1++;
                }
            }

            return maxLength;
        }
    }
}
