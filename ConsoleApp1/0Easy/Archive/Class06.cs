using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class06
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
            //Console.Write("");
            //Console.ReadLine();
            //return ;
            //Console.WriteLine((int)'A');
            //Console.WriteLine((char)65);

            ////1
            //Console.WriteLine(FindMaximumConsecutive("aaaaaabbcbrrrrrrrrrrrrrrrrrbbbbcbbbb"));

            ////2
            //int[] A = { 1, 5, 7, 12, 18, 32 };
            //int[] B = { 2, 4, 9, 16, 27, 76, 98 };
            //CodingAlgorithm.CodeUtils.PrintArray(MergeSortedArrays(A, B));

            //3.            Write a small method  to do the below task.. this is not in sorted order..all negative characters in left and positive on the right..
            //input = { 4, -3, 2, -5, 5, -1, 3}
            //        output= {-3,-5, -1, 4, 2, 5, 3}
            //var A = new int[]{ 4, -3, 2, -5, 5, -1, 3 }; 
            //CodingAlgorithm.CodeUtils.PrintArray(NegativeToLeft(A));

            //4.            Segregate 0s on left side and 1s on right side of the array.Traverse array only once.
            //Input array   =  [0, 1, 0, 1, 0, 0, 1, 1, 1, 0]
            //Output array =  [0, 0, 0, 0, 0, 1, 1, 1, 1, 1]
            //var A = new int[] { 0, 1, 0, 1, 0, 0, 1, 1, 1, 0 };
            //CodingAlgorithm.CodeUtils.PrintArray(SortBitArray(A));


            //5.            Given an unsorted array and a number n, find if there exists a pair of elements in the array whose difference is n.
            //Examples:
            //Input: arr[] = { 9, 29,10, 2, 50, 24, 100}, n = 50
            //Output: Pair Found: (50, 100)
            //var A = new int[]{ 9, 29, 10, 2, 50, 24, 100 };
            //var n = 50;
            //CodingAlgorithm.CodeUtils.PrintArray(IsExistDifference(A, n));


            //6
            //var str = "fasfasdfadfasd2222sdfsdf";
            //Console.WriteLine(MostRepeatedCharacter(str));
            //   Console.WriteLine(ReverseWords("a b c"));

            //            Console.WriteLine(IsAnagrams("abc", "acb"));
            //Console.WriteLine(StringRepCharsMaxLength("aaab bbbf qwer trewq"));
            var A = new int[] { 1,1,1,3,4,5,4,5,5 };
            Console.WriteLine(FindNonRepNumber(A));

            

          ///  Console.WriteLine(Factorial(4));
            Console.ReadLine();
        }




        ///Write a code for finding non repeating number in a array
        public static int FindNonRepNumber(int[] arr)
        {
            var res = -1;

            if (arr == null || arr.Length == 0)
                return res;

            //var list = new List<int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    var cur = arr[i];

            //    if (list.Contains(cur))
            //    {
            //        if (res == cur)
            //            res = -1;
            //    }
            //    else
            //    {
            //        res = arr[i];
            //        list.Add(i);
            //    }
            //}



            for (int i = 0; i < arr.Length; i++)
            {
                var cur = arr[i];
                var isUnique = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (j == i) break;

                    if (cur == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    res = cur;
                    break;
                }
            }


            return res;
        }


        public static bool IsAnagrams(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                return false;
            if (s1 == s2)
                return true;

            return SortString(s1) == SortString(s2);                   

        }




        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }


        //16.          Function to print the Factorial of a given number
        public static long Factorial(int n)
        {
            var val = 1;
            for (int i = 1; i <= n; i++)
            {
                val = val * i;
            }

            return val;
        }




        public static int[] TowSum(int[] a, int sum)
        {
            if (a==null) return null;
            if (a.Length < 2) return null;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i == j) continue;

                    if (a[i] + a[j] == sum)
                        return new int[] { a[i], a[j] };
                    
                }
            }

            return null;
        }


        //20.          Check whether the string is unique or not.
        public static bool IsUniqueString(string str)
        {
            if ((str == null) || (str.Length <= 1))
                return true;

            //1) array of all chars
            //2) sort and check doublicates
            //3) List<Char)

            return true;
        }

        //21.          Swap numbers without addl variable
        public static void Swap(ref int a, ref int b)
        {
            //a=5
            //b=1
            a = a + b;//6
            b = a - b;//5 => b
            a = a - b;//1 => a
        }

        //25.          find the length of the longest substring without repeating characters
        public static bool IsStringHasRepChars(string str, int start, int cnt)
        {
            var checkStr = str.Substring(start, cnt);

            var chrs = checkStr.ToCharArray();

            var checkChar = char.MinValue;
            foreach (Char c in chrs)
            {
                if (c == checkChar)
                    return true;

                checkChar = c;
            }

            return false;
        }

        public static int StringRepCharsMaxLength(string str)
        {
            //System.Collections.Hashtable
            if (str == null) return 0;
            if (str.Length==0) return 0;

            //var lines = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            
            var pos = 0;
            var maxLengthNoRep = 0;

            bool isStrEndReached = false;

            do
            {
                var nextSpace = str.IndexOf(' ', pos);
                if (nextSpace == -1)
                {
                    nextSpace = str.Length;
                    isStrEndReached = true;
                }

                var len = nextSpace - pos;
                if (!IsStringHasRepChars(str, pos, len))
                {
                    if (len > maxLengthNoRep)
                        maxLengthNoRep = len;
                }

                pos = nextSpace+1;           
            

            }
            while (!isStrEndReached);



            return maxLengthNoRep;
        }




        //8.           Tic tac toe 3x3 solving
        //9.           Tic tac toe check winner



        //11.          Combination of 3 numbers to match sum in array


        //14.          Most Frequent Element in an array
        //15.          Gave a solution using two for loops.

        //17.          Most frequent number in an array

        //19.          Most frequent element in an array


        //22.          consider there is largest array
        //23.          char[] Input = new char[10000]; {a,b,\n,c,d,e,\n,f,g,\n,h,\n.........}
        //24.          char[] output = new char[4];

        //26.          string s = "abcabcbb"  out put abc
        //27.          Write a function that parses an input buffer and sends output of the size of output array.We should also return the position of the input buffer and the size used in the output array.
        //When the input array has '/n' we should return it as '\r ' '\n' as two separate characters.
        //Do all the validation and check for edge cases.
        //       23. Design a data structure for Users and Groups in which
        //                 1.user will have some custom properties
        //                2.Groups will have custom properties and Users in the group.
        //                3.Groups can have multiple child groups and multiple parent groups.
        //                4.When you detect a loop in the parent child relation don't accept that.


        //Problem Solving
        //29.       Print Fibonacci Series
        //30.       Swap Two Numbers, without Addl variable.
        //31.       Check if the string is unique?
        //32.       Swap Numbers without addl variable?
        //33.      Difference between (Brute Force and Optimal solution)



        //        1.            find maximum consecutive repeating character in string.
        //Input : str = "aaaaaabbcbbbrrrrrrrrrrrrrrrrbbcbbbb"
        //Output :a
        public static char FindMaximumConsecutive(string str)
        {

            if ((str == null) || (str.Length == 0))
                return Char.MinValue;

            var repChar = Char.MinValue;
            var maxRepCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                var c = str[i];
                var rep = 0;

                for (int j = i + 1; j < str.Length; j++)
                {
                    if (c != str[j])
                    {
                        i = j;
                        break;
                    }

                    rep++;

                    if (rep > maxRepCount)
                    {
                        repChar = c;
                        maxRepCount = rep;
                    }
                }
            }

            return repChar;
        }




        //2.            Merge two sorted arrays into one sorted array
        //int[] A = { 1, 5, 7, 12, 18, 32 }
        //int[] B = { 2, 4, 9, 16, 27, 76, 98 }     
        public static int[] MergeSortedArrays(int[] A, int[] B)
        {
            if ((A.Length == 0) || (B.Length == 0))
            {
                if (A.Length == 0)
                    return B;

                return A;
            }

            var C = new int[A.Length + B.Length];

            var indxA = 0;
            var indxB = 0;

            for (int i = 0; i < C.Length; i++)
                C[i] =  ((indxA < A.Length) && ((indxB >= B.Length) || (A[indxA] < B[indxB]))) ? A[indxA++] : B[indxB++];

            return C;

        }



        //3.            Write a small method  to do the below task.. this is not in sorted order..all negative characters in left and positive on the right..
        //input = { 4, -3, 2, -5, 5, -1, 3}
        //        output= {-3,-5, -1, 4, 2, 5, 3}
        public static int[] NegativeToLeft(int[] A)
        {
            int inxRight = A.Length - 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0) //Is negative
                    continue;

                for (int j = inxRight; j > i; j--)
                {
                    if (A[j] < 0)
                    {
                        var temp = A[j];
                        A[j] = A[i];
                        A[i] = temp;
                        inxRight = j - 1;
                        break;
                    }
                }
            }
            return A;
        }


        //4.            Segregate 0s on left side and 1s on right side of the array.Traverse array only once.
        //Input array   =  [0, 1, 0, 1, 0, 0, 1, 1, 1, 0]
        //Output array =  [0, 0, 0, 0, 0, 1, 1, 1, 1, 1]
        public static int[] SortBitArray(int[] A)
        {
            CodingAlgorithm.CodeUtils.PrintArrayLine(A);

            var cntZero = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    cntZero++;
                    A[i] = 1;
                }
            }

            for (int i = 0; i < cntZero; i++)
                A[i] = 0;

            return A;
        }




        //5.            Given an unsorted array and a number n, find if there exists a pair of elements in the array whose difference is n.
        //Examples:
        //Input: arr[] = { 9, 29,10, 2, 50, 24, 100}, n = 50
        //Output: Pair Found: (50, 100)
        public static int[] IsExistDifference(int[] A, int n)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (j == i)
                        continue;

                    if (Math.Abs(A[i] - A[j]) == n)
                        return new int[] { A[i], A[j] };
                }
            }

            return new int[0];
        }



        //6.            Write a simple code for finding the most repeated character in given string
        public static char MostRepeatedCharacter(string str)
        {
            var chrs = new int[255];
            var maxCnt = 0;
            var maxChar = Char.MinValue;

            foreach (var c in str)
            {
                var val = chrs[(int)c]++;
                if (val > maxCnt)
                {
                    maxCnt = val;
                    maxChar = c;
                }
            }

            return maxChar;
        }



        //7.            write a simple function to check if the Binary Tree is a Binary Search Tree.
        public static bool IsBST(Node n)
        {
            return IsBST(n, int.MinValue, int.MaxValue);
        }


        public static bool IsBST(Node n, int min, int max)
        {
            if (n == null)
                return true;

            if (n.data < min || n.data > max)
                return false;

            return IsBST(n.left, min, n.data - 1) && IsBST(n.right, n.data - 1, max);
        }



        //10.          Write a helper function to return input array data in small chunks by replacing \n with \r\n.
        public static string[] StringToLines(string str)
        {
            str = str.Replace("\n", "\r\n");
            return new string[] { };// str.Split(new[] { "\r\n" });
        }


        //12.          Write a function to reverse the order of words in a string?
        public static string ReverseWords(string str)
        {
            var lines = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var sb = new StringBuilder();

            if (lines.Length > 0)
                sb.Append(lines[lines.Length - 1]);

            if (lines.Length > 1)
                for (int i = lines.Length - 2; i >= 0; i--)
                {
                    sb.Append(" " + lines[i]);
                }

            return sb.ToString();
        }


        //13.          Write a function to check if two strings are anagrams or not ?
        public static string SortString(string str)
        {
            var arr = str.ToCharArray();
            Array.Sort(arr);

            return new string(arr);

        }
    }
}
