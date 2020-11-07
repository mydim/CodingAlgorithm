using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class37
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

            var candy = 11;
            var person = 3;
            var b = common(candy, person);

            //    var b = common("I was here", "I have been here");
            Console.WriteLine(string.Join(", ", b.ToArray()));

            Console.ReadLine();
        }

        public static int[] common(int candy, int person)
        {
            var arr = new int[person];

            var curPerson = 0;
            var curAmount = 1;
            while (candy > 0)
            {
                if (candy - curAmount < 0)
                {
                    arr[curPerson] += candy;
                    break;
                }
                
                candy -= curAmount;

                arr[curPerson] += curAmount;

                
                curAmount++;
                curPerson++;

                if (curPerson == arr.Length) {
                    curPerson = 0;
                }

            }
            return arr;
        }
    }
}
