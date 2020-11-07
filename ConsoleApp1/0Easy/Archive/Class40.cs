using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class40
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

            var arr = new int[] { 1, 2, 2, 3, 4 };
            var v1 = "1.004.11.888.998";
            var v2 = "1.004.11.01";
            var b = comapre(v1,v2);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        private static int comapre(string v1, string v2)
        {
            int a1 = 0;
            int a2 = 0;

            int i1 = 0;
            int i2 = 0;

            var check1 = getNext(v1, ref i1, out a1);
            var check2 = getNext(v2, ref i2, out a2);
            do
            {
                Console.WriteLine(a1 +" "+ a2);
                if (a1 > a2) return 1;
                if (a1 < a2) return -1;

                check1 = getNext(v1, ref i1, out a1);
                check2 = getNext(v2, ref i2, out a2);

            }
            while ((check1 && check2) || (a1!=a2));

            return 0;
        }

        private static bool getNext(string ver, ref int index, out int subVersion)
        {
            if (index == ver.Length) {
                subVersion = 0;
                return false;
            }

            var i = ver.IndexOf('.', index);
            var strSubVersion = "";
            if (i == -1)
            {
                strSubVersion = ver.Substring(index, ver.Length - index);
                index = ver.Length;
            } else {
                strSubVersion = ver.Substring(index, i - index);
                index = i + 1;
            }

            subVersion =  int.Parse(strSubVersion);
            return true;
        }

        public static bool ContainsDuplicate(int[] arr)
        {
            if (arr.Length == 0) return false;

            var h = new HashSet<int>();
            foreach (var item in arr)
            {
                if (h.Contains(item)) 
                { return false; }
            }

            return true;
        }
    }
}
