using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
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

            //    var b = LetterCombinations("237");

            //Facebook Coding Interview Question - How Many Ways to Decode This Message

            //  Console.WriteLine(string.Join(", ", b.ToArray()));
            var str = "121212121212";
            var b = getways(str);
            Console.WriteLine(b);
            Console.ReadLine();
        }

        private static int getways(string s)
        {
            var mem = new Dictionary<int, int>();
            return getways_dp(s, s.Length, mem);
        }

        private static int getways_dp(string str, int elementIndex, Dictionary<int, int> mem)
        {
            if (elementIndex == 0) return 1;

            var curIndex = str.Length - elementIndex; //2-2

            if (str[curIndex] == '0') return 0;


            if (mem.ContainsKey(curIndex))
            {
                Console.Write(curIndex.ToString() + " ");

                return mem[curIndex];
            }

            var res = getways_dp(str, elementIndex - 1, mem);

            if (curIndex <= str.Length - 2)
            {
                var v = int.Parse(str.Substring(curIndex, 2));
                if (v <= 26)
                {
                    res += getways_dp(str, elementIndex - 2, mem);
                }
            }

            mem[curIndex] = res;

            return res;
        }

        //
    }
}
