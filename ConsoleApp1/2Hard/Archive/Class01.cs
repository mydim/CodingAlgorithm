using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hard
{
    public static class Class01
    {

        //Finding all combinations of well-formed brackets
        //        Output:
        //()
        //(()) () ()
        //((())) (()()) (()) () () (()) () () ()

        public static void RunCode()
        {
            // Given two array of same length and same elements but unique in different order.
            int[] nums1 = new int[] { 1, 2, 3, 4 };
             //int[] bolts = new int[] { 35, 5, 4, 2, 1, 7 };

            //var m = Median(nums1);
            string s = "()(())";
            var a = LongestValidParentheses(s);
            CodingAlgorithm.CodeUtils.PrintArrayLine(nums1);
            Console.WriteLine("*****************");
            //Console.WriteLine(m);
        }

        public static int LongestValidParentheses(string s)
        {
            var cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (c == '(')
                {
                    var l = LengthOfSequence(s, ref i);
                    cnt = cnt + l;
                }
            }

            return cnt * 2;
        }

        private static int LengthOfSequence(string s, ref int i)
        {
            var cnt = 0;
            var isOpen = true;
            var j = i + 1;
            for (; j < s.Length; j++)
            {
                if (s[j] == ')')
                {
                    if (isOpen)
                    {
                        cnt++;
                        isOpen = false;
                        break;
                    }

                    break;
                }

                if (isOpen)
                {
                    var insideCnt = LengthOfSequence(s, ref j);
                    cnt = cnt + insideCnt;
                }

                isOpen = true;
            }

            i = j;
            return cnt;
        }

        //private static object Median(int[] nums1)
        //{
        //    int midIndx = nums1.Length % 2 = 0 ? nums1.Length / 2 : nums1.Length / 2 - 1;


        //   1 3 100

        //   1 2 4 8 = 2.5

        //        1   6  16  = 2
        //        1 2 16 32  = 9 



        //}



        //public void Brackets(int n)
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        Brackets("", 0, 0, i);
        //    }
        //}

        //private void Brackets(string output, int open, int close, int pairs)
        //{
        //    if ((open == pairs) && (close == pairs))
        //    {
        //        Console.WriteLine(output);
        //    }
        //    else
        //    {
        //        if (open < pairs)
        //            Brackets(output + "(", open + 1, close, pairs);
        //        if (close < open)
        //            Brackets(output + ")", open, close + 1, pairs);
        //    }
        //}
    }
}
