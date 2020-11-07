using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class01
    {


        public static void RunCode()
        {
            var b = LengthOfLongestSubstring("pwwkew"); //TwoSum(new[] { 2, 7, 11, 15 }, 9);


        }



        public static int LengthOfLongestSubstring(string s)
        {

            var maxL = 0;


            for (int i = 0; i < s.Length; i++)
            {
                string s1 = s[i] + "";
                for (int j = i + 1; j < s.Length; j++)
                {
                    //s.Substring
                    //if (s1.IndexOf(c) == -1)
                    //    s1 = s1 + s[j];
                    //else
                    //    break;


                    //if (s1[j - 1 - i] == s[j])
                    //break;

                    ///s1 = s1 + s[j];
                }

                if (s1.Length > maxL)
                    maxL = s1.Length;
            }



            return maxL;
        }
    }
}
