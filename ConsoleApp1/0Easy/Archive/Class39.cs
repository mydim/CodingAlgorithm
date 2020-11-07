using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
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

            ///abcd
            ///bacd
            var a = "abczdz";
            var b = "zcbzda";


            ///aaaa


            
            var c = common(a, b);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(c);

            Console.ReadLine();
        }

        private static bool common(string a, string b)
        {
            if (a.Length != b.Length || a.Length <= 1) 
            {
                return false;
            }

            if (a == b)
            {
                var c = new HashSet<char>();
                foreach (var chr in a)
                {
                    c.Add(chr);                    
                }

                if (c.Count < a.Length)
                {
                    return true;
                }

                return false;
            }



            var list = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) {
                    list.Add(i);
                }
            }


            if (list.Count == 2 &&
                a[list[0]] == b[list[1]] &&
                a[list[1]] == b[list[0]]
                ) {
                return true;
            }

            //var arr = new int[255];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    arr[a[i]]++;
            //    arr[b[i]]++;
            //}

            //foreach (var item in arr)
            //{
            //    if (item % 2 == 1) {
            //        return false;
            //    }
            //}
            //return true;
            return false;
        }
    }
}
