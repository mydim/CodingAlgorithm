using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class32
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

            //    var b = LetterCombinations("237");

            //  Console.WriteLine(string.Join(", ", b.ToArray()));
            // var sb = ReverseWords("a good   example");
            //sb.Append

            var a = 11;
            var b = fuc(a);

            
            //  Console.WriteLine(string.Join(", ", b.ToArray()));
            //    var sb = ReverseWords("a good   example");
            //sb.Append
            Console.WriteLine(b);

            b = fib(a);
            Console.WriteLine(b);


            Console.ReadLine();
        }

        private static long fuc(int n)
        {
            if (n <= 1) return 1;

            return n * fuc(n - 1);
        }

        static int cnt = 0;

        private static long fib(int n)
        {
            cnt++;
            Console.WriteLine(cnt +" "+n);

            if (n <= 0) return 0;
            
            if (n == 1) return 1;

            return fib(n-1) + fib(n-2);
        }


    }
}
