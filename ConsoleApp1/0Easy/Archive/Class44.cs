using CodingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class44
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




            //var a = new int[] { 1, 2, 3, 4, 5 };
            //var d = 2;
            //var b = rotLeft(a, d);

            //    var b = common("I was here", "I have been here");
            //CodeUtils.PrintArrayLine(b);
            //Console.WriteLine(b);



            uthEvents();
            Console.ReadLine();


        }

        public static void uthEvents()
        {

            var a = new List<int>();

            var pass = "";
            var passHash = 0;
            var passHashCMin = 0;
            var passHashCMax = 0;

            var e = "authorize 244736787";

            passHash = Hash("cAr1");

            if (e.StartsWith("setPassword"))
            {
                pass = e.Replace("setPassword(\"", "").Replace("\")", "");
                passHash = Hash(pass);
                passHashCMin = Hash(pass + (int)char.MinValue);
                passHashCMax = passHashCMin + 255;
            }
            else
            if (e.StartsWith("authorize"))
            {
                var auth = int.Parse(e.Substring(10));

                if (auth == passHash || (auth >= passHashCMin && auth <= passHashCMax))
                { a.Add(1); }
                else
                {
                    a.Add(0);
                }
            }
        }




        public static int Hash(string pas)
        {
            var code = Math.Pow(10, 9) + 7;
            double v = 0;
            for (int i = 0; i < pas.Length; i++)
            {
                v += (int)pas[i] * (double)Math.Pow(131, pas.Length - 1 - i);
            }
            return (int)(v % code);
        }

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
        {
            //0123456
            //1234567
            //
            //3456712
            //2
            //
            if (a.Length == 0) return a;

            var shiftLeft = d % a.Length;
            if (shiftLeft == 0) {
                return a;
            }

            int[] shiftArr = new int[shiftLeft];
            Array.Copy(a, shiftArr, shiftLeft);                        
            for (var i = shiftLeft; i< a.Length; i++)
            {
                a[i - shiftLeft] = a[i];
            }

            for (var i = 0; i < shiftLeft; i++) {
                a[a.Length - shiftLeft + i] = shiftArr[i];
            }

            return a;            
        }
    }
}
