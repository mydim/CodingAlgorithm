using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class38
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

            var a = "loonbalxballpoonloonbalxballpoonloonbalxballpoonloonbalxballpoon";
            var b = common(a);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static int common(string a)
        {
            var dict = new Dictionary<char, int>();
            dict.Add('b', 0);
            dict.Add('a', 0);
            dict.Add('l', 0);
            dict.Add('o', 0);
            dict.Add('n', 0);

            foreach (var c in a)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
            }

            return Math.Min(dict['b'], Math.Min(dict['a'], Math.Min(dict['l'] / 2, Math.Min(dict['o'] / 2, dict['n']))));
        }
    }
}
