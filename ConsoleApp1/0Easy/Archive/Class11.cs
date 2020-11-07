using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class11
    {
        public static void RunCode()
        {
            int[] nuts = new int[] { 10,7,12,8,3,2,6};//, 7, 4 };           
            CodingAlgorithm.CodeUtils.PrintArrayLine(nuts);

            QuickSort(nuts, 0, nuts.Length - 1);

            CodingAlgorithm.CodeUtils.PrintArrayLine(nuts);
            Console.WriteLine("*****************");
        }

        public static void QuickSort(int[] nuts, int l, int r)
        {
            if (l < r)
            {
                var p = Partitioning(nuts, l, r, nuts[l]);                

              //  QuickSort(nuts, l, r - 1);
              //  QuickSort(nuts, l + 1, r);
            }
        }

        public static int Partitioning(int[] arr, int low, int high, int pivotValue)
        {
            Console.WriteLine("Pivot value:" + pivotValue + "   indx:" + low);
            int p = low;

            for (int i = low; i < high; i++)
            {
                CodingAlgorithm.CodeUtils.PrintArrayLine(arr, "Swap: {0} > ");// + arr[a] + " <> " + arr[b]);

                if (arr[i] < pivotValue)
                {
                    Swap(arr, p, i);
                    p++;
                }
                else if (arr[i] == pivotValue)
                {
                    Swap(arr, high, i);
                    i--;
                }
            }

            Swap(arr, p, high);
            return p;
        }

        static void Swap(int[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;

            
        }
    }
}
