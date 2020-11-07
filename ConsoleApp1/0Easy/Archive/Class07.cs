using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class07
    {
   
        public static void countSort(int[] arr, int pivot)
        {
            int count = 0;
            int pos = 0;
            for (int idx = 0; idx < arr.Length; idx++)
            {
                var diff = arr[idx].CompareTo(pivot);
                if (diff < 0)                    
                    count++;
                else
                if (diff == 0)
                    pos = idx;
            }

            arr[pos] = arr[count];
            arr[count] = pivot;
        }

        public static void Sort(int[] nuts, int[] bolts)
        {
            // nuts: 1,2,3,4,5,6
            // bolts: 1,2,3,4,5,6
            for (int idx = 0; idx < nuts.Length; idx++)
                countSort(bolts, nuts[idx]);
            for (int idx = 0; idx < nuts.Length; idx++)
                countSort(nuts, bolts[idx]);
        }

        /// <summary>
        /// Given a bag of nuts and a bag of bolts, each having a different size within a bag but exactly one match in the other bag, 
        /// give a fast algorithm to find all matches.
        /// </summary>
        /// <param name="nuts"></param>
        /// <param name="bolts"></param>
        public static void Sport(int[] arr, int pos)
        {
            var posValue = arr[pos];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == pos) continue;

                var diff = posValue.CompareTo(arr[i]);
                if (diff == 0) continue;

//                if(diff<)


            }
        }

        public static void RunCode()
        {
            var nuts = new int[] { 1, 3, 5, 2, 4, 6 };
            var bolts = new int[] { 3, 5, 4, 2, 1, 6 };
            Sort(nuts, bolts);

            CodingAlgorithm.CodeUtils.PrintArrayLine(nuts);
            CodingAlgorithm.CodeUtils.PrintArrayLine(bolts);

            //int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9, 1 };

            //int temp = 0;

            //for (int write = 0; write < arr.Length; write++)
            //{
            //    for (int sort = 0; sort < arr.Length - 1; sort++)
            //    {
            //        if (arr[sort] > arr[sort + 1])
            //        {
            //            temp = arr[sort + 1];
            //            arr[sort + 1] = arr[sort];
            //            arr[sort] = temp;
            //        }
            //    }
            //}

            //CodingAlgorithm.CodeUtils.PrintArrayLine(arr);

            ///Console.ReadKey();



            //for (int i = 0; i < nuts.Length; i++)
            //{
            //    placeInOrder(nuts, i);
            //    placeInOrder(bolts, i);
            //}


            ///Array.Sort(nuts);
            //Array.Sort(bolts);

            //

            // sort 
            // nuts: 1,2,4,5,6,7
            // bolts: 1,2,4,5,6,7




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
        }

        //int a = 1;
        //int b = 2;

        //b += a;
        //    a -= b;
        //    b += a;

        //    Console.WriteLine("a=" + a);
        //    Console.WriteLine("b=" + b);


    }
}
