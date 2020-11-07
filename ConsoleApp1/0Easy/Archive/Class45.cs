using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class45
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

            var a = "1";
            var b = common(a,7);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static string common(string a, int count)
        {
            for (int i = 0; i < count; i++)
            {
                a = say(a);
            }
            return a;
        }

        private static string say(string a)
        {
            var sb = new StringBuilder();
            char lastDigit =char.MinValue;
            var lastDigitCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (lastDigitCount == 0)
                {
                    lastDigitCount = 1;
                    lastDigit = a[i];
                } else
                if (a[i] == lastDigit)
                {
                    lastDigitCount++;
                }
                else
                {
                    sb.Append(lastDigitCount.ToString() + lastDigit);
                    lastDigitCount = 1;
                    lastDigit = a[i];
                }
            }

            if (lastDigitCount > 0)
            {
                sb.Append(lastDigitCount.ToString() + lastDigit);
            }


             a = sb.ToString();
            Console.WriteLine(a);
            return a;
        }
    }
}
