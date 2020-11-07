using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class20
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

            var b = common("I was here", "I have been here");

             Console.WriteLine(b);

            Console.ReadLine();
        }

        public static string common(string str1, string str2)
        {
            var longest = GetCommon(str1, str2, 0, 0, new Dictionary<string, string>());
            return longest;
        }

        private static string GetCommon(string str1, string str2, int i1, int j1, Dictionary<string, string> mem)
        {
            var key = i1 + ":" + j1;
            if (mem.ContainsKey(key))
                return mem[key];

            if (i1 == str1.Length || j1 == str2.Length)
            {
                mem.Add(key, "");
                return "";
            }

            var longest = "";

            string check;
            if (str1[i1] == str2[j1])
            {
                check = str1[i1] + GetCommon(str1, str2, i1 + 1, j1 + 1, mem);
            } else
            {
                var check1 = GetCommon(str1, str2, i1 + 1, j1, mem);
                var check2 = GetCommon(str1, str2, i1, j1 + 1, mem);
                check = check1.Length > check2.Length ? check1 : check2;
            }

            if (check.Length > longest.Length)
            {
                longest = check;
            }

            mem.Add(key, longest);
            return longest;
        }
    }
}
