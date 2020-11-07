using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class25
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

            var start = "hit";
            var end = "cxg";

            //var c = isOneCharChange(start, "hot");
            //Console.WriteLine(c);

            var a = new[] { "hot", "dot", "dog", "lot","log", "dxg", "cxg" };
            var b = common(a, start, end);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static int common(string[] list, string cur, string end)
        {
            var mem = new HashSet<string>();
            var res = helper(list, cur, end, mem);
            return res;
        }

        private static int helper(string[] list, string cur, string end, HashSet<string> mem)
        {
            Console.WriteLine("try: " + cur);

            if (mem.Contains(cur))
            {
                return int.MaxValue-1;
            }

            var newMem = mem;
            foreach (var item in mem)
            {
                newMem.Add(item);
            } 
            mem = newMem;
            mem.Add(cur);

            var nextList = getListOfNextWords(list, cur, mem);
            var minPath = int.MaxValue - 1;

            foreach (var checkWord in nextList)
            {
                Console.WriteLine("try: " + cur+ " check:" + checkWord);
                if (checkWord == end)
                {
                    return 1;
                }
                else
                {
                    var pathLength = 1 + helper(list, checkWord, end, mem);
                    if (pathLength < minPath)
                    {
                        minPath = pathLength;
                    }
                }
            }

             return minPath;
        }

        //hot (3) > got (2) > get (1)

        private static List<string> getListOfNextWords(string[] list, string cur , HashSet<string> mem)
        {
            var nextList = new List<string>();

            foreach (var word in list)
            {
                if (mem.Contains(word))
                {
                    continue;
                }

                if (isOneCharChange(word, cur))
                {
                    nextList.Add(word);
                }
            }

            return nextList;
        }

        private static bool isOneCharChange(string word, string cur)
        {
            if (word == cur) return false;

            var hasOneDiff = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != cur[i])
                {                    
                    if (hasOneDiff)
                    {
                        return false;
                    }
                    hasOneDiff = true;
                }
            }
  
            return true;
        }
    }
}
