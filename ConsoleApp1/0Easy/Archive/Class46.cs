using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class46
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

            var a = "test";
            var c = "tesd";
            var b = common(a, c);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static bool common(string a1, string a2)
        {
            if (a1==null || a2==null) return false;

            var diff = Math.Abs(a1.Length - a2.Length);
            if (diff > 1) return false;

            var countMistakes = 0;
            if (diff == 0)
            {
                for (int i = 0; i < a2.Length; i++)
                {
                    if (a1[i] != a2[i])
                        countMistakes++;

                    if (countMistakes > 1)
                        return false;
                }
                
                return countMistakes == 1;
            }
            else
            { 
                ///cat
                /// at
                ///ca
                ///
                ///ant 
                ///a t
                ///
                //a1.Length -2
            }

            var b = false;

            

            var size = Math.Min(a1.Length, a2.Length);


            return b;
        }
    }
}
