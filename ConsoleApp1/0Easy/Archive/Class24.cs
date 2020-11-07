using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class24
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

            var b = HammingDistance(4, 1);
            Console.WriteLine(b);
            Console.ReadLine();
        }


        public static int HammingDistance(int x, int y)
        {
            var sx = Convert.ToString(x, 2);
            var sy = Convert.ToString(y, 2);
            Console.WriteLine(sx);
            Console.WriteLine(sy);

            var ix = sx.Length - 1;
            var iy = sy.Length - 1;
            var cntMatchedBits = 0;
            while (ix >-1 || iy > -1)
            {
                if (GetStringValueByIndex(sx,ix) != GetStringValueByIndex(sy,iy))
                {
                    cntMatchedBits++;
                }

                iy--;
                ix--;
            }

            return cntMatchedBits;
        }

        public static char GetStringValueByIndex(string str, int index)
        {
            if (index < 0)
                return '0';
            else
                return str[index];
        }

    }
}
