using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class04
    {

        static int FindIndexOfValue(int[] a, int val)
        {
            return FindIndexOfValue(a, val, 0, a.Length-1);
        }

        static int FindIndexOfValue(int[] a, int val, int checkPosFrom, int checkPosTo)
        {
            if (a.Length == 0)
                return -1;

                       
            // 50 100


            var checkPos = checkPosFrom + (checkPosTo - checkPosFrom) / 2;
            if (a[checkPos] == val)
                return checkPos;
            
            if (val < a[checkPos])
                return FindIndexOfValue(a, val, checkPosFrom, checkPos - 1);
            else
                return FindIndexOfValue(a, val, checkPos +1 , checkPosTo);
        }

        public static void RunCode()
        {
            var arr = new int[] { 1,3,4,5,6,10,15,20,25,50,100,200,1000};

            var indx = FindIndexOfValue(arr, 4);

            //_arrayData = new List<KeyValuePair<int, int>>();
            //var arr1 = new int[0];

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




        static int binary_search_rec(int[] A, int key, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }

            int mid = low + ((high - low) / 2);
            if (A[mid] == key)
            {
                return mid;
            }

            if (key < A[mid])
            {
                return binary_search_rec(A, key, low, mid - 1);
            }

            return binary_search_rec(A, key, mid + 1, high);
        }

        static  int binary_search_recursive(int[] A, int key, int len)
        {
            return binary_search_rec(A, key, 0, len - 1);
        }
    }
}
