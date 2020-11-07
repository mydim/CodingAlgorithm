using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class43
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

            var h = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            var str = "abc";
            var b = designerPdfViewer(h, str);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        static int designerPdfViewer(int[] h, string word)
        {

            var len = word.Length;

            var hMax = 0;
            foreach (var c in word)
            {
                hMax = Math.Max(hMax, h[(int)c - 97]);
            }

            return hMax * len;
        }
    }
}
