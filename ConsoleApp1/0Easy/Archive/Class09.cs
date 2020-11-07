using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class09
    {

        #region Х N1 SuperSimpleFit 
        public static void SuperSimpleFit(int[] target, int[] source)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

        #endregion

        #region Х N2 Sort with Array class

        public static int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }

        public static void SortWithArrayClass(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1, Compare);
            Array.Sort(arr2, Compare);
        }

        #endregion

        #region X N3 Fit second to first

        public static void SimpleFit(int[] target, int[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                SwitchPosition(target, source[i], i);
            }
        }

        public static void SwitchPosition(int[] arr, int value, int to)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    var temp = arr[to];
                    arr[to] = value;
                    arr[i] = temp;
                    break;
                }
            }
        }

        #endregion

        #region N4 Sort

        static void SortByArray(int[] target, int[] source)
        {
            for (int i = 0; i < source.Length; i++)
                OrderValue(target, source[i]);
        }


        static int tryNumber = 0;
        static void OrderValue(int[] arr, int value)
        {
            tryNumber++;

            int keyPos = 0;
            int minPos = 0;

            int check = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                check = arr[i].CompareTo(value);

                if (check < 0) //order value position (count items min position then value)
                    minPos++;
                else
                if (check == 0) //find position in current arr
                    keyPos = i;
            }

            if (keyPos != minPos) //need switch?
            { //switch
                arr[keyPos] = arr[minPos];
                arr[minPos] = value;

                CodingAlgorithm.CodeUtils.PrintArrayLine(arr, "{0} -> value:" + value + " #" + tryNumber);
            }
            //else //no switch
            //    CodingAlgorithm.CodeUtils.PrintArrayLine(arr, "No change {0} value:" + value +" #"+tryNumber);

        }

        #endregion



        public static void RunCode()
        {
            //int[] nuts = new[] { 1, 3, 4, 15, 6, 5 };
            //int[] bolts = new[] { 3, 15, 1, 6, 4, 5 };

            int[] nuts = new[] { 1, 5, 8, 0 };
            int[] bolts = new[] { 8, 1, 5, 0 };

            SortByArray(nuts, bolts);
            Console.WriteLine("*****************");
            SortByArray(bolts, nuts);

            CodingAlgorithm.CodeUtils.PrintArrayLine(bolts);
            Console.WriteLine("*****************");
            CodingAlgorithm.CodeUtils.PrintArrayLine(nuts);
        }




        //bolts
        //nuts        
        //same size, equals values in different order

        //SortByArray(bolts, nuts);

        //target
        //source
        //for over source
        //SortByKey

        //arr (target), key from source

        //6,1,2,3,4,5
        //find current position of a key
        //find right position by comparing with lower keys in source 
        //switch current element with founded right position

        //////////////
        ////SortByArray(nuts, bolts);
        //Sort second array, Source already sorted
        //Find position of current element
        //switch by right position
    }

}