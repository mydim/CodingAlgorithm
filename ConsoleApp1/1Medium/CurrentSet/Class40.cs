using CodingAlgorithm;
using OpenNLP.Tools.Coreference.Similarity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class40
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

            var w1 = "abba";
            var w2 = "dog dog dog dog";
            var b1 = WordPattern(w1, w2);

            var ff = 7;
            var z = CountPrimes(ff);
            Console.WriteLine(z);

            //for (int i = 0; i < length; i++)
            //{

            //}

            //foreach (var item in collection)
            //{

            //}

            //var a = new int[3][] {new int[]{ 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9} };
            //var b = MinFallingPathSum(a);
            var a = new ListNode(1);
            a.next = new ListNode(0);
            a.next.next = new ListNode(1);

            var b = GetDecimalValue(a);



            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static bool WordPattern(string pattern, string s)
        {
            var split = s.Split(' ');

            if (pattern.Length != split.Length) return false;
            var mapped = new HashSet<char>();

            var map = new Dictionary<char, char>();
            for (int i = 0; i < pattern.Length; i++)
            {
                var toMap = split[i][0];

                if (map.ContainsKey(pattern[i]))
                {
                    if (map[pattern[i]] != toMap)
                    {
                        return false;
                    }
                }
                else
                {
                    if (mapped.Contains(toMap)) {
                        return false;
                    }
                    map.Add(pattern[i], toMap);
                    mapped.Add(toMap);
                }
            }

            return true;
        }

        public static int CountPrimes(int n)
        {
            if (n < 2)
                return 0;

            var not_prime = new bool[n-1];
            var count = 0;

            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j * i < n; j++)
                {
                    //2 3 4 5 6 7 8 9 
                    //2 3

                    if (!not_prime[j * i-1])
                    {
                        not_prime[j * i-1] = true;
                        count++;
                    }
                }
            }

            return n - count -1;
        }


        public static int TitleToNumber(string s)
        {
            var i = 0;

            for (int j = s.Length -1; j >=0; j--) {
                var c = s[i];

                var val = Helper(c);

                i = val + i * 26;
            }

            return i;
        }

        static int Helper(char c) {
            return (int)c - 'A' + 1;
        }



        public class ListNode
        {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
           {
                this.val = val;
                this.next = next;
                     }
  }
        public static int GetDecimalValue(ListNode head)
        {
            var res = 0;

            while (head != null)
            {   
                res *= 2;
                res += head.val;

                head = head.next;
            }

            return res;
        }


        public static int MinFallingPathSum(int[][] A)
        {
            return Helper(A, 0, -1, 0, new List<int>());
        }


        public static int Helper(int[][] A, int rowIndex, int lastColumnIndex, int sum, List<int> list)
        {
            if (rowIndex == A.Length) return sum;

            var smallestSum = int.MaxValue;
            var start = lastColumnIndex <= 0 ? 0 : lastColumnIndex - 1;
            var end = start + 1 == A[rowIndex].Length ? start : start + 1;

            for (int i = start; i < end; i++)
            {
                sum += A[rowIndex][i];
                list.Add(A[rowIndex][i]);

                CodeUtils.PrintList(list, "Before sum:"+ sum+ " smallest:" + smallestSum.ToString() + " - {0}");

                if (rowIndex + 1 == A.Length)
                {
                    smallestSum = Math.Min(sum, smallestSum);
                }
                else
                {
                    smallestSum = Math.Min(smallestSum, Helper(A, rowIndex + 1, i, sum, list));
                }

                
                CodeUtils.PrintList(list, "After sum:" + sum + " smallest:" + smallestSum.ToString() + " - {0}");

                list.RemoveAt(list.Count-1);
                sum -= A[rowIndex][i];
            }

            return smallestSum;
        }
    }
}
