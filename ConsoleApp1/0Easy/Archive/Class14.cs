using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class14
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

            var pref = LongestCommonPrefix(new string[] {"flower", "flow", "flight"});

            Console.WriteLine(pref);
            Console.ReadLine();
        }


        public static string LongestCommonPrefix(string[] strs)
        {
            var pref = "";

            var isPossibleToReadData = true;
            var checkCharIndex = 0;

            var curChar = Char.MinValue;

            while (isPossibleToReadData)
            {
                if (strs[0].Length > checkCharIndex)
                    curChar = strs[0][checkCharIndex];
                else
                     break;

                var prefNew = pref + curChar;

                foreach (var str in strs)
                {
                    if (checkCharIndex == str.Length  || str[checkCharIndex] != curChar)
                        isPossibleToReadData = false;
                }

                if (isPossibleToReadData)
                {
                    pref = prefNew;
                    checkCharIndex++;
                }
            }

            return pref;
        }

    }
}
