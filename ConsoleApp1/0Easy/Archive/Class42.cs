using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class42
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

            var d = new Dictionary<int, int>();
            d.Add(0, 30);
            d.Add(55, 100);
            d.Add(100, 200);

            var a = d.ToArray();
            
            var b = common(a);

            Console.WriteLine(b);

            Console.ReadLine();
        }

        private static bool common(KeyValuePair<int,int>[] arr)
        {
            //*****----------
            //-----*****-----
            //----------*****            
            Array.Sort(arr, (v1, v2) => v1.Key - v2.Key);
            var prev = arr[0].Value;
            for (int i = 1; i < arr.Length; i++)
            {
                var cur = arr[i];

                if (prev > cur.Key)
                {
                    return false;
                }

                //if (prev < cur.Value)
                //{
                    prev = cur.Value;
                //}
            }

            return true;
        }

    }
}
