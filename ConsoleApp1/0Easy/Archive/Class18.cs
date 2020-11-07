using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class18
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


            var b = Divide(-2147483648, -1);

            Console.WriteLine(b);
            Console.ReadLine();
        }

        public static int Divide(int dividend, int divisor)
        {
            var cnt = 0;

            var isNegative = (dividend < 0 || divisor < 0) && !(dividend < 0 && divisor < 0);

            if (dividend < 0)
                dividend = -dividend;

            if (divisor < 0)
                divisor = -divisor;

            var rest = dividend;
            while (rest >= divisor)
            {
                rest = rest - divisor;
                cnt++;
            }
            return (isNegative ? -1 : 1) * cnt;
        }
    }
}
