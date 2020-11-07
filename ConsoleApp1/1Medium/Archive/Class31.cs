using CodingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class31
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

            var str = "112358";
            var b = common(str);

            //    var b = common("I was here", "I have been here");

            //  CodeUtils.PrintArray(b);
            Console.WriteLine(b);
            Console.ReadLine();

            /// NOT SOLVED
            //1002500
            //var val = new int[] { 6, 10, 12 };
            //var wt = new int[] { 4, 2, 2 };
            //var w = 6;

        }


        public static bool common(string str)
        {
            var valPrevPrev = 0;

            //0 12 345 6789
            //1 99 100 1999
            for (int indexF = 0; indexF < str.Length -1; indexF++)
            {
                var valPrev = getValue(str, 0, indexF + 1); //100
                valPrevPrev = 0;
                //0
                //-1
                //
                //-1--
                //---3
                //
                //--2
                //-----5
                //01234567890123456
                var secondStart = (indexF + 1) * 2 - 1;

                for (int indexS = secondStart; indexS < str.Length; indexS++)
                {
                    //8-6+1 3
                    var sizeOfSecondDigit = indexS - secondStart + 1;

                    var valNext = getValue(str, secondStart, sizeOfSecondDigit); //1
                    if (valNext == -1)
                    {
                        break;
                    }

                    var sum = getMatchedSum(valPrev - valPrevPrev, valNext, indexS + 1, str);
                    if (sum > 0)
                    {
                        //valPrev 1
                        //valNext 99
                        //sum 100
                        valPrevPrev = valNext;
                        valPrev = sum;

                        //

                        //2+3+1
                        secondStart = indexS + sum.ToString().Length ;
                        //6, 3 -1, 
                        
                        //6+3-1-1
                        indexS = secondStart + sum.ToString().Length - 2;
                    }
                }
            }

            return false;
        }

        private static int getMatchedSum(int val1, int val2, int indexStart, string str)
        {
            var sum = val1 + val2;
            var expectedCount = sum.ToString().Length;

            var valToCheck = getValue(str, indexStart, expectedCount);
            if (sum == valToCheck)
                return sum;
            return -1;
        }

        private static int getValue(string str, int indexStart, int count)
        {
            if (str.Length < indexStart + count)
                return -1;

            return int.Parse(str.Substring(indexStart, count));
        }


        //public static int[] common(int[] val, int[] wt, int w)
        //{
        //    return val;
        //}
    }
}
