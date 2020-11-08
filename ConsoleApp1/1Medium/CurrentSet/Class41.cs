using CodingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class41
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


            var ff = 2;
            var f1 = new int[1][] { new int[2] { 1, 2 } };
            var f2 = FindJudge(ff, f1);


            //for (int i = 0; i < length; i++)
            //{

            //}

            //foreach (var item in collection)
            //{

            //}

            var x = "loveleetcode";
            var c = 'e';
            var z = shortestToChar(x, c);




            //var a = new int[] { 5, 4, 3, 2, 1 };
            //var b = NextGreaterElements(a);
            //CodeUtils.PrintArray(b);

            //    var b = common("I was here", "I have been here");

           // Console.WriteLine(b);

            Console.ReadLine();
        }


        public static int FindJudge(int N, int[][] trust)
        {
            if (N == 1) return -1;
            if (N == 0) return -1;

            var peopleWhoTrust = new List<int>();
            var trustedByEveryone = new List<int>();

            var trustCounts = new Dictionary<int, int>();


            // trusted by everyone
            for (int i = 0; i < trust.Length; i++)
            {  //  O(n)

                var trustList = trust[i];
                if (trustList.Any())
                {
                    peopleWhoTrust.Add(i + 1);

                    for (int j = 0; j < trustList.Length; j++)
                    {

                        var trusedPerson = trustList[j];
                        if (trustCounts.ContainsKey(trusedPerson))
                        {
                            trustCounts[trusedPerson]++;
                        }
                        else
                        {
                            trustCounts.Add(trusedPerson, 1);
                        }

                        if (trustCounts[trusedPerson] == N-1)
                        {
                            trustedByEveryone.Add(trusedPerson);
                        }
                    }
                }
            }

            for (int i = 1; i <= N; i++)
            {
                if (trustedByEveryone.Contains(i) && !peopleWhoTrust.Contains(i)) { 
                     return i;
                }
            }

            return -1;
        }

        public static int[] shortestToChar(String S, char C)
        {
            int[] result = new int[S.Length];

            // Pointers to track C in S & the current moving index in S respectively
            int cIndex = 0, sIndex = 0;

            // Pointer to track the previous occurrence of C in S - Initially set to -1
            int prevCIndex = -1;

            while (cIndex < S.Length)
            {
                // Find the first/next occurrence of C in S
                while (cIndex < S.Length && S[cIndex] != C)
                {
                    cIndex++;
                    Console.WriteLine(cIndex);

                }

                // Move the S pointer until C and fill the result with the shortest distance
                while (sIndex < cIndex)
                {
                    if (prevCIndex == -1)
                    {
                        // Initial stage where there is no previous occurrence of C in S yet
                        result[sIndex] = cIndex - sIndex;
                    }
                    else if (cIndex < S.Length && S[cIndex] == C)
                    {
                        // You have both previous and the next occurrences of C in S - Get the minimum
                        result[sIndex] = Math.Min(cIndex - sIndex, sIndex - prevCIndex);
                    }
                    else
                    {
                        // Last stage where you crossed the last occurrence of C in S
                        result[sIndex] = sIndex - prevCIndex;
                    }

                    // Increment the current pointer in S
                    sIndex++;
                    Console.WriteLine(cIndex);
                }

                // Set the current occurrence of C to previous
                prevCIndex = cIndex;

                // Increment both the pointers
                sIndex++;
                cIndex++;

                Console.WriteLine(cIndex);
            }

            return result;
        }



        public static int[] NextGreaterElements(int[] nums)
        {

            var dict = new Dictionary<int, int>(); //O(nums2)
            var rest = Helper(nums, dict);
            Helper(rest, dict);

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    nums[i] = dict[nums[i]];
                }
                else
                {
                    nums[i] = -1;
                }
            }

            return nums;
        }

        static int[] Helper(int[] arr, Dictionary<int, int> dict)
        {
            var stack = new Stack<int>(); //O(nums)
            for (int i = 0; i < arr.Length; i++)
            {

                while (stack.Any() && stack.Peek() < arr[i])
                {
                    if (!dict.ContainsKey(stack.Peek()))
                    {
                        dict.Add(stack.Pop(), arr[i]);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }

                stack.Push(arr[i]);
            }

            var list = new List<int>();
            while (stack.Any())
            {
                list.Add(stack.Pop());
            }

            var res = list.ToArray();
            return res;
        }
    }
}

