using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class19
    {
        //Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.



        //    Example 1:

        //Input: "Hello"
        //Output: "hello"
        //Example 2:

        //Input: "here"
        //Output: "here"
        //Example 3:

        //Input: "LOVELY"
        //Output: "lovely"
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

            var s1 = ToLowerCase("AZa@AHELLO");
            Console.WriteLine(s1);

            var s2 = ToLowerCase("T$&est");
            Console.WriteLine(s2);

            Console.ReadLine();
        }

        public static string ToLowerCase(string str)
        {
            var s = new StringBuilder();
            foreach (var c in str)
            { 
                var i = (int) c;
                if ((i >= 65) && (i < 90))
                {
                    s.Append((char) (i + 32));
                }
                else
                {
                    s.Append(c);
                }
            }
            return s.ToString();
        }

    }
}
