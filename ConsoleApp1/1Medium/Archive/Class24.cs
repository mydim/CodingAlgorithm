using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class24
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

            var a = "{[()]}{}{}{}{}]][[[";

            var dict = new Dictionary<char, char>();
            dict.Add('{','}');
            dict.Add('[',']');
            dict.Add('(',')');

            var b = common(a, dict);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static bool common(string str, Dictionary<char, char> dict)
        {
            var q = new Stack<char>();

            foreach (var c in str)
            {
                if (dict.ContainsKey(c))
                {
                    q.Push(c);
                }
                else
                {
                    if (q.Count == 0)
                    {
                        return false;
                    }

                    var aaa = q.Pop();
                    Console.WriteLine();
                    
                    if (dict[aaa] != c)
                    {
                        return false;
                    }
                }
            }

            return q.Count == 0;
        }
    }
}
