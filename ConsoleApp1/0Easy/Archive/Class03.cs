using CodingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class03
    {

        public static void RunCode()
        {


            Utils.TimerRestart();
            moveZerosToEnd(new int[] { 12, 0, 7, 0, 8, 0, 3 });
            Utils.TimerWriteLine();

            Console.WriteLine();
            moveZerosToEnd(new int[] { 1, -5, 0, 0, 8, 0, 1 });
            Console.WriteLine();
            moveZerosToEnd(new int[] { 0, 1, 0, 1, -5, 0, 4 });
            Console.WriteLine();
            moveZerosToEnd(new int[] { -4, 1, 0, 0, 2, 21, 4 });
            Console.WriteLine();
        }

        static void moveZerosToEnd(int[] arr)
        {



            int lastZeroIndex = arr.Length - 1;

            for (int i = 0; i <= lastZeroIndex; i++)
            {
                if (arr[i] == 0)
                    MoveZeroToTheEnd(arr, i, ref lastZeroIndex);
            }
            CodeUtils.PrintArray(arr);
        }

        private static void MoveZeroToTheEnd(int[] arr, int curIndex, ref int lastZeroIndex)
        {
            for (int i = lastZeroIndex; i > curIndex; i--)
            {
                if (arr[i] == 0)
                {
                    lastZeroIndex = i;
                    continue;
                }

                arr[curIndex] = arr[i];
                arr[i] = 0;
                break;
            }
        }
    }
}
