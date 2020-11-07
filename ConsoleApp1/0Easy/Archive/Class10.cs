using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class10
    {

        // sort them in ascending order
        // print them after sorting
        // nuts: 1,2,4,5,7,35
        // bolts: 1,2,4,5,7,35

        //Condition:cant use element of same array for comparision while sorting.

        //pivot =nuts[i];
        //Compare all the elements in bolts[] using pivot value.
        //Rearrge the bolts accordingly.
        //Once rearranged => we will get partition Idex.//End element for pivot value;
        //    Call recurrsivly QuickSort(nuts,bolts,st,pIndex-1);
        //    Call recurrsivly QuickSort(nuts,bolts,pIndex-1,eIndex);

        public static void RunCode()
        {
             // Given two array of same length and same elements but unique in different order.
            int[] nuts = new int[] { 1, 35, 5, 2, 7, 4 };
            int[] bolts = new int[] { 35, 5, 4, 2, 1, 7 };

            Sort(nuts, bolts, 0, bolts.Length - 1);

            CodingAlgorithm.CodeUtils.PrintArrayLine(bolts);
            Console.WriteLine("*****************");
            CodingAlgorithm.CodeUtils.PrintArrayLine(nuts);
        }
        

        public static void Sort(int[] nuts, int[] bolts, int l, int r) 
        {
            if (l < r)
            {       
                //
                var p = Partition(nuts, l, r, bolts[l]);
                Partition(bolts, l, r, nuts[p]);

                Sort(nuts, bolts, l, r-1);
                Sort(nuts, bolts, l+1, r);
            }
        }

        public static int Partition(int[] arr, int low, int high, int pivotValue)
        {
            int p = low;

            for (int i = low; i < high; i++)
            {
                if (arr[i] < pivotValue)
                {
                    Switch(arr, p, i);
                    p++;
                }
                else if (arr[i] == pivotValue)
                {
                    Switch(arr, high, i);
                    i--;
                }
            }

            Switch(arr, p, high);
            return p;
        }

        static void Switch(int[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;

            CodingAlgorithm.CodeUtils.PrintArrayLine(arr, "Switch: {0}");
        }


    }
}
