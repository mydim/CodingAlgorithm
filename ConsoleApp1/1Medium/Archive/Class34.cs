using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class34
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

            var a = "abcdebb";
            var b = common(a);

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static int common(string a)
        {
            int pa = 0;
            int pb = 0;
            int max = 0;

            var h = new HashSet<char>();

            while (pb < a.Length) {

                if (!h.Contains(a[pb]))
                {
                    h.Add(a[pb]);
                    pb++;
                    max = Math.Max(max, h.Count);
                }
                else {
                    h.Remove(a[pa]);
                    pa++;
                }
            }

            return max;
        //    return a;
        }
    }
}
