using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class15
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


            var b = IsValid("[([]])");

            Console.WriteLine(b);
            Console.ReadLine();
        }

        public static bool IsValid(string s)
        {
            var case1 = new char[2] { '(', ')' };
            var case2 = new char[2] { '{', '}' };
            var case3 = new char[2] { '[', ']' };

            var openCases = new List<char>();

            foreach (char c in s)
            {
                if ((c == case1[0]) || (c == case2[0]) || (c == case3[0]))
                {
                    openCases.Add(c);
                }
                else
                {
                    var openC = ((case1[1] == c) ? case1[0] : (case2[1] == c) ? case2[0] : case3[0]);

                    if (openCases.Any() && openCases.Last() == openC)
                    {
                        openCases.RemoveAt(openCases.Count-1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }


            if (openCases.Any())
                return false;

            return true;
        }
    }
}
